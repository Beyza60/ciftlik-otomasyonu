
namespace proje1
{
    partial class GirisEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnAnaGiris = new System.Windows.Forms.Button();
            this.btnForm1YeniKayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çiftlikteki yardımcıma  hoş geldiniz";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(413, 306);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(137, 28);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(605, 310);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(125, 27);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.Location = new System.Drawing.Point(489, 350);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(61, 28);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(605, 350);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(125, 27);
            this.txtSifre.TabIndex = 4;
            // 
            // btnAnaGiris
            // 
            this.btnAnaGiris.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAnaGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnaGiris.Location = new System.Drawing.Point(605, 396);
            this.btnAnaGiris.Name = "btnAnaGiris";
            this.btnAnaGiris.Size = new System.Drawing.Size(94, 42);
            this.btnAnaGiris.TabIndex = 5;
            this.btnAnaGiris.Text = "Giriş";
            this.btnAnaGiris.UseVisualStyleBackColor = false;
            this.btnAnaGiris.Click += new System.EventHandler(this.btnAnaGiris_Click);
            // 
            // btnForm1YeniKayıt
            // 
            this.btnForm1YeniKayıt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnForm1YeniKayıt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnForm1YeniKayıt.Location = new System.Drawing.Point(455, 396);
            this.btnForm1YeniKayıt.Name = "btnForm1YeniKayıt";
            this.btnForm1YeniKayıt.Size = new System.Drawing.Size(122, 41);
            this.btnForm1YeniKayıt.TabIndex = 6;
            this.btnForm1YeniKayıt.Text = "Yeni Kayıt";
            this.btnForm1YeniKayıt.UseVisualStyleBackColor = false;
            this.btnForm1YeniKayıt.Click += new System.EventHandler(this.btnForm1YeniKayıt_Click);
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::proje1.Properties.Resources.ciftlik1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm1YeniKayıt);
            this.Controls.Add(this.btnAnaGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkranı";
            this.Text = "Giris Ekranı";
            this.Load += new System.EventHandler(this.GirisEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnAnaGiris;
        private System.Windows.Forms.Button btnForm1YeniKayıt;
    }
}

