using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace szyfrowanie_prj
{
    public partial class Form1 : Form
    {

        
        RSAEncryptor enc;
        string fileToEncryptPath;
        string encryptedFilePath;
        string publicKeyString;
        string fileToDecryptPath;
        string decryptedFilePath;
        string privateKeyString;
        string sciezkadocelowa;
        string SciezkaOdszyfrowania;
        

        public Form1()
        {
            enc = new RSAEncryptor();
            InitializeComponent();

        }
      

        private void GenerateKeys_Click(object sender, EventArgs e)
        {

            var cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            var publicKey = cryptoServiceProvider.ExportParameters(false);
            string publicKeyString = GetKeyString(publicKey);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Plik XML|*.xml";
            saveFileDialog1.Title = "Wybierz";
            saveFileDialog1.FileName = "kluczpubliczny";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                {
                    AddText(fs, publicKeyString);
                }
            }

            var privateKey = cryptoServiceProvider.ExportParameters(true);
            string privateKeyString = GetKeyString(privateKey);
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "Plik XML|*.xml";
            saveFileDialog2.Title = "Wybierz";
            saveFileDialog2.FileName = "kluczprywatny";
            saveFileDialog2.ShowDialog();
            if (saveFileDialog2.FileName != "")
            {

                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog2.FileName))
                {
                    AddText(fs, privateKeyString);
                }
                PublicKeyTextbox.Text = publicKeyString;
                PrivateKeyTextbox.Text = privateKeyString;
            }
        }

        public static string Encrypt(string TextToEncrypt, string publicKeyString)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(TextToEncrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        public static string Decrypt(string TextToDecrypt, string privateKeyString)
        {
            var bytesToDescrypt = Encoding.UTF8.GetBytes(TextToDecrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {

                                       
                    rsa.FromXmlString(privateKeyString);

                    var resultBytes = Convert.FromBase64String(TextToDecrypt);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string encryptedText = Encrypt(TextToEncrypt.Text, PublicKeyTextbox.Text);
            EncryptedText.Text = encryptedText;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string encryptedText = Decrypt(EncryptedText.Text, PrivateKeyTextbox.Text);
            DecryptedText.Text = encryptedText;
        }

        private void PublicKeySelect_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog pubkey = new OpenFileDialog())
            {
                pubkey.Filter = "All Files|*";
                pubkey.Title = "Wybierz";
                if (pubkey.ShowDialog() != DialogResult.OK) return;
                string filePath = pubkey.FileName;
                string fileName = pubkey.SafeFileName;
                string filePathName = pubkey.FileName.Replace(pubkey.SafeFileName, "");
                PublicKeyPath.Text = filePath;
                string publicKeyText = System.IO.File.ReadAllText(filePath);
                PublicKeyTextbox.Text = publicKeyText;
            }
        }

        private void PrivateKeySelect_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog pubkey = new OpenFileDialog())
            {
                pubkey.Filter = "All Files|*";
                pubkey.Title = "Wybierz";
                if (pubkey.ShowDialog() != DialogResult.OK) return;
                string filePath = pubkey.FileName;
                string fileName = pubkey.SafeFileName;
                string filePathName = pubkey.FileName.Replace(pubkey.SafeFileName, "");
                PrivateKeyPath.Text = filePath;
                string privateKeyText = System.IO.File.ReadAllText(filePath);
                PrivateKeyTextbox.Text = privateKeyText;
            }
        }

        private void FileToEncyptButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pubkey = new OpenFileDialog())
            {
                pubkey.Filter = "All Files|*";
                pubkey.Title = "Wybierz ";
                if (pubkey.ShowDialog() != DialogResult.OK) return;
                string filePath = pubkey.FileName;
                string fileName = pubkey.SafeFileName;
                string filePathName = pubkey.FileName.Replace(pubkey.SafeFileName, "");
                FileToEncryptPath.Text = filePath;
            }
        }
        private void FileToDecryptButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pubkey = new OpenFileDialog())
            {
                pubkey.Filter = "All Files|*";
                pubkey.Title = "Wybierz";
                if (pubkey.ShowDialog() != DialogResult.OK) return;
                string filePath = pubkey.FileName;
                string fileName = pubkey.SafeFileName;
                string filePathName = pubkey.FileName.Replace(pubkey.SafeFileName, "");
                FileToDecryptPath.Text = filePath;
            }
        }

       
        public static void AddText(System.IO.FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        public static string GetKeyString(RSAParameters publicKey)
        {

            var stringWriter = new System.IO.StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, publicKey);
            return stringWriter.ToString();
        }
        // TUTAJ CAŁY SYSTYEM RSA DO PLIKU 
        public class RSAEncryptor
        {
            private RSACryptoServiceProvider cryptoServiceProvider;
            private RSAParameters publicKey;
            private RSAParameters privateKey;
            public string publicKeyString;
            public string privateKeyString;

            public RSAEncryptor()
            {
                cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            }
            
           
           
            public void SzyfrujPlik(string filePath, string destinationFolder, string publicKeyString)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                FileInfo srcFile = new FileInfo(filePath);
                string outFilePath = Path.Combine(destinationFolder, srcFile.Name + ".enc");
                string encryptedText = "";


                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    int maxBlockSize = ((rsa.KeySize - 384) / 8) + 6;
                    int numBytesToRead = (int)srcFile.Length;
                    int numBytesRead = 0;
                    byte[] encryptedFile = new byte[numBytesToRead];
                    string allFileData = "";

                    try
                    {
                        using (FileStream readStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            byte[] bytes = new byte[maxBlockSize];
                            File.Delete(outFilePath);

                            while (numBytesToRead > 0)
                            {
                                int n = readStream.Read(bytes, 0, maxBlockSize);
                                if (n < maxBlockSize)
                                {
                                    byte[] tmp = new byte[n];
                                    Array.Copy(bytes, tmp, n);
                                    bytes = tmp;
                                }

                                if (n == 0) break;

                                byte[] encryptedBytes = new byte[214];
                                encryptedBytes = rsa.Encrypt(bytes, true);
                                string base64Encrypted = Convert.ToBase64String(encryptedBytes) + Environment.NewLine;
                                encryptedText += base64Encrypted;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }
                            File.WriteAllText(outFilePath, encryptedText, Encoding.UTF8);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        return;
                    }
                    stopWatch.Stop();
                    MessageBox.Show("Plik został zaszyfrowany \nCzas: " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");
                }
            }
            public void OdszyfrujPlik(string filePath, string destinationFolder, string privateKeyString)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                FileInfo srcFile = new FileInfo(filePath);
                string outFilePath = Path.Combine(destinationFolder, "odszyfrowany_" + Path.ChangeExtension(srcFile.Name, ""));
                byte[] result = null;

                try
                {
                    using (var rsa = new RSACryptoServiceProvider(2048))
                    {
                        rsa.FromXmlString(privateKeyString.ToString());
                        const Int32 BufferSize = 128;
                        using (Stream source = File.OpenRead(filePath))
                        {
                            using (var streamReader = new StreamReader(source, Encoding.UTF8, true, BufferSize))
                            {
                                String line;
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    byte[] resultBytes = Convert.FromBase64String(line);
                                    byte[] decryptedBytes = rsa.Decrypt(resultBytes, true);
                                    if (result == null)
                                    {
                                        result = decryptedBytes;
                                    }
                                    else
                                    {
                                        var a1 = result;
                                        var a2 = decryptedBytes;
                                        result = new byte[a1.Length + a2.Length];
                                        Buffer.BlockCopy(a1, 0, result, 0, a1.Length);
                                        Buffer.BlockCopy(a2, 0, result, a1.Length, a2.Length);
                                    }
                                }
                            }
                            source.Close();
                        }

                        File.WriteAllBytes(outFilePath, result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
                stopWatch.Stop();
                MessageBox.Show("Plik został odszyfrowany \nCzas: " + stopWatch.Elapsed.ToString(@"hh\:mm\:ss"), "Info");

            }
        }

        private void FileEncryptButton_Click(object sender, EventArgs e)
        {
            
                string sciezka = FileToEncryptPath.Text;
                string publicKey = PublicKeyPath.Text;
                if (sciezka == "")
                {
                    MessageBox.Show("Error");
                }
                else if (publicKey == "")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    string publicKeyText = System.IO.File.ReadAllText(publicKey);
                      
                   

                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string path = folderBrowserDialog.SelectedPath;
                        sciezkadocelowa = path;
                    }
                

                    fileToEncryptPath = sciezka;
                    encryptedFilePath = sciezkadocelowa;
                    publicKeyString = publicKeyText;

                if ( sciezka != "" && publicKey != "" && sciezkadocelowa != "" )
                    {
                    try
                    {
                        enc.SzyfrujPlik(fileToEncryptPath, encryptedFilePath, publicKeyString);
                    }
                    finally { }
                }
                    MessageBox.Show("Plik zapisany w : \n " + sciezkadocelowa);
                
            }
        }

        private void FileDecryptButton_Click(object sender, EventArgs e)
        {
            {
                string sciezka = FileToDecryptPath.Text;
                string privateKey = PrivateKeyPath.Text;

                if (sciezka == "")
                {
                    MessageBox.Show("Error");
                }
                else if (privateKey == "")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    

                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    DialogResult result = folderBrowserDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string path = folderBrowserDialog.SelectedPath;
                        SciezkaOdszyfrowania = path;
                    }


                    string privateKeyText = System.IO.File.ReadAllText(privateKey);
                    string fileText = System.IO.File.ReadAllText(sciezka);

                   

                    if (SciezkaOdszyfrowania != "" && privateKeyText != "" && sciezka != "")
                    {
                        fileToDecryptPath = sciezka;
                        decryptedFilePath = SciezkaOdszyfrowania;
                        privateKeyString = privateKeyText;
                        try
                        {
                            enc.OdszyfrujPlik(fileToDecryptPath, decryptedFilePath, privateKeyString);
                        }
                        finally { }
                    }
                    MessageBox.Show("Plik zapisany w : \n " + SciezkaOdszyfrowania);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
