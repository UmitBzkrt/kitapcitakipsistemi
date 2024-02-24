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
using System.Threading;
using kitapcitakipsistemi.Properties;
using System.Data.SqlClient;

namespace kitapcitakipsistemi
{
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            button2.Text = strings.s21;
            button1.Text = strings.s22;
            button3.Text = strings.s23;
            btnsatisiptal.Text = strings.s22;
            btnsil.Text = strings.s10;
            btnsatisiptal.Text = strings.s24;
            btnekle.Text = strings.s08;
            btnsatisyap.Text = strings.s25;
            groupBox1.Text = strings.s39;
            groupBox2.Text = strings.s40;
            lbltc.Text = strings.s11;
            lblad.Text = strings.s13;
            lblsoyad.Text = strings.s14;
            lblbarkodno.Text = strings.s27;
            lblurunadi.Text = strings.s29;
            lblmiktari.Text = strings.s31;
            lblsatisfiyati.Text = strings.s42;
            lbltoplamfiyat.Text = strings.s43;
            lblgeneltoplam.Text = strings.s41;
            button4.Text = strings.s45;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", baglanti);
                lbltfiyat.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            musteriekle gecis = new musteriekle();
            gecis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musterilistele gecis = new musterilistele();
            gecis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Satislistele gecis = new Satislistele();
            gecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arsiv gecis = new arsiv();
            gecis.Show();
        }

        private void satis_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkodno.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtmiktari)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtbarkodno.Text + "' ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {

                txturunad.Text = rd["urunadi"].ToString();
                txtsfiyati.Text = rd["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            if (txttc.Text == "")
            {
                txtad.Text = "";
                txtsoyad.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteri where tc like '" + txttc.Text + "' ", baglanti);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                txtad.Text = rd["ad"].ToString();
                txtsoyad.Text = rd["soyad"].ToString();
            }
            baglanti.Close();
        }
        bool durum;

        private void barkokontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet ", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                if (txtbarkodno.Text == rdr["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            barkokontrol();
            if (durum == true)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,ad,soyad,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@ad,@soyad,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@ad", txtad.Text);
                komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@urunadi", txturunad.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtmiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsfiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txttfiyati.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+'" + int.Parse(txtmiktari.Text) + "'where barkodno='" + txtbarkodno.Text + "'and tc='" + txttc.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=satisfiyati*miktari where barkodno='" + txtbarkodno.Text + "'", baglanti);
                komut3.ExecuteNonQuery();


                baglanti.Close();


            }

            txtmiktari.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtmiktari)
                    {
                        item.Text = "";
                    }
                }

            }

        }

        private void txtmiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttfiyati.Text = (double.Parse(txtmiktari.Text) * double.Parse(txtsfiyati.Text)).ToString();

            }
            catch (Exception)
            {
                ;
            }
        }

        private void txtsfiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttfiyati.Text = (double.Parse(txtmiktari.Text) * double.Parse(txtsfiyati.Text)).ToString();

            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatisiptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Satış İptal Edildi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,ad,soyad,barkodno,isbnno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@ad,@soyad,@barkodno,@isbnno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txttc.Text);
                komut.Parameters.AddWithValue("@ad", txtad.Text);
                komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@isbnno", dataGridView1.Rows[i].Cells["isbnno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", dataGridView1.Rows[i].Cells["miktari"].Value.ToString());
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + dataGridView1.Rows[i].Cells["miktari"].Value.ToString() + "'where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            diller("en");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblgeneltoplam_Click(object sender, EventArgs e)
        {

        }

        private void satis_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
