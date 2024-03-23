using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proje1
{
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
        }
        int saniye = 60;
        int dakika = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dakika = Convert.ToInt32(textBox1.Text);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;
            label2.Text = saniye.ToString();
            label4.Text = (dakika - 1).ToString();
            if (saniye==0)
            {
                dakika = dakika - 1;
                label4.Text = dakika.ToString();
                saniye = 60;
            }
        }

      
    }
}
