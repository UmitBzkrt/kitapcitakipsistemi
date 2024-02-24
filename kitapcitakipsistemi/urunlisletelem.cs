using kitapcitakipsistemi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace kitapcitakipsistemi
{
    public partial class urunlisletelem : Form
    {
        public urunlisletelem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=stok_takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void urunlisletelem_Load(object sender, EventArgs e)
        {
            
            urunlistele();
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comkategori.Items.Add(dr[0].ToString());
                }
                
                baglanti.Close();
               

            }
            }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            
            lblbarkodno.Text = strings.s27;
            lblkategori.Text = strings.s28;
            lblurunad.Text = strings.s29;
            lblyayinevi.Text = strings.s30;
            lblmiktari.Text = strings.s31;
            lblsatisfiyati.Text = strings.s32;
            lblisbn.Text = strings.s33;
            lblsayfasayisi.Text = strings.s34;
            lblrafno.Text = strings.s35;
            lblyazar.Text = strings.s36;
            label1.Text = strings.s53;
            button2.Text = strings.s37;
            btnsil.Text = strings.s10;
            btnguncelle.Text = strings.s09;


        }
        private void urunlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isbntxt.Text = dataGridView1.CurrentRow.Cells["isbnno"].Value.ToString();
            barkodtxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            comkategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            urunadtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            sayfasayisitxt.Text= dataGridView1.CurrentRow.Cells["sayfasayisi"].Value.ToString();
            yayinevitxt.Text= dataGridView1.CurrentRow.Cells["yayinevi"].Value.ToString();
            miktartxt.Text= dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            sfiyatitxt.Text= dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
            txtrafno.Text = dataGridView1.CurrentRow.Cells["rafno"].Value.ToString();
            txtyazar.Text = dataGridView1.CurrentRow.Cells["yazar"].Value.ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set isbnno=@isbnno,yazar=@yazar,kategori=@kategori,urunadi=@urunadi,sayfasayisi=@sayfasayisi,yayinevi=@yayinevi,miktari=@miktari,satisfiyati=@satisfiyati,rafno=@rafno where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@isbnno", isbntxt.Text);
            komut.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
            komut.Parameters.AddWithValue("@kategori", comkategori.Text);
            komut.Parameters.AddWithValue("@urunadi", urunadtxt.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",sayfasayisitxt.Text);
            komut.Parameters.AddWithValue("@yayinevi", yayinevitxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(miktartxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(sfiyatitxt.Text));
            komut.Parameters.AddWithValue("@rafno", txtrafno.Text);
            komut.Parameters.AddWithValue("@yazar", txtyazar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            urunlistele();
            MessageBox.Show("güncelleme Yapıldı");


            if (Double.Parse(sfiyatitxt.Text) >= 20)
            {
                DialogResult Soru;

                Soru = MessageBox.Show("Belgeyi kaydetmek istediğinizden emin misiniz ?", "Uyarı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Soru == DialogResult.Yes)
                {
                    giris listele = new giris();
                    listele.Show();
                    
                }
                MessageBox.Show("hata");
            }


            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }




        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            urunlistele();
            MessageBox.Show("kayıt silindi");
        }

        private void txtisbnbarkodnoara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like'%" + barkodnoara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void isbntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunekleme gecis = new urunekleme();
            gecis.Show();
            this.Hide();
        }

        private void comkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comkategori.Text == "")
            {
                isbntxt.Visible = true;
                lblisbn.Visible = true;
                sayfasayisitxt.Visible = true;
                lblsayfasayisi.Visible = true;
                txtrafno.Visible = true;
                lblrafno.Visible = true;
                txtyazar.Visible = true;
                lblyazar.Visible = true;
            }
            else if (comkategori.Text == "kitap")
            {
                isbntxt.Visible = true;
                lblisbn.Visible = true;
                sayfasayisitxt.Visible = true;
                lblsayfasayisi.Visible = true;
                txtrafno.Visible = true;
                lblrafno.Visible = true;
                txtyazar.Visible = true;
                lblyazar.Visible = true;
            }
            else
            {
                isbntxt.Visible = false;
                lblisbn.Visible = false;
                sayfasayisitxt.Visible = false;
                lblsayfasayisi.Visible = false;
                txtrafno.Visible = false;
                lblrafno.Visible = false;
                txtyazar.Visible = false;
                lblyazar.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }

        private void urunlisletelem_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
