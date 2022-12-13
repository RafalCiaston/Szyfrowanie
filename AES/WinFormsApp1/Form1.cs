using System.Diagnostics;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DieffieHellmanEncryptorAES.InitializeEncryptor();
            ET_DisplayMyPublicKey();
            ET_DisplayMyIV();
            EF_DisplayMyIV();
            EF_DisplayMyPublicKey();
            DT_DisplayMyPublicKey();
            DF_DisplayMyPublicKey();
        }

        public static class DieffieHellmanEncryptorAES
        {
            private static Aes aes;
            private static ECDiffieHellmanCng diffieHellman;

            public static byte[] publicKey;

            public static void InitializeEncryptor()
            {
                aes = Aes.Create();
                diffieHellman = new ECDiffieHellmanCng();
                diffieHellman.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
                diffieHellman.HashAlgorithm = CngAlgorithm.Sha256;
                publicKey = diffieHellman.PublicKey.ToByteArray();
            }

            public static byte[] GetIV()
            {
                return aes.IV;
            }


            //TEKST

            public static string SzyfrujText(string base64OtherPartyPublicKey, string textToEncrypt)
            {
                string base64encryptedText;
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); 

                aes.Key = derivedKey;

               
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            
                            swEncrypt.Write(textToEncrypt);
                        }
                        byte[] encryptedBytes = msEncrypt.ToArray();
                        base64encryptedText = Convert.ToBase64String(encryptedBytes);
                    }
                }
                return base64encryptedText;
            }

            public static string OdszyfrujText(string base64OtherPartyPublicKey, string base64OtherPartyIV, string base64TextToDecrypt)
            {
                string decryptedText;
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                byte[] textToDecrypt = Convert.FromBase64String(base64TextToDecrypt);
                byte[] otherPartyIV = Convert.FromBase64String(base64OtherPartyIV);

                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); 

                aes.Key = derivedKey;
                aes.IV = otherPartyIV;

          
                using (MemoryStream msDecrypt = new MemoryStream(textToDecrypt))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return decryptedText;
            }

            //PLIK
            public static void SzyfrujPlik(string base64OtherPartyPublicKey, string fileToEncryptPath, string destinationFolder)
            {
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); 

                FileInfo srcFile = new FileInfo(fileToEncryptPath);
                string outFilePath = Path.Combine(destinationFolder, srcFile.Name + ".enc");

                aes.Key = derivedKey;

                using (FileStream outFsEncrypt = new FileStream(outFilePath, FileMode.Create))
                {
                    using (CryptoStream csEncrypt = new CryptoStream(outFsEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        int count = 0;
                        int offset = 0;
                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];
                        int bytesRead = 0;

                        using (FileStream inFsEncrypt = new FileStream(srcFile.FullName, FileMode.Open))
                        {
                            do
                            {
                                count = inFsEncrypt.Read(data, 0, blockSizeBytes);
                                offset += count;
                                csEncrypt.Write(data, 0, count);
                                bytesRead += blockSizeBytes;
                            } while (count > 0);
                        }
                        csEncrypt.FlushFinalBlock();
                    }
                }
            }
           
            public static void OdszyfrujPlik(string base64OtherPartyPublicKey, string base64OtherPartyIV, string fileToDecryptPath, string destinationFolder)
            {
                byte[] otherPartyPublicKey = Convert.FromBase64String(base64OtherPartyPublicKey);
                byte[] otherPartyIV = Convert.FromBase64String(base64OtherPartyIV);

                CngKey key = CngKey.Import(otherPartyPublicKey, CngKeyBlobFormat.EccPublicBlob);
                byte[] derivedKey = diffieHellman.DeriveKeyMaterial(key); // Common secret

                FileInfo srcFile = new FileInfo(fileToDecryptPath);
                string outFilePath = Path.Combine(destinationFolder, "decrypted_" + Path.ChangeExtension(srcFile.Name, ""));

                aes.Key = derivedKey;
                aes.IV = otherPartyIV;

                using (FileStream inFsDecrypt = new FileStream(srcFile.FullName, FileMode.Open))
                {
                    using (FileStream outFsDecrypt = new FileStream(outFilePath, FileMode.Create))
                    {
                        int count = 0;
                        int offset = 0;

                        int blockSizeBytes = aes.BlockSize / 8;
                        byte[] data = new byte[blockSizeBytes];

                        using (CryptoStream csDecrypt = new CryptoStream(outFsDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inFsDecrypt.Read(data, 0, blockSizeBytes);
                                offset += count;
                                csDecrypt.Write(data, 0, count);
                            } while (count > 0);

                            csDecrypt.FlushFinalBlock();
                        }
                    }
                }
            }


        }

        public void ET_DisplayMyPublicKey()
        {
            string base64MyPublicKey = Convert.ToBase64String(DieffieHellmanEncryptorAES.publicKey);
            txt_wlasnyklpub.Text = base64MyPublicKey;
        }

        public void ET_DisplayMyIV()
        {
            string base64MyIV = Convert.ToBase64String(DieffieHellmanEncryptorAES.GetIV());
            txt_IV.Text = base64MyIV;
        }

        public void DT_DisplayMyPublicKey()
        {
            string base64MyPublicKey = Convert.ToBase64String(DieffieHellmanEncryptorAES.publicKey);
            txt_wlasnyklpub.Text = base64MyPublicKey;
        }


        private void btn_zaszyfruj_Click_1(object sender, EventArgs e)
        {
            if (txt_dozaszfrowania.Text != "" && txt_klpubdrugiej.Text != "")
            {
                string textToEncrypt = txt_dozaszfrowania.Text;
                string otherPartyPublicKey = txt_klpubdrugiej.Text;
                string encryptedText = DieffieHellmanEncryptorAES.SzyfrujText(otherPartyPublicKey, textToEncrypt);
                txt_zaszyfrowany.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("B³¹d", "Warning");
            }
        }

        private void btn_odszyfruj_Click_1(object sender, EventArgs e)
        {
            if (txt_dodeszyfracji.Text != "" && txt_klpubdrugiej.Text != "" && txt_IVdrugiejdeszyfr.Text != "")
            {
                string textToDecrypt = txt_dodeszyfracji.Text;
                string partnerPublicKey = txt_klpubdrugiej.Text;
                string partnerIV = txt_IVdrugiejdeszyfr.Text;
                string decryptedText = DieffieHellmanEncryptorAES.OdszyfrujText(partnerPublicKey, partnerIV, textToDecrypt);
                txt_odszyfrowany.Text = decryptedText;
            }
            else
            {
                MessageBox.Show("B³¹d", "Warning");
            }
        }

        // Szyfrowanie Pliku

        public void EF_DisplayMyPublicKey()
        {
            string base64MyPublicKey = Convert.ToBase64String(DieffieHellmanEncryptorAES.publicKey);
            EF_my_public_key_input.Text = base64MyPublicKey;
        }

        public void EF_DisplayMyIV()
        {
            string base64MyIV = Convert.ToBase64String(DieffieHellmanEncryptorAES.GetIV());
            EF_iv_input.Text = base64MyIV;
        }

        private void EF_browse_file_to_encrypt_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                EF_file_to_encrypt_path_input.Text = file;
            }
        }

        private void EF_submit_Click(object sender, EventArgs e)
        {
            EF_DisplayMyIV();
            if (EF_file_to_encrypt_path_input.Text != "" && EF_encrypted_file_path_input.Text != "" && EF_partner_public_key_input.Text != "")
            {
                string fileToEncryptPath = EF_file_to_encrypt_path_input.Text;
                string destinationFolder = EF_encrypted_file_path_input.Text;
                string otherPartyPublicKey = EF_partner_public_key_input.Text;

                Stopwatch stopWatch = new Stopwatch();

                try
                {
                    stopWatch.Start();
                    DieffieHellmanEncryptorAES.SzyfrujPlik(otherPartyPublicKey, fileToEncryptPath, destinationFolder);
                    stopWatch.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                MessageBox.Show("Plik zosta³ zaszyfrowany.\nCzas : " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");
            }
            else
            {
                MessageBox.Show("B³¹d", "Warning");
            }
        }

        private void EF_browse_encrypted_file_destination_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                EF_encrypted_file_path_input.Text = path;
            }
        }


        //Deszyfrowanie pliku

        public void DF_DisplayMyPublicKey()
        {
            string base64MyPublicKey = Convert.ToBase64String(DieffieHellmanEncryptorAES.publicKey);
            EF_my_public_key_input.Text = base64MyPublicKey;
        }
        private void DF_browse_file_to_decrypt_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                DF_file_path_to_decrypt_input.Text = file;
            }
        }

        private void DF_submit_Click(object sender, EventArgs e)
        {
            if (DF_file_path_to_decrypt_input.Text != "" && DF_decrypted_file_path_input.Text != "" && EF_partner_public_key_input.Text != "" && DF_iv_input.Text != "")
            {
                string fileToDecryptPath = DF_file_path_to_decrypt_input.Text;
                string destinationFolder = DF_decrypted_file_path_input.Text;
                string otherPartyPublicKey = EF_partner_public_key_input.Text;
                string otherPartyIV = DF_iv_input.Text;

                Stopwatch stopWatch = new Stopwatch();

                try
                {
                    stopWatch.Start();
                    DieffieHellmanEncryptorAES.OdszyfrujPlik(otherPartyPublicKey, otherPartyIV, fileToDecryptPath, destinationFolder);
                    stopWatch.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                MessageBox.Show("Plik zosta³ odszyfrowany\nCzas : " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");
            }
            else
            {
                MessageBox.Show("B³¹d", "Warning");
            }
        }

        private void DF_browse_decrypted_file_destination_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
                DF_decrypted_file_path_input.Text = path;
            }
        }
    }
}
