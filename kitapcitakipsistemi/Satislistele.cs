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
using System.Globalization;
using kitapcitakipsistemi.Properties;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class Satislistele : Form
    {
        public Satislistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satıslistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView2.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            btnsil.Text = strings.s10;
           

        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from satis", baglanti);
                lbltoplamkazanc.Text = komut.ExecuteScalar() + " TL \nToplam Kazanç";
                baglanti.Close();
            }
            catch (Exception)
            {

            }
        }

        private void Satislistele_Load(object sender, EventArgs e)
        {
            hesapla();
            satıslistele();
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select urunadi,toplamfiyati from satis", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    chart1.Series["satis"].Points.AddXY(dr[0].ToString(), dr[1]);
                }
                baglanti.Close();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from satis where barkodno='" + dataGridView2.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["satis"].Clear();
            satıslistele();
            MessageBox.Show("kayıt silindi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from satis", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Satış İptal Edildi");
            daset.Tables["satis"].Clear();
            satıslistele();
            hesapla();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
