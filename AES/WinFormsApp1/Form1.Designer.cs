namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DF_iv_input = new System.Windows.Forms.TextBox();
            this.DF_decrypted_file_path_input = new System.Windows.Forms.TextBox();
            this.DF_file_path_to_decrypt_input = new System.Windows.Forms.TextBox();
            this.DF_submit = new System.Windows.Forms.Button();
            this.DF_browse_decrypted_file_destination_btn = new System.Windows.Forms.Button();
            this.DF_browse_file_to_decrypt_btn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EF_submit = new System.Windows.Forms.Button();
            this.EF_browse_encrypted_file_destination_btn = new System.Windows.Forms.Button();
            this.EF_browse_file_to_encrypt_btn = new System.Windows.Forms.Button();
            this.EF_iv_input = new System.Windows.Forms.TextBox();
            this.EF_partner_public_key_input = new System.Windows.Forms.TextBox();
            this.EF_my_public_key_input = new System.Windows.Forms.TextBox();
            this.EF_encrypted_file_path_input = new System.Windows.Forms.TextBox();
            this.EF_file_to_encrypt_path_input = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_odszyfruj = new System.Windows.Forms.Button();
            this.txt_IVdrugiejdeszyfr = new System.Windows.Forms.TextBox();
            this.txt_dodeszyfracji = new System.Windows.Forms.TextBox();
            this.txt_odszyfrowany = new System.Windows.Forms.TextBox();
            this.txt_IV = new System.Windows.Forms.TextBox();
            this.txt_klpubdrugiej = new System.Windows.Forms.TextBox();
            this.txt_zaszyfrowany = new System.Windows.Forms.TextBox();
            this.txt_wlasnyklpub = new System.Windows.Forms.TextBox();
            this.txt_dozaszfrowania = new System.Windows.Forms.TextBox();
            this.btn_zaszyfruj = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DF_iv_input
            // 
            this.DF_iv_input.Location = new System.Drawing.Point(17, 540);
            this.DF_iv_input.Multiline = true;
            this.DF_iv_input.Name = "DF_iv_input";
            this.DF_iv_input.Size = new System.Drawing.Size(547, 35);
            this.DF_iv_input.TabIndex = 13;
            // 
            // DF_decrypted_file_path_input
            // 
            this.DF_decrypted_file_path_input.Location = new System.Drawing.Point(910, 37);
            this.DF_decrypted_file_path_input.Multiline = true;
            this.DF_decrypted_file_path_input.Name = "DF_decrypted_file_path_input";
            this.DF_decrypted_file_path_input.Size = new System.Drawing.Size(250, 30);
            this.DF_decrypted_file_path_input.TabIndex = 10;
            // 
            // DF_file_path_to_decrypt_input
            // 
            this.DF_file_path_to_decrypt_input.Location = new System.Drawing.Point(607, 37);
            this.DF_file_path_to_decrypt_input.Multiline = true;
            this.DF_file_path_to_decrypt_input.Name = "DF_file_path_to_decrypt_input";
            this.DF_file_path_to_decrypt_input.Size = new System.Drawing.Size(249, 30);
            this.DF_file_path_to_decrypt_input.TabIndex = 9;
            // 
            // DF_submit
            // 
            this.DF_submit.Location = new System.Drawing.Point(817, 102);
            this.DF_submit.Name = "DF_submit";
            this.DF_submit.Size = new System.Drawing.Size(132, 40);
            this.DF_submit.TabIndex = 8;
            this.DF_submit.Text = "Odszyfruj";
            this.DF_submit.UseVisualStyleBackColor = true;
            this.DF_submit.Click += new System.EventHandler(this.DF_submit_Click);
            // 
            // DF_browse_decrypted_file_destination_btn
            // 
            this.DF_browse_decrypted_file_destination_btn.Location = new System.Drawing.Point(1004, 73);
            this.DF_browse_decrypted_file_destination_btn.Name = "DF_browse_decrypted_file_destination_btn";
            this.DF_browse_decrypted_file_destination_btn.Size = new System.Drawing.Size(75, 23);
            this.DF_browse_decrypted_file_destination_btn.TabIndex = 6;
            this.DF_browse_decrypted_file_destination_btn.Text = "Wybierz";
            this.DF_browse_decrypted_file_destination_btn.UseVisualStyleBackColor = true;
            this.DF_browse_decrypted_file_destination_btn.Click += new System.EventHandler(this.DF_browse_decrypted_file_destination_btn_Click);
            // 
            // DF_browse_file_to_decrypt_btn
            // 
            this.DF_browse_file_to_decrypt_btn.Location = new System.Drawing.Point(696, 73);
            this.DF_browse_file_to_decrypt_btn.Name = "DF_browse_file_to_decrypt_btn";
            this.DF_browse_file_to_decrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.DF_browse_file_to_decrypt_btn.TabIndex = 5;
            this.DF_browse_file_to_decrypt_btn.Text = "Wybierz";
            this.DF_browse_file_to_decrypt_btn.UseVisualStyleBackColor = true;
            this.DF_browse_file_to_decrypt_btn.Click += new System.EventHandler(this.DF_browse_file_to_decrypt_btn_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 516);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "IV innej osoby";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(910, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Lokalizacja do zapisu pliku";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(607, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Plik";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DF_submit);
            this.tabPage3.Controls.Add(this.DF_iv_input);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.DF_decrypted_file_path_input);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.EF_submit);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.DF_browse_file_to_decrypt_btn);
            this.tabPage3.Controls.Add(this.DF_browse_decrypted_file_destination_btn);
            this.tabPage3.Controls.Add(this.EF_browse_encrypted_file_destination_btn);
            this.tabPage3.Controls.Add(this.DF_file_path_to_decrypt_input);
            this.tabPage3.Controls.Add(this.EF_browse_file_to_encrypt_btn);
            this.tabPage3.Controls.Add(this.EF_iv_input);
            this.tabPage3.Controls.Add(this.EF_partner_public_key_input);
            this.tabPage3.Controls.Add(this.EF_my_public_key_input);
            this.tabPage3.Controls.Add(this.EF_encrypted_file_path_input);
            this.tabPage3.Controls.Add(this.EF_file_to_encrypt_path_input);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1173, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pliki";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EF_submit
            // 
            this.EF_submit.Location = new System.Drawing.Point(221, 102);
            this.EF_submit.Name = "EF_submit";
            this.EF_submit.Size = new System.Drawing.Size(132, 40);
            this.EF_submit.TabIndex = 14;
            this.EF_submit.Text = "Zaszyfruj";
            this.EF_submit.UseVisualStyleBackColor = true;
            this.EF_submit.Click += new System.EventHandler(this.EF_submit_Click);
            // 
            // EF_browse_encrypted_file_destination_btn
            // 
            this.EF_browse_encrypted_file_destination_btn.Location = new System.Drawing.Point(393, 70);
            this.EF_browse_encrypted_file_destination_btn.Name = "EF_browse_encrypted_file_destination_btn";
            this.EF_browse_encrypted_file_destination_btn.Size = new System.Drawing.Size(75, 23);
            this.EF_browse_encrypted_file_destination_btn.TabIndex = 11;
            this.EF_browse_encrypted_file_destination_btn.Text = "Wybierz";
            this.EF_browse_encrypted_file_destination_btn.UseVisualStyleBackColor = true;
            this.EF_browse_encrypted_file_destination_btn.Click += new System.EventHandler(this.EF_browse_encrypted_file_destination_btn_Click);
            // 
            // EF_browse_file_to_encrypt_btn
            // 
            this.EF_browse_file_to_encrypt_btn.Location = new System.Drawing.Point(97, 70);
            this.EF_browse_file_to_encrypt_btn.Name = "EF_browse_file_to_encrypt_btn";
            this.EF_browse_file_to_encrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.EF_browse_file_to_encrypt_btn.TabIndex = 10;
            this.EF_browse_file_to_encrypt_btn.Text = "Wybierz";
            this.EF_browse_file_to_encrypt_btn.UseVisualStyleBackColor = true;
            this.EF_browse_file_to_encrypt_btn.Click += new System.EventHandler(this.EF_browse_file_to_encrypt_btn_Click);
            // 
            // EF_iv_input
            // 
            this.EF_iv_input.Location = new System.Drawing.Point(17, 471);
            this.EF_iv_input.Multiline = true;
            this.EF_iv_input.Name = "EF_iv_input";
            this.EF_iv_input.Size = new System.Drawing.Size(547, 35);
            this.EF_iv_input.TabIndex = 9;
            // 
            // EF_partner_public_key_input
            // 
            this.EF_partner_public_key_input.Location = new System.Drawing.Point(17, 315);
            this.EF_partner_public_key_input.Multiline = true;
            this.EF_partner_public_key_input.Name = "EF_partner_public_key_input";
            this.EF_partner_public_key_input.Size = new System.Drawing.Size(547, 114);
            this.EF_partner_public_key_input.TabIndex = 8;
            // 
            // EF_my_public_key_input
            // 
            this.EF_my_public_key_input.Location = new System.Drawing.Point(17, 177);
            this.EF_my_public_key_input.Multiline = true;
            this.EF_my_public_key_input.Name = "EF_my_public_key_input";
            this.EF_my_public_key_input.Size = new System.Drawing.Size(547, 114);
            this.EF_my_public_key_input.TabIndex = 7;
            // 
            // EF_encrypted_file_path_input
            // 
            this.EF_encrypted_file_path_input.Location = new System.Drawing.Point(313, 37);
            this.EF_encrypted_file_path_input.Multiline = true;
            this.EF_encrypted_file_path_input.Name = "EF_encrypted_file_path_input";
            this.EF_encrypted_file_path_input.Size = new System.Drawing.Size(251, 30);
            this.EF_encrypted_file_path_input.TabIndex = 6;
            // 
            // EF_file_to_encrypt_path_input
            // 
            this.EF_file_to_encrypt_path_input.Location = new System.Drawing.Point(17, 37);
            this.EF_file_to_encrypt_path_input.Multiline = true;
            this.EF_file_to_encrypt_path_input.Name = "EF_file_to_encrypt_path_input";
            this.EF_file_to_encrypt_path_input.Size = new System.Drawing.Size(251, 30);
            this.EF_file_to_encrypt_path_input.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 453);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "IV:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Klucz publiczny innej osoby";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Klucz publiczny";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lokalizacja do zapisu pliku";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Plik";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_odszyfruj);
            this.tabPage1.Controls.Add(this.txt_IVdrugiejdeszyfr);
            this.tabPage1.Controls.Add(this.txt_dodeszyfracji);
            this.tabPage1.Controls.Add(this.txt_odszyfrowany);
            this.tabPage1.Controls.Add(this.txt_IV);
            this.tabPage1.Controls.Add(this.txt_klpubdrugiej);
            this.tabPage1.Controls.Add(this.txt_zaszyfrowany);
            this.tabPage1.Controls.Add(this.txt_wlasnyklpub);
            this.tabPage1.Controls.Add(this.txt_dozaszfrowania);
            this.tabPage1.Controls.Add(this.btn_zaszyfruj);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1173, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tekst";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(798, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "IV innej osoby";
            // 
            // btn_odszyfruj
            // 
            this.btn_odszyfruj.Location = new System.Drawing.Point(426, 407);
            this.btn_odszyfruj.Name = "btn_odszyfruj";
            this.btn_odszyfruj.Size = new System.Drawing.Size(275, 69);
            this.btn_odszyfruj.TabIndex = 7;
            this.btn_odszyfruj.Text = "Odszyfruj";
            this.btn_odszyfruj.UseVisualStyleBackColor = true;
            this.btn_odszyfruj.Click += new System.EventHandler(this.btn_odszyfruj_Click_1);
            // 
            // txt_IVdrugiejdeszyfr
            // 
            this.txt_IVdrugiejdeszyfr.Location = new System.Drawing.Point(797, 469);
            this.txt_IVdrugiejdeszyfr.Multiline = true;
            this.txt_IVdrugiejdeszyfr.Name = "txt_IVdrugiejdeszyfr";
            this.txt_IVdrugiejdeszyfr.Size = new System.Drawing.Size(342, 89);
            this.txt_IVdrugiejdeszyfr.TabIndex = 4;
            // 
            // txt_dodeszyfracji
            // 
            this.txt_dodeszyfracji.Location = new System.Drawing.Point(40, 343);
            this.txt_dodeszyfracji.Multiline = true;
            this.txt_dodeszyfracji.Name = "txt_dodeszyfracji";
            this.txt_dodeszyfracji.Size = new System.Drawing.Size(342, 74);
            this.txt_dodeszyfracji.TabIndex = 0;
            // 
            // txt_odszyfrowany
            // 
            this.txt_odszyfrowany.Location = new System.Drawing.Point(40, 464);
            this.txt_odszyfrowany.Multiline = true;
            this.txt_odszyfrowany.Name = "txt_odszyfrowany";
            this.txt_odszyfrowany.Size = new System.Drawing.Size(342, 87);
            this.txt_odszyfrowany.TabIndex = 1;
            // 
            // txt_IV
            // 
            this.txt_IV.Location = new System.Drawing.Point(798, 317);
            this.txt_IV.Multiline = true;
            this.txt_IV.Name = "txt_IV";
            this.txt_IV.Size = new System.Drawing.Size(341, 70);
            this.txt_IV.TabIndex = 4;
            // 
            // txt_klpubdrugiej
            // 
            this.txt_klpubdrugiej.Location = new System.Drawing.Point(796, 186);
            this.txt_klpubdrugiej.Multiline = true;
            this.txt_klpubdrugiej.Name = "txt_klpubdrugiej";
            this.txt_klpubdrugiej.Size = new System.Drawing.Size(343, 80);
            this.txt_klpubdrugiej.TabIndex = 3;
            // 
            // txt_zaszyfrowany
            // 
            this.txt_zaszyfrowany.Location = new System.Drawing.Point(40, 186);
            this.txt_zaszyfrowany.Multiline = true;
            this.txt_zaszyfrowany.Name = "txt_zaszyfrowany";
            this.txt_zaszyfrowany.Size = new System.Drawing.Size(343, 80);
            this.txt_zaszyfrowany.TabIndex = 2;
            // 
            // txt_wlasnyklpub
            // 
            this.txt_wlasnyklpub.Location = new System.Drawing.Point(796, 66);
            this.txt_wlasnyklpub.Multiline = true;
            this.txt_wlasnyklpub.Name = "txt_wlasnyklpub";
            this.txt_wlasnyklpub.Size = new System.Drawing.Size(343, 74);
            this.txt_wlasnyklpub.TabIndex = 1;
            // 
            // txt_dozaszfrowania
            // 
            this.txt_dozaszfrowania.Location = new System.Drawing.Point(40, 66);
            this.txt_dozaszfrowania.Multiline = true;
            this.txt_dozaszfrowania.Name = "txt_dozaszfrowania";
            this.txt_dozaszfrowania.Size = new System.Drawing.Size(343, 74);
            this.txt_dozaszfrowania.TabIndex = 0;
            // 
            // btn_zaszyfruj
            // 
            this.btn_zaszyfruj.Location = new System.Drawing.Point(426, 131);
            this.btn_zaszyfruj.Name = "btn_zaszyfruj";
            this.btn_zaszyfruj.Size = new System.Drawing.Size(275, 70);
            this.btn_zaszyfruj.TabIndex = 13;
            this.btn_zaszyfruj.Text = "Zaszyfruj";
            this.btn_zaszyfruj.UseVisualStyleBackColor = true;
            this.btn_zaszyfruj.Click += new System.EventHandler(this.btn_zaszyfruj_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tekst odszyfrowany";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tekst zaszyfrowany";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(798, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "IV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Klucz publiczny innej osoby";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tekst zaszyfrowany";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Klucz publiczny";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tekst";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "AES";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage4;
        private TextBox DF_iv_input;
        private TextBox DF_decrypted_file_path_input;
        private TextBox DF_file_path_to_decrypt_input;
        private Button DF_submit;
        private Button DF_browse_decrypted_file_destination_btn;
        private Button DF_browse_file_to_decrypt_btn;
        private Label label20;
        private Label label19;
        private Label label17;
        private Label label16;
        private TabPage tabPage3;
        private Button EF_submit;
        private Button EF_browse_encrypted_file_destination_btn;
        private Button EF_browse_file_to_encrypt_btn;
        private TextBox EF_iv_input;
        private TextBox EF_partner_public_key_input;
        private TextBox EF_my_public_key_input;
        private TextBox EF_encrypted_file_path_input;
        private TextBox EF_file_to_encrypt_path_input;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TabPage tabPage1;
        private Label label10;
        private Button btn_odszyfruj;
        private TextBox txt_IVdrugiejdeszyfr;
        private TextBox txt_dodeszyfracji;
        private TextBox txt_odszyfrowany;
        private TextBox txt_IV;
        private TextBox txt_klpubdrugiej;
        private TextBox txt_zaszyfrowany;
        private TextBox txt_wlasnyklpub;
        private TextBox txt_dozaszfrowania;
        private Button btn_zaszyfruj;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private Button DF_PartnerKP_wklej;
        private TextBox DF_partner_public_key_input;
        private TextBox DF_my_public_key_input;
        private Button DF_copy_my_public_key_btn;
        private Label label18;
    }
}