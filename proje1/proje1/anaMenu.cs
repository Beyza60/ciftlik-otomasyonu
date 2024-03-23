using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proje1
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void btnMenuMusteri_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
           
        }

        private void btnMenuPersonel_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Show();
            this.Hide();
        }

        private void btnMenuSUrun_Click(object sender, EventArgs e)
        {
            SatılanUrunler satılanU = new SatılanUrunler();
            satılanU.Show();
            this.Hide();
        }

        private void btnMenuYem_Click(object sender, EventArgs e)
        {
            Yemler yem = new Yemler();
            yem.Show();
            this.Hide();
        }

        private void btnMenuHayvan_Click(object sender, EventArgs e)
        {
            HayvanlarEkranı hayvan = new HayvanlarEkranı();
            hayvan.Show();
            this.Hide();
        }

        private void btnHamileInekler_Click(object sender, EventArgs e)
        {
            HamileInekler hamile = new HamileInekler();
            hamile.Show();
            this.Hide();
        }

        private void btnSatilanInekler_Click(object sender, EventArgs e)
        {
            SatilanInekler satilan = new SatilanInekler();
            satilan.Show();
            this.Hide();
        }
    }
}
