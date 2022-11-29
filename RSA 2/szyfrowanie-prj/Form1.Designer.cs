namespace szyfrowanie_prj
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PublicKeySelect = new System.Windows.Forms.Button();
            this.PublicKeyPath = new System.Windows.Forms.TextBox();
            this.PrivateKeyPath = new System.Windows.Forms.TextBox();
            this.PrivateKeySelect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FileToEncryptPath = new System.Windows.Forms.TextBox();
            this.FileToEncyptButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.FileToDecryptPath = new System.Windows.Forms.TextBox();
            this.FileToDecryptButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FileDecryptButton = new System.Windows.Forms.Button();
            this.FileEncryptButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PublicKeyTextbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.GenerateKeys = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PrivateKeyTextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DecryptedText = new System.Windows.Forms.RichTextBox();
            this.TextToEncrypt = new System.Windows.Forms.RichTextBox();
            this.EncryptedText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Odszyfrowany tekst";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Klucz publiczny";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PublicKeySelect
            // 
            this.PublicKeySelect.Location = new System.Drawing.Point(347, 204);
            this.PublicKeySelect.Name = "PublicKeySelect";
            this.PublicKeySelect.Size = new System.Drawing.Size(75, 23);
            this.PublicKeySelect.TabIndex = 30;
            this.PublicKeySelect.Text = "Wybierz";
            this.PublicKeySelect.UseVisualStyleBackColor = true;
            this.PublicKeySelect.Click += new System.EventHandler(this.PublicKeySelect_Click_1);
            // 
            // PublicKeyPath
            // 
            this.PublicKeyPath.Location = new System.Drawing.Point(143, 178);
            this.PublicKeyPath.Name = "PublicKeyPath";
            this.PublicKeyPath.Size = new System.Drawing.Size(452, 20);
            this.PublicKeyPath.TabIndex = 31;
            // 
            // PrivateKeyPath
            // 
            this.PrivateKeyPath.Location = new System.Drawing.Point(668, 178);
            this.PrivateKeyPath.Name = "PrivateKeyPath";
            this.PrivateKeyPath.Size = new System.Drawing.Size(460, 20);
            this.PrivateKeyPath.TabIndex = 34;
            // 
            // PrivateKeySelect
            // 
            this.PrivateKeySelect.Location = new System.Drawing.Point(872, 204);
            this.PrivateKeySelect.Name = "PrivateKeySelect";
            this.PrivateKeySelect.Size = new System.Drawing.Size(75, 23);
            this.PrivateKeySelect.TabIndex = 33;
            this.PrivateKeySelect.Text = "Wybierz";
            this.PrivateKeySelect.UseVisualStyleBackColor = true;
            this.PrivateKeySelect.Click += new System.EventHandler(this.PrivateKeySelect_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(869, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Klucz prywatny";
            // 
            // FileToEncryptPath
            // 
            this.FileToEncryptPath.Location = new System.Drawing.Point(143, 515);
            this.FileToEncryptPath.Name = "FileToEncryptPath";
            this.FileToEncryptPath.Size = new System.Drawing.Size(440, 20);
            this.FileToEncryptPath.TabIndex = 37;
            // 
            // FileToEncyptButton
            // 
            this.FileToEncyptButton.Location = new System.Drawing.Point(143, 542);
            this.FileToEncyptButton.Name = "FileToEncyptButton";
            this.FileToEncyptButton.Size = new System.Drawing.Size(75, 23);
            this.FileToEncyptButton.TabIndex = 36;
            this.FileToEncyptButton.Text = "Wybierz";
            this.FileToEncyptButton.UseVisualStyleBackColor = true;
            this.FileToEncyptButton.Click += new System.EventHandler(this.FileToEncyptButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Wybierz plik";
            // 
            // FileToDecryptPath
            // 
            this.FileToDecryptPath.Location = new System.Drawing.Point(668, 515);
            this.FileToDecryptPath.Name = "FileToDecryptPath";
            this.FileToDecryptPath.Size = new System.Drawing.Size(440, 20);
            this.FileToDecryptPath.TabIndex = 40;
            // 
            // FileToDecryptButton
            // 
            this.FileToDecryptButton.Location = new System.Drawing.Point(668, 541);
            this.FileToDecryptButton.Name = "FileToDecryptButton";
            this.FileToDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.FileToDecryptButton.TabIndex = 39;
            this.FileToDecryptButton.Text = "Wybierz";
            this.FileToDecryptButton.UseVisualStyleBackColor = true;
            this.FileToDecryptButton.Click += new System.EventHandler(this.FileToDecryptButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(665, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Wybierz plik";
            // 
            // FileDecryptButton
            // 
            this.FileDecryptButton.Location = new System.Drawing.Point(872, 541);
            this.FileDecryptButton.Name = "FileDecryptButton";
            this.FileDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.FileDecryptButton.TabIndex = 41;
            this.FileDecryptButton.Text = "Odszyfruj";
            this.FileDecryptButton.UseVisualStyleBackColor = true;
            this.FileDecryptButton.Click += new System.EventHandler(this.FileDecryptButton_Click);
            // 
            // FileEncryptButton
            // 
            this.FileEncryptButton.Location = new System.Drawing.Point(347, 541);
            this.FileEncryptButton.Name = "FileEncryptButton";
            this.FileEncryptButton.Size = new System.Drawing.Size(75, 24);
            this.FileEncryptButton.TabIndex = 42;
            this.FileEncryptButton.Text = "Zaszyfruj";
            this.FileEncryptButton.UseVisualStyleBackColor = true;
            this.FileEncryptButton.Click += new System.EventHandler(this.FileEncryptButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 739);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.PublicKeyTextbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.EncryptButton);
            this.tabPage1.Controls.Add(this.GenerateKeys);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.PrivateKeyTextbox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DecryptButton);
            this.tabPage1.Controls.Add(this.DecryptedText);
            this.tabPage1.Controls.Add(this.TextToEncrypt);
            this.tabPage1.Controls.Add(this.EncryptedText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tekst";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(841, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 25);
            this.label14.TabIndex = 44;
            this.label14.Text = "Szyfrowanie tekstu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(276, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Generowanie klucza";
            // 
            // PublicKeyTextbox
            // 
            this.PublicKeyTextbox.Location = new System.Drawing.Point(128, 121);
            this.PublicKeyTextbox.Name = "PublicKeyTextbox";
            this.PublicKeyTextbox.Size = new System.Drawing.Size(451, 202);
            this.PublicKeyTextbox.TabIndex = 17;
            this.PublicKeyTextbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tekst do zaszyfrowania";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(890, 211);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(86, 50);
            this.EncryptButton.TabIndex = 14;
            this.EncryptButton.Text = "Zaszyfruj";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // GenerateKeys
            // 
            this.GenerateKeys.Location = new System.Drawing.Point(280, 567);
            this.GenerateKeys.Name = "GenerateKeys";
            this.GenerateKeys.Size = new System.Drawing.Size(135, 50);
            this.GenerateKeys.TabIndex = 16;
            this.GenerateKeys.Text = "Wygeneruj Klucze";
            this.GenerateKeys.UseVisualStyleBackColor = true;
            this.GenerateKeys.Click += new System.EventHandler(this.GenerateKeys_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Klucz publiczny";
            // 
            // PrivateKeyTextbox
            // 
            this.PrivateKeyTextbox.Location = new System.Drawing.Point(125, 345);
            this.PrivateKeyTextbox.Name = "PrivateKeyTextbox";
            this.PrivateKeyTextbox.Size = new System.Drawing.Size(454, 205);
            this.PrivateKeyTextbox.TabIndex = 20;
            this.PrivateKeyTextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Klucz prywatny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Zaszyfrowany tekst";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(890, 363);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(86, 50);
            this.DecryptButton.TabIndex = 25;
            this.DecryptButton.Text = "Odszyfruj";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(764, 419);
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.Size = new System.Drawing.Size(358, 84);
            this.DecryptedText.TabIndex = 26;
            this.DecryptedText.Text = "";
            // 
            // TextToEncrypt
            // 
            this.TextToEncrypt.Location = new System.Drawing.Point(764, 121);
            this.TextToEncrypt.Name = "TextToEncrypt";
            this.TextToEncrypt.Size = new System.Drawing.Size(358, 84);
            this.TextToEncrypt.TabIndex = 28;
            this.TextToEncrypt.Text = "";
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(764, 273);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(358, 84);
            this.EncryptedText.TabIndex = 29;
            this.EncryptedText.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.PublicKeyPath);
            this.tabPage2.Controls.Add(this.FileEncryptButton);
            this.tabPage2.Controls.Add(this.FileDecryptButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.FileToDecryptPath);
            this.tabPage2.Controls.Add(this.PublicKeySelect);
            this.tabPage2.Controls.Add(this.FileToDecryptButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.PrivateKeySelect);
            this.tabPage2.Controls.Add(this.FileToEncryptPath);
            this.tabPage2.Controls.Add(this.PrivateKeyPath);
            this.tabPage2.Controls.Add(this.FileToEncyptButton);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(498, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "Wybieranie klucza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(828, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "Odszyfrowanie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Szyfrowanie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 780);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button PublicKeySelect;
        private System.Windows.Forms.TextBox PublicKeyPath;
        private System.Windows.Forms.TextBox PrivateKeyPath;
        private System.Windows.Forms.Button PrivateKeySelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox FileToEncryptPath;
        private System.Windows.Forms.Button FileToEncyptButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FileToDecryptPath;
        private System.Windows.Forms.Button FileToDecryptButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button FileDecryptButton;
        private System.Windows.Forms.Button FileEncryptButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox PublicKeyTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button GenerateKeys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox PrivateKeyTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.RichTextBox DecryptedText;
        private System.Windows.Forms.RichTextBox TextToEncrypt;
        private System.Windows.Forms.RichTextBox EncryptedText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}

