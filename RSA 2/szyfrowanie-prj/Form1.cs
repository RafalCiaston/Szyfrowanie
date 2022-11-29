using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace szyfrowanie_prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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
                    string fileText = System.IO.File.ReadAllText(sciezka);
                    string encryptedText = Encrypt(fileText, publicKeyText);


                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.Filter = "Wszystkie pliki|*|Plik txt|*.txt";
                    saveFileDialog1.Title = "Wybierz";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                        {
                            AddText(fs, encryptedText);
                        }
                    }
                    MessageBox.Show("Plik zapisany w : \n " + saveFileDialog1.FileName);
                
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
                    string privateKeyText = System.IO.File.ReadAllText(privateKey);
                    string fileText = System.IO.File.ReadAllText(sciezka);
                    string encryptedText = Decrypt(fileText, privateKeyText);
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.Filter = "Wszystkie pliki| *| Plik txt | *.txt";
                    saveFileDialog1.Title = "Wybierz";
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                        {
                            AddText(fs, encryptedText);
                        }
                    }
                    MessageBox.Show("Plik zapisany w : \n " + saveFileDialog1.FileName);
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
