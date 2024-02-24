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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Globalization;
using kitapcitakipsistemi.Properties;
using System.Threading;

namespace kitapcitakipsistemi
{
    public partial class kullanicieklesil : Form
    {
        public kullanicieklesil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=kullanicigiris;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into kullanici(id,kullanici_adı,sifre,kullanicitipi) values(@id,@kullanici_adı,@sifre,@kullanicitipi)", baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@kullanici_adı", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@kullanicitipi",txtkullanicitipi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kullanıcı kaydı eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
           lblkullaniciid.Text = strings.s05;
            lblkad.Text = strings.s04;
            lblsifre.Text = strings.s06;
            lblktipi.Text = strings.s07;
            kullaniciidlbl.Text = strings.s05;
            kadlbl.Text = strings.s04;
            sifrelbl.Text = strings.s06;
            ktipilbl.Text = strings.s07;
            button1.Text = strings.s08;
            button2.Text = strings.s10;
            button4.Text = strings.s09;

        }
        
        private void kullanicieklesil_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici", baglanti);
            adtr.Fill(daset, "kullanici");
            dataGridView1.DataSource = daset.Tables["kullanici"];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kullanici where kullanici_adı='" + dataGridView1.CurrentRow.Cells["kullanici_adı"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanici"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanici", baglanti);
            adtr.Fill(daset, "kullanici");
            dataGridView1.DataSource = daset.Tables["kullanici"];
            baglanti.Close();
            MessageBox.Show("kayıt silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kullanici set kullanici_adı=@kullanici_adı,sifre=@sifre,kullanicitipi=@kullanicitipi where id=@id", baglanti);
            komut.Parameters.AddWithValue("@kullanicitipi", kullanicitipitxt.Text);
            komut.Parameters.AddWithValue("@kullanici_adı", kullaniciaditxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifretxt.Text);
            komut.Parameters.AddWithValue("@id",int.Parse(idtxt.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanici"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kullanici", baglanti);
            adtr.Fill(daset, "kullanici");
            dataGridView1.DataSource = daset.Tables["kullanici"];
            baglanti.Close();
            MessageBox.Show("kullanıcı kaydı güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            kullanicitipitxt.Text = dataGridView1.CurrentRow.Cells["kullanicitipi"].Value.ToString();
            kullaniciaditxt.Text = dataGridView1.CurrentRow.Cells["kullanici_adı"].Value.ToString();
            sifretxt.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            idtxt.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            diller("");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            diller("en");
        }
    }
}
