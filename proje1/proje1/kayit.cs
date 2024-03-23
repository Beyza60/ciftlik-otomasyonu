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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglama = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");
        private void btnKayitKaydet_Click(object sender, EventArgs e)
        {
            baglama.Open();
            SqlCommand komut = new SqlCommand("insert into Kayit(Adi,Sifre)values('"+txtKayitAd.Text+"','"+txtKayitSifre.Text+"')", baglama);
            komut.ExecuteNonQuery();
            baglama.Close();
        }
    }
}
