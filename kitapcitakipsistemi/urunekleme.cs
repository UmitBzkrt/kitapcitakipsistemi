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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Globalization;
using kitapcitakipsistemi.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class urunekleme : Form
    {
        public urunekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=stok_takip;Integrated Security=True");
        private void urunekleme_Load(object sender, EventArgs e)
        {
            
            this.kategoriTableAdapter.Fill(this.stok_takipDataSet6.kategori);
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
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kategoricom.Items.Add(dr[0].ToString());
                }
                baglanti.Close();
            }
        }

        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            groupBox1.Text = strings.s51;
            groupBox2.Text = strings.s52;
            lblbarkod.Text = strings.s27;
            lblkategori.Text = strings.s28;
            lblurunad.Text = strings.s29;
            lblyayinevi.Text = strings.s30;
            lblmiktari.Text = strings.s31;
            lblsatisfiyati.Text = strings.s32;
            lblisbnno.Text = strings.s33;
            lblsayfasayisi.Text = strings.s34;
            lblrafno.Text = strings.s35;
            lblyazar.Text = strings.s36;
            barkodnolbl.Text = strings.s27;
            kategorilbl.Text = strings.s28;
            urunadlbl.Text = strings.s29;
            yayinevilbl.Text = strings.s30;
            miktarilbl.Text = strings.s31;
            satisfiyatilbl.Text = strings.s32;
            isbnlbl.Text = strings.s33;
            sayfasayisilbl.Text = strings.s34;
            rafnolbl.Text = strings.s35;
            yazarlbl.Text = strings.s36;
            button1.Text = strings.s08;
            button2.Text = strings.s08;
            button3.Text = strings.s49;


        }
        private void comkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urun(isbnno,yazar,barkodno,kategori,urunadi,sayfasayisi,yayinevi,miktari,satisfiyati,rafno) values(@isbnno,@yazar,@barkodno,@kategori,@urunadi,@sayfasayisi,@yayinevi,@miktari,@satisfiyati,@rafno)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
            komut.Parameters.AddWithValue("@isbnno", txtisbn.Text);
            komut.Parameters.AddWithValue("@kategori", comkategori.Text);
            komut.Parameters.AddWithValue("@urunadi", txturunad.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",txtsayfasayisi.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtyayinevi.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtmiktari.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsfiyati.Text));
            komut.Parameters.AddWithValue("@rafno", txtrafno.Text);
            komut.Parameters.AddWithValue("@yazar", txtyazar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi");
            foreach(Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void isbnbarkodtxt_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(miktartxt.Text) + "'where barkodno='" + barkodtxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunlisletelem gecis = new urunlisletelem();
            gecis.Show();
            this.Hide();

        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {
            if (barkodtxt.Text == "")
            {
                lblmiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + barkodtxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                isbntxt.Text = read["isbnno"].ToString();
                kategoricom.Text = read["kategori"].ToString();
                urunadtxt.Text = read["urunadi"].ToString();
                sayfasayisitxt.Text = read["sayfasayisi"].ToString();
                yayinevitxt.Text = read["yayinevi"].ToString();
                lblmiktar.Text = read["miktari"].ToString();
                sfiyatitxt.Text = read["satisfiyati"].ToString();
                rafnotxt.Text = read["rafno"].ToString();
                yazartxt.Text = read["yazar"].ToString();
            }
            baglanti.Close();
        }

        private void comkategori_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comkategori.Text == "")
            {
                txtisbn.Visible = true;
                lblisbnno.Visible = true;
                txtsayfasayisi.Visible = true;
                lblsayfasayisi.Visible = true;
                txtrafno.Visible = true;
                lblrafno.Visible = true;
                txtyazar.Visible = true;
                lblyazar.Visible = true;
            }
            else if(comkategori.Text == "kitap")
            {
                txtisbn.Visible = true;
                lblisbnno.Visible = true;
                txtsayfasayisi.Visible = true;
                lblsayfasayisi.Visible = true;
                txtrafno.Visible = true;
                lblrafno.Visible = true;
                txtyazar.Visible = true;
                lblyazar.Visible = true;
            }
            else
            {
                txtisbn.Visible = false;
                lblisbnno.Visible = false;
                txtsayfasayisi.Visible = false;
                lblsayfasayisi.Visible = false;
                txtrafno.Visible = false;
                lblrafno.Visible = false;
                txtyazar.Visible = false;
                lblyazar.Visible = false;
            }
        }

        private void kategoricom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kategoricom.Text == "")
            {
                isbntxt.Visible = true;
                isbnlbl.Visible = true;
                sayfasayisitxt.Visible = true;
                sayfasayisilbl.Visible = true;
                rafnotxt.Visible = true;
                rafnolbl.Visible = true;
                yazartxt.Visible = true;
                yazarlbl.Visible = true;
            }
            else if (kategoricom.Text == "kitap")
            {
                isbntxt.Visible = true;
                isbnlbl.Visible = true;
                sayfasayisitxt.Visible = true;
                sayfasayisilbl.Visible = true;
                rafnotxt.Visible = true;
                rafnolbl.Visible = true;
                yazartxt.Visible = true;
                yazarlbl.Visible = true;
            }
            else
            {
                isbntxt.Visible = false;
                isbnlbl.Visible = false;
                sayfasayisitxt.Visible =false;
                sayfasayisilbl.Visible =false;
                rafnotxt.Visible = false;
                rafnolbl.Visible = false;
                yazartxt.Visible = false;
                yazarlbl.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diller("en");
        }
    }
    }
    

