using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }
        private void btnForm1YeniKayıt_Click(object sender, EventArgs e)
        {
            kayit kyt = new kayit();
            kyt.Show();
            this.Hide();//önceki  formu gizleme 
           
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-L50H8U33;Initial Catalog=CiftlikYardimcim;Integrated Security=True");

        private void btnAnaGiris_Click(object sender, EventArgs e)
        {
            try
            {
              baglanti.Open();
                string sql = "select*from Kayit where Adi =@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi",txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi",txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    anaMenu fr = new anaMenu();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş.");
            }
        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
