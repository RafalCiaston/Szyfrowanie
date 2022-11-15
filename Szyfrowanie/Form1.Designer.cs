
namespace RSA
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
            this.lblClickThis = new System.Windows.Forms.Button();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTxtToEncrypt = new System.Windows.Forms.Label();
            this.lblEncText = new System.Windows.Forms.Label();
            this.lblDecText = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClickThis2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClickThis
            // 
            this.lblClickThis.Location = new System.Drawing.Point(41, 90);
            this.lblClickThis.Margin = new System.Windows.Forms.Padding(2);
            this.lblClickThis.Name = "lblClickThis";
            this.lblClickThis.Size = new System.Drawing.Size(112, 24);
            this.lblClickThis.TabIndex = 0;
            this.lblClickThis.Text = "Szyfruj tekst";
            this.lblClickThis.UseVisualStyleBackColor = true;
            this.lblClickThis.Click += new System.EventHandler(this.lblClickThis_Click);
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(73, 411);
            this.lblPublicKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(80, 13);
            this.lblPublicKey.TabIndex = 1;
            this.lblPublicKey.Text = "Klucz publiczny";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(78, 646);
            this.lblPrivateKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(78, 13);
            this.lblPrivateKey.TabIndex = 2;
            this.lblPrivateKey.Text = "Klucz prywatny";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 154);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 170);
            this.textBox1.TabIndex = 3;
            // 
            // lblTxtToEncrypt
            // 
            this.lblTxtToEncrypt.AutoSize = true;
            this.lblTxtToEncrypt.Location = new System.Drawing.Point(38, 157);
            this.lblTxtToEncrypt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTxtToEncrypt.Name = "lblTxtToEncrypt";
            this.lblTxtToEncrypt.Size = new System.Drawing.Size(118, 13);
            this.lblTxtToEncrypt.TabIndex = 4;
            this.lblTxtToEncrypt.Text = "Tekst do zaszyfrowania";
            // 
            // lblEncText
            // 
            this.lblEncText.AutoSize = true;
            this.lblEncText.Location = new System.Drawing.Point(879, 154);
            this.lblEncText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncText.Name = "lblEncText";
            this.lblEncText.Size = new System.Drawing.Size(98, 13);
            this.lblEncText.TabIndex = 5;
            this.lblEncText.Text = "Zaszyfrowany tekst";
            // 
            // lblDecText
            // 
            this.lblDecText.AutoSize = true;
            this.lblDecText.Location = new System.Drawing.Point(878, 408);
            this.lblDecText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecText.Name = "lblDecText";
            this.lblDecText.Size = new System.Drawing.Size(99, 13);
            this.lblDecText.TabIndex = 6;
            this.lblDecText.Text = "Odszyfrowany tekst";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1832, 974);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.lblPrivateKey);
            this.tabPage1.Controls.Add(this.lblDecText);
            this.tabPage1.Controls.Add(this.lblClickThis);
            this.tabPage1.Controls.Add(this.lblEncText);
            this.tabPage1.Controls.Add(this.lblPublicKey);
            this.tabPage1.Controls.Add(this.lblTxtToEncrypt);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1824, 948);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Szyfrowanie tekstu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(180, 646);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(455, 214);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 405);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(455, 201);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(981, 405);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(455, 207);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(981, 154);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(455, 201);
            this.textBox2.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblClickThis2);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1824, 948);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generowanie kluczy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(738, 488);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(455, 214);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(738, 247);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(455, 201);
            this.textBox7.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Klucz prywatny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Klucz publiczny";
            // 
            // lblClickThis2
            // 
            this.lblClickThis2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.lblClickThis2.Location = new System.Drawing.Point(893, 144);
            this.lblClickThis2.Margin = new System.Windows.Forms.Padding(2);
            this.lblClickThis2.Name = "lblClickThis2";
            this.lblClickThis2.Size = new System.Drawing.Size(112, 24);
            this.lblClickThis2.TabIndex = 15;
            this.lblClickThis2.Text = "Generuj klucz";
            this.lblClickThis2.UseVisualStyleBackColor = true;
            this.lblClickThis2.Click += new System.EventHandler(this.lblClickThis2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(726, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Szyfrowanie tesktu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(788, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "Generowanie kluczy";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 998);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblClickThis;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTxtToEncrypt;
        private System.Windows.Forms.Label lblEncText;
        private System.Windows.Forms.Label lblDecText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button lblClickThis2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

