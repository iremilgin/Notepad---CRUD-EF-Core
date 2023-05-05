namespace ErdincHocaCozumAss15
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(43, 289);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(220, 36);
            this.btnKayitOl.TabIndex = 21;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Şifre Tekrar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad :";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(144, 235);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(119, 23);
            this.txtSifreTekrar.TabIndex = 15;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(144, 184);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(119, 23);
            this.txtSifre.TabIndex = 14;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(144, 127);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(119, 23);
            this.txtKullaniciAdi.TabIndex = 13;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(144, 79);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(119, 23);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(144, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(119, 23);
            this.txtAd.TabIndex = 11;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 352);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKayitOl;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}