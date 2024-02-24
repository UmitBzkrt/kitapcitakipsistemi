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

namespace kitapcitakipsistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-28JM1LE;Initial Catalog=ornek;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into ornektablo(id,ad,soyad) values(@id,@ad,@soyad) ", baglanti);
            komut.Parameters.AddWithValue("@id", txtid);
            komut.Parameters.AddWithValue("@ad", txtad);
            komut.Parameters.AddWithValue("@soyad", txtsoyad);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
