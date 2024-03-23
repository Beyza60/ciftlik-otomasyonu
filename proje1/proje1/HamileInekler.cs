using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace proje1
{
    public partial class HamileInekler : Form
    {
        
        public HamileInekler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HamileInekler(HamileInekCinsi,DogumYili,HamileKalmaZamani)values('"+txtHamileCinsi.Text+"','"+dtpHamileDYili.Value.ToString("yyyy-MM-dd")+"','"+dtpHamileKalmaZ.Value.ToString("yyyy-MM-dd")+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

      
    }
}
