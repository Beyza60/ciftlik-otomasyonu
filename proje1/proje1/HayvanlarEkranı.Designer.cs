
namespace proje1
{
    partial class HayvanlarEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblDogumYili = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblAlisTarihi = new System.Windows.Forms.Label();
            this.lblSatisTarihi = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.btnInekKayıt = new System.Windows.Forms.Button();
            this.dtpAlisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumYili = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "İneklerimizin Özellikleri";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.White;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCinsiyet.Location = new System.Drawing.Point(499, 113);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(74, 23);
            this.lblCinsiyet.TabIndex = 1;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlisFiyati.Location = new System.Drawing.Point(491, 249);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(81, 23);
            this.lblAlisFiyati.TabIndex = 2;
            this.lblAlisFiyati.Text = "AlışFiyatı:";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKilo.Location = new System.Drawing.Point(499, 214);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(73, 23);
            this.lblKilo.TabIndex = 3;
            this.lblKilo.Text = "Kilo(kg):";
            // 
            // lblDogumYili
            // 
            this.lblDogumYili.AutoSize = true;
            this.lblDogumYili.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDogumYili.Location = new System.Drawing.Point(480, 179);
            this.lblDogumYili.Name = "lblDogumYili";
            this.lblDogumYili.Size = new System.Drawing.Size(93, 23);
            this.lblDogumYili.TabIndex = 4;
            this.lblDogumYili.Text = "DoğumYılı:";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCins.Location = new System.Drawing.Point(527, 146);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(46, 23);
            this.lblCins.TabIndex = 5;
            this.lblCins.Text = "Cins:";
            // 
            // lblAlisTarihi
            // 
            this.lblAlisTarihi.AutoSize = true;
            this.lblAlisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlisTarihi.Location = new System.Drawing.Point(491, 285);
            this.lblAlisTarihi.Name = "lblAlisTarihi";
            this.lblAlisTarihi.Size = new System.Drawing.Size(80, 23);
            this.lblAlisTarihi.TabIndex = 6;
            this.lblAlisTarihi.Text = "AlışTarihi:";
            // 
            // lblSatisTarihi
            // 
            this.lblSatisTarihi.AutoSize = true;
            this.lblSatisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSatisTarihi.Location = new System.Drawing.Point(482, 359);
            this.lblSatisTarihi.Name = "lblSatisTarihi";
            this.lblSatisTarihi.Size = new System.Drawing.Size(89, 23);
            this.lblSatisTarihi.TabIndex = 7;
            this.lblSatisTarihi.Text = "SatışTarihi:";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSatisFiyati.Location = new System.Drawing.Point(481, 322);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(90, 23);
            this.lblSatisFiyati.TabIndex = 8;
            this.lblSatisFiyati.Text = "SatışFiyatı:";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Location = new System.Drawing.Point(586, 109);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(125, 27);
            this.txtCinsiyet.TabIndex = 9;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(586, 210);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(125, 27);
            this.txtKilo.TabIndex = 11;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(586, 245);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(125, 27);
            this.txtAlisFiyat.TabIndex = 12;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(586, 322);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(125, 27);
            this.txtSatisFiyati.TabIndex = 14;
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(586, 142);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(125, 27);
            this.txtCins.TabIndex = 16;
            // 
            // btnInekKayıt
            // 
            this.btnInekKayıt.BackColor = System.Drawing.Color.Khaki;
            this.btnInekKayıt.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnInekKayıt.Location = new System.Drawing.Point(602, 392);
            this.btnInekKayıt.Name = "btnInekKayıt";
            this.btnInekKayıt.Size = new System.Drawing.Size(94, 42);
            this.btnInekKayıt.TabIndex = 17;
            this.btnInekKayıt.Text = "Kaydet";
            this.btnInekKayıt.UseVisualStyleBackColor = false;
            this.btnInekKayıt.Click += new System.EventHandler(this.btnInekKayıt_Click);
            // 
            // dtpAlisTarihi
            // 
            this.dtpAlisTarihi.Location = new System.Drawing.Point(586, 285);
            this.dtpAlisTarihi.Name = "dtpAlisTarihi";
            this.dtpAlisTarihi.Size = new System.Drawing.Size(178, 27);
            this.dtpAlisTarihi.TabIndex = 18;
            // 
            // dtpSatisTarihi
            // 
            this.dtpSatisTarihi.Location = new System.Drawing.Point(586, 356);
            this.dtpSatisTarihi.Name = "dtpSatisTarihi";
            this.dtpSatisTarihi.Size = new System.Drawing.Size(178, 27);
            this.dtpSatisTarihi.TabIndex = 19;
            // 
            // dtpDogumYili
            // 
            this.dtpDogumYili.Location = new System.Drawing.Point(586, 176);
            this.dtpDogumYili.Name = "dtpDogumYili";
            this.dtpDogumYili.Size = new System.Drawing.Size(178, 27);
            this.dtpDogumYili.TabIndex = 20;
            // 
            // HayvanlarEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje1.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dtpDogumYili);
            this.Controls.Add(this.dtpSatisTarihi);
            this.Controls.Add(this.dtpAlisTarihi);
            this.Controls.Add(this.btnInekKayıt);
            this.Controls.Add(this.txtCins);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblSatisTarihi);
            this.Controls.Add(this.lblAlisTarihi);
            this.Controls.Add(this.lblCins);
            this.Controls.Add(this.lblDogumYili);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.label1);
            this.Name = "HayvanlarEkranı";
            this.Text = "HayvanlarEkranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblDogumYili;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblAlisTarihi;
        private System.Windows.Forms.Label lblSatisTarihi;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.Button btnInekKayıt;
        private System.Windows.Forms.DateTimePicker dtpAlisTarihi;
        private System.Windows.Forms.DateTimePicker dtpSatisTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumYili;
    }
}