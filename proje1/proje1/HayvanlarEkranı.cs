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
    public partial class HayvanlarEkranı : Form
    {
        public HayvanlarEkranı()
        {
            InitializeComponent();
        }
        SqlConnection baglama = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");

        private void btnInekKayıt_Click(object sender, EventArgs e)
        {
            baglama.Open();
            SqlCommand komut = new SqlCommand("insert into Hayvanlar(inekCinsiyeti,inekCinsi,DogumYili,Kilosu,AlisFiyati,AlisTarihi,SatisFiyati,SatisTarihi)values('"+txtCinsiyet.Text+"','"+txtCins.Text+"','"+dtpDogumYili.Value.ToString("yyyy-MM-dd")+"','"+txtKilo.Text+"','"+txtAlisFiyat.Text+"','"+dtpAlisTarihi.Value.ToString("yyyy-MM-dd")+"','"+txtSatisFiyati.Text+"','"+dtpSatisTarihi.Value.ToString("yyyy-MM-dd")+"')",baglama);
            komut.ExecuteNonQuery();
            baglama.Close();
        }
    }
}
