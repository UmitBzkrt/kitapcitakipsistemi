using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using kitapcitakipsistemi.Properties;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class giris : Form

    {
        
        
        
        public giris()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            kad.Text = strings.s04;
            button1.Text = strings.s47;

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=kullanicigiris;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string user = kad.Text;
            string password = sifre.Text;
            string ktipi;


            con.Open();
            SqlCommand com = new SqlCommand("Select  kullanicitipi from kullanici where kullanici_adı='" + kad.Text + "' and sifre='" + sifre.Text + "'",con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                ktipi = dr[0].ToString();
                if (ktipi == "admin")
                {
                    arayuzadmin gecis = new arayuzadmin();
                    gecis.Show();
                    this.Hide();
                }
                else if (ktipi == "kullanici")
                {
                    arayuz gecis = new arayuz();
                    gecis.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("hatalı kullanici adi veya sifre");
            }
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }

        private void giris_Load_1(object sender, EventArgs e)
        {

        }
    }
}
