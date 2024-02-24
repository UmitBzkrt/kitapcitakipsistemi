using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using kitapcitakipsistemi.Properties;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class arayuz : Form
    {
        public arayuz()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button2.Text = strings.s01;
            button3.Text = strings.s02;
            button5.Text = strings.s46;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunlisletelem gecis = new urunlisletelem();
            gecis.Show();
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satis gecis = new satis();
            gecis.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void arayuz_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris gecis = new giris();
            gecis.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
