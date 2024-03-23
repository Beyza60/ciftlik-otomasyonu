using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace proje1
{
    public partial class SatılanUrunler : Form
    {
        public SatılanUrunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SatilanUrunler(satilanUrun, UrunMiktari,SatisFiyati,Kesim/SagimTarihi,SatisTarihi) values('" + cmbSatilanUurun.Text + "','" + txtSatilanUrunMiktari.Text + "','" + txtSatisFiyati.Text + "','" + dtpKesimStarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpSatisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
