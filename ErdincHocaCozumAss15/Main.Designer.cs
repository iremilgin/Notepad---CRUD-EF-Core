namespace ErdincHocaCozumAss15
{
    partial class Main
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llblSifreDegis = new System.Windows.Forms.LinkLabel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnNotSil = new System.Windows.Forms.Button();
            this.btnYeniNot = new System.Windows.Forms.Button();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lboxNotlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(162, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "İçerik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Başlık";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Notlarım";
            // 
            // llblSifreDegis
            // 
            this.llblSifreDegis.AutoSize = true;
            this.llblSifreDegis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llblSifreDegis.Location = new System.Drawing.Point(20, 381);
            this.llblSifreDegis.Name = "llblSifreDegis";
            this.llblSifreDegis.Size = new System.Drawing.Size(100, 21);
            this.llblSifreDegis.TabIndex = 16;
            this.llblSifreDegis.TabStop = true;
            this.llblSifreDegis.Text = "Şifre Değiştir";
            this.llblSifreDegis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSifreDegis_LinkClicked);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(424, 381);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 37);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnNotSil
            // 
            this.btnNotSil.Location = new System.Drawing.Point(292, 381);
            this.btnNotSil.Name = "btnNotSil";
            this.btnNotSil.Size = new System.Drawing.Size(86, 37);
            this.btnNotSil.TabIndex = 14;
            this.btnNotSil.Text = "Not Sil";
            this.btnNotSil.UseVisualStyleBackColor = true;
            this.btnNotSil.Click += new System.EventHandler(this.btnNotSil_Click);
            // 
            // btnYeniNot
            // 
            this.btnYeniNot.Location = new System.Drawing.Point(162, 381);
            this.btnYeniNot.Name = "btnYeniNot";
            this.btnYeniNot.Size = new System.Drawing.Size(89, 37);
            this.btnYeniNot.TabIndex = 13;
            this.btnYeniNot.Text = "Yeni Not";
            this.btnYeniNot.UseVisualStyleBackColor = true;
            this.btnYeniNot.Click += new System.EventHandler(this.btnYeniNot_Click);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(162, 102);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(356, 263);
            this.txtIcerik.TabIndex = 12;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(162, 47);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(356, 23);
            this.txtBaslik.TabIndex = 11;
            // 
            // lboxNotlar
            // 
            this.lboxNotlar.FormattingEnabled = true;
            this.lboxNotlar.ItemHeight = 15;
            this.lboxNotlar.Location = new System.Drawing.Point(20, 46);
            this.lboxNotlar.Name = "lboxNotlar";
            this.lboxNotlar.Size = new System.Drawing.Size(120, 319);
            this.lboxNotlar.TabIndex = 10;
            this.lboxNotlar.SelectedIndexChanged += new System.EventHandler(this.lboxNotlar_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llblSifreDegis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnNotSil);
            this.Controls.Add(this.btnYeniNot);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lboxNotlar);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel llblSifreDegis;
        private Button btnKaydet;
        private Button btnNotSil;
        private Button btnYeniNot;
        private TextBox txtIcerik;
        private TextBox txtBaslik;
        private ListBox lboxNotlar;
    }
}