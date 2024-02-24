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
using kitapcitakipsistemi.Properties;
using System.Globalization;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class arsiv : Form
    {
        public arsiv()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = strings.s48;
            button2.Text = strings.s49;
            

        }
        private void arsivlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arsivsatis", baglanti);
            adtr.Fill(daset, "arsivsatis");
            dataGridView1.DataSource = daset.Tables["arsivsatis"];
            baglanti.Close();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from arsivsatis", baglanti);
                lblkazanc.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

            }
        }
            private void arsiv_Load(object sender, EventArgs e)
        {
            arsivlistele();
            hesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satis gecis = new satis();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
