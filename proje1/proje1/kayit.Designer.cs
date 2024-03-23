
namespace proje1
{
    partial class kayit
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
            this.btnKayitKaydet = new System.Windows.Forms.Button();
            this.lblKayitAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.txtKayitAd = new System.Windows.Forms.TextBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitSifreT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayitKaydet
            // 
            this.btnKayitKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnKayitKaydet.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnKayitKaydet.Location = new System.Drawing.Point(571, 368);
            this.btnKayitKaydet.Name = "btnKayitKaydet";
            this.btnKayitKaydet.Size = new System.Drawing.Size(94, 41);
            this.btnKayitKaydet.TabIndex = 0;
            this.btnKayitKaydet.Text = "Kaydet";
            this.btnKayitKaydet.UseVisualStyleBackColor = false;
            this.btnKayitKaydet.Click += new System.EventHandler(this.btnKayitKaydet_Click);
            // 
            // lblKayitAd
            // 
            this.lblKayitAd.AutoSize = true;
            this.lblKayitAd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKayitAd.Location = new System.Drawing.Point(509, 215);
            this.lblKayitAd.Name = "lblKayitAd";
            this.lblKayitAd.Size = new System.Drawing.Size(87, 23);
            this.lblKayitAd.TabIndex = 1;
            this.lblKayitAd.Text = "Ad Soyad:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.Location = new System.Drawing.Point(548, 262);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(48, 23);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifreTekrar.Location = new System.Drawing.Point(498, 296);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(100, 23);
            this.lblSifreTekrar.TabIndex = 4;
            this.lblSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // txtKayitAd
            // 
            this.txtKayitAd.Location = new System.Drawing.Point(627, 211);
            this.txtKayitAd.Name = "txtKayitAd";
            this.txtKayitAd.Size = new System.Drawing.Size(125, 27);
            this.txtKayitAd.TabIndex = 5;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(625, 251);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(125, 27);
            this.txtKayitSifre.TabIndex = 6;
            // 
            // txtKayitSifreT
            // 
            this.txtKayitSifreT.Location = new System.Drawing.Point(625, 296);
            this.txtKayitSifreT.Name = "txtKayitSifreT";
            this.txtKayitSifreT.Size = new System.Drawing.Size(125, 27);
            this.txtKayitSifreT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "YARDIMCINIZA HOŞ GELDİNİZ";
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.IMG_20220817_WA0007;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKayitSifreT);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.txtKayitAd);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKayitAd);
            this.Controls.Add(this.btnKayitKaydet);
            this.Name = "kayit";
            this.Text = "kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitKaydet;
        private System.Windows.Forms.Label lblKayitAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtKayitAd;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitSifreT;
        private System.Windows.Forms.Label label1;
    }
}