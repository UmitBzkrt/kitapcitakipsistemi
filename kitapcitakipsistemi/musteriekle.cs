using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using kitapcitakipsistemi.Properties;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class musteriekle : Form
    {
        public musteriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=stok_takip;Integrated Security=True");

        private void musteriekle_Load(object sender, EventArgs e)
        {

        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            lbltc.Text = strings.s11;
            lblad.Text = strings.s13;
            lblsoyad.Text = strings.s14;
            lbltelefon.Text = strings.s16;
            lbladres.Text = strings.s17;
            lblmail.Text = strings.s18;
            button1.Text = strings.s08;
            button2.Text = strings.s49;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into musteri(ad,soyad,telefon,adres,email,tc) values(@ad,@soyad,@telefon,@adres,@email,@tc)", baglanti);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@email", txtemail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("müşteri kaydı eklendi");
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            satis gecis = new satis();
            gecis.Show();
            this.Hide();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
