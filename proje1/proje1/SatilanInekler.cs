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
    public partial class SatilanInekler : Form
    {
        public SatilanInekler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");
        private void VerileriGoster()
        {
           // listView1.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Hayvanlar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["inekId"].ToString();
                ekle.SubItems.Add(oku["inekCinsiyeti"].ToString());
                ekle.SubItems.Add(oku["inekCinsi"].ToString());
                ekle.SubItems.Add(oku["DogumYili"].ToString());
                ekle.SubItems.Add(oku["Kilosu"].ToString());
                ekle.SubItems.Add(oku["AlisFiyati"].ToString());
                ekle.SubItems.Add(oku["AlisTarihi"].ToString());
                ekle.SubItems.Add(oku["SatisFiyati"].ToString());
                ekle.SubItems.Add(oku["SatisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnVerileriG_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
    }
}
