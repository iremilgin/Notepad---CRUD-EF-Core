namespace ErdincHocaCozumAss15
{
    partial class PasswordChange
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
            this.btnSifreDegis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSifreDegis
            // 
            this.btnSifreDegis.Location = new System.Drawing.Point(27, 171);
            this.btnSifreDegis.Name = "btnSifreDegis";
            this.btnSifreDegis.Size = new System.Drawing.Size(282, 46);
            this.btnSifreDegis.TabIndex = 13;
            this.btnSifreDegis.Text = "Şifre Değiştir";
            this.btnSifreDegis.UseVisualStyleBackColor = true;
            this.btnSifreDegis.Click += new System.EventHandler(this.btnSifreDegis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yeni Şifre Tekrar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yeni Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Eski Şifre :";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(139, 120);
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(170, 23);
            this.txtYeniSifreTekrar.TabIndex = 9;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(139, 65);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(170, 23);
            this.txtYeniSifre.TabIndex = 8;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(139, 20);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(170, 23);
            this.txtSifre.TabIndex = 7;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 244);
            this.Controls.Add(this.btnSifreDegis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtSifre);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSifreDegis;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private TextBox txtSifre;
    }
}