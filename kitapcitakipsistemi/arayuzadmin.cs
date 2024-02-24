using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using kitapcitakipsistemi.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;

namespace kitapcitakipsistemi
{
    public partial class arayuzadmin : Form
    {
        
        public arayuzadmin()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            btnurunbilgi.Text = strings.s01;
            btnsatisbilgi.Text = strings.s02;
            btnkullanici.Text = strings.s03;
            button6.Text = strings.s46;
            
        }

        private void btnstoktakip_Click(object sender, EventArgs e)
        {
         
        }

        private void btnurunbilgi_Click(object sender, EventArgs e)
        {

            urunlisletelem gecis = new urunlisletelem();
            gecis.Show();
            
        }

        private void btnsatisbilgi_Click(object sender, EventArgs e)
        {

            satis gecis = new satis();
            gecis.Show();
            
        }

        private void btnrafbilgi_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris gecis = new giris();
            gecis.Show();
            this.Hide();
            
        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            kullanicieklesil gecis = new kullanicieklesil();
            gecis.Show();

        }

        private void arayuzadmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
