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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");

        private void btnPersonelKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel(Unvan, Tc, PersonelAdi, PersonelSoyadi, Telefon, Mail)values('" + txtUnvan.Text + "', '" + txtTC.Text + "', '" + txtAd.Text + "', '" + txtSoyad.Text + "', '" + txtTel.Text + "', '" + txtMail.Text + "')", baglanti);
        }
    }
}




