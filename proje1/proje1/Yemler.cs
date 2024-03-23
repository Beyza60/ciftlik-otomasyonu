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
    public partial class Yemler : Form
    {
        public Yemler()
        {
            InitializeComponent();
        }
        SqlConnection baglama = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");
        private void btnYemKaydet_Click(object sender, EventArgs e)
        {
            baglama.Open();
            SqlCommand komut2 = new SqlCommand("insert into Yemler(yemTipi,yemMiktari,yemAdedi,Fiyat,AlisTarihi) values('"+txtYemTip.Text+"','"+txtYemMiktar.Text+"','"+txtYemAdet.Text+"','"+txtYemFiyat.Text+"','"+dtpYemAlisTarihi.Value.ToString("yyyy-MM-dd")+"')",baglama);
            komut2.ExecuteNonQuery();
            baglama.Close();
        }
    }
}
