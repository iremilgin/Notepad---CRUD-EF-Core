namespace ErdincHocaCozumAss15
{
    partial class AdminScreen
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
            this.btnAktifPasif = new System.Windows.Forms.Button();
            this.lvKullanicilar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnAktifPasif
            // 
            this.btnAktifPasif.Location = new System.Drawing.Point(383, 15);
            this.btnAktifPasif.Name = "btnAktifPasif";
            this.btnAktifPasif.Size = new System.Drawing.Size(136, 44);
            this.btnAktifPasif.TabIndex = 3;
            this.btnAktifPasif.Text = "Aktif / Pasif";
            this.btnAktifPasif.UseVisualStyleBackColor = true;
            this.btnAktifPasif.Click += new System.EventHandler(this.btnAktifPasif_Click);
            // 
            // lvKullanicilar
            // 
            this.lvKullanicilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvKullanicilar.Location = new System.Drawing.Point(0, 87);
            this.lvKullanicilar.Name = "lvKullanicilar";
            this.lvKullanicilar.Size = new System.Drawing.Size(568, 356);
            this.lvKullanicilar.TabIndex = 2;
            this.lvKullanicilar.UseCompatibleStateImageBehavior = false;
            this.lvKullanicilar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kullanıcı Adı";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durum";
            this.columnHeader4.Width = 125;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 443);
            this.Controls.Add(this.btnAktifPasif);
            this.Controls.Add(this.lvKullanicilar);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAktifPasif;
        private ListView lvKullanicilar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}