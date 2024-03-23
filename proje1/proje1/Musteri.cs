using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proje1
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");
        private void btnMusteriKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteri(Adi,Soyadi,AlinanUrun,AlinanMiktar,AlisFiyati,AlisTarihi)values('"+txtMusteriAd.Text+"','"+txtMusteriSoyad.Text+"','"+txtMusteriAlınanU.Text+"','"+txtMusteriAlınanM.Text+"','"+txtMusteriAlisF.Text+"','"+dtpMusteriAlisT.Value.ToString("yyyy-MM-dd")+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
