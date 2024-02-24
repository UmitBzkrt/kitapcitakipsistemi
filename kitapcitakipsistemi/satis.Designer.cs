namespace kitapcitakipsistemi
{
    partial class satis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltoplamfiyat = new System.Windows.Forms.Label();
            this.lblsatisfiyati = new System.Windows.Forms.Label();
            this.lblmiktari = new System.Windows.Forms.Label();
            this.lblurunadi = new System.Windows.Forms.Label();
            this.lblbarkodno = new System.Windows.Forms.Label();
            this.txttfiyati = new System.Windows.Forms.TextBox();
            this.txtsfiyati = new System.Windows.Forms.TextBox();
            this.txtmiktari = new System.Windows.Forms.TextBox();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.btnsatisiptal = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            this.lbltfiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 528);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblsoyad);
            this.groupBox1.Controls.Add(this.lblad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Location = new System.Drawing.Point(37, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(10, 119);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(50, 16);
            this.lblsoyad.TabIndex = 1;
            this.lblsoyad.Text = "Soyad:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(10, 76);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(27, 16);
            this.lblad.TabIndex = 1;
            this.lblad.Text = "Ad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(10, 34);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(28, 16);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "TC:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(156, 116);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtsoyad.TabIndex = 0;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(156, 73);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 0;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(156, 31);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(100, 22);
            this.txttc.TabIndex = 0;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbltoplamfiyat);
            this.groupBox2.Controls.Add(this.lblsatisfiyati);
            this.groupBox2.Controls.Add(this.lblmiktari);
            this.groupBox2.Controls.Add(this.lblurunadi);
            this.groupBox2.Controls.Add(this.lblbarkodno);
            this.groupBox2.Controls.Add(this.txttfiyati);
            this.groupBox2.Controls.Add(this.txtsfiyati);
            this.groupBox2.Controls.Add(this.txtmiktari);
            this.groupBox2.Controls.Add(this.txturunad);
            this.groupBox2.Controls.Add(this.txtbarkodno);
            this.groupBox2.Location = new System.Drawing.Point(37, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // lbltoplamfiyat
            // 
            this.lbltoplamfiyat.AutoSize = true;
            this.lbltoplamfiyat.Location = new System.Drawing.Point(10, 228);
            this.lbltoplamfiyat.Name = "lbltoplamfiyat";
            this.lbltoplamfiyat.Size = new System.Drawing.Size(89, 16);
            this.lbltoplamfiyat.TabIndex = 1;
            this.lbltoplamfiyat.Text = "Toplam Fiyatı";
            // 
            // lblsatisfiyati
            // 
            this.lblsatisfiyati.AutoSize = true;
            this.lblsatisfiyati.Location = new System.Drawing.Point(10, 185);
            this.lblsatisfiyati.Name = "lblsatisfiyati";
            this.lblsatisfiyati.Size = new System.Drawing.Size(75, 16);
            this.lblsatisfiyati.TabIndex = 1;
            this.lblsatisfiyati.Text = "Satış Fiyatı:";
            // 
            // lblmiktari
            // 
            this.lblmiktari.AutoSize = true;
            this.lblmiktari.Location = new System.Drawing.Point(10, 137);
            this.lblmiktari.Name = "lblmiktari";
            this.lblmiktari.Size = new System.Drawing.Size(45, 16);
            this.lblmiktari.TabIndex = 1;
            this.lblmiktari.Text = "Miltarı:";
            // 
            // lblurunadi
            // 
            this.lblurunadi.AutoSize = true;
            this.lblurunadi.Location = new System.Drawing.Point(10, 94);
            this.lblurunadi.Name = "lblurunadi";
            this.lblurunadi.Size = new System.Drawing.Size(61, 16);
            this.lblurunadi.TabIndex = 1;
            this.lblurunadi.Text = "Ürün Adı:";
            // 
            // lblbarkodno
            // 
            this.lblbarkodno.AutoSize = true;
            this.lblbarkodno.Location = new System.Drawing.Point(10, 47);
            this.lblbarkodno.Name = "lblbarkodno";
            this.lblbarkodno.Size = new System.Drawing.Size(75, 16);
            this.lblbarkodno.TabIndex = 1;
            this.lblbarkodno.Text = "Barkod No:";
            // 
            // txttfiyati
            // 
            this.txttfiyati.Location = new System.Drawing.Point(156, 225);
            this.txttfiyati.Name = "txttfiyati";
            this.txttfiyati.Size = new System.Drawing.Size(100, 22);
            this.txttfiyati.TabIndex = 0;
            // 
            // txtsfiyati
            // 
            this.txtsfiyati.Location = new System.Drawing.Point(156, 182);
            this.txtsfiyati.Name = "txtsfiyati";
            this.txtsfiyati.Size = new System.Drawing.Size(100, 22);
            this.txtsfiyati.TabIndex = 0;
            this.txtsfiyati.TextChanged += new System.EventHandler(this.txtsfiyati_TextChanged);
            // 
            // txtmiktari
            // 
            this.txtmiktari.Location = new System.Drawing.Point(156, 134);
            this.txtmiktari.Name = "txtmiktari";
            this.txtmiktari.Size = new System.Drawing.Size(100, 22);
            this.txtmiktari.TabIndex = 0;
            this.txtmiktari.Text = "1";
            this.txtmiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmiktari.TextChanged += new System.EventHandler(this.txtmiktari_TextChanged);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(156, 91);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(100, 22);
            this.txturunad.TabIndex = 0;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(156, 44);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(100, 22);
            this.txtbarkodno.TabIndex = 0;
            this.txtbarkodno.TextChanged += new System.EventHandler(this.txtbarkodno_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(71, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 64);
            this.button2.TabIndex = 25;
            this.button2.Text = "Müşteri Ekleme";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(272, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 64);
            this.button1.TabIndex = 26;
            this.button1.Text = "Müşteri Listeleme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(479, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 64);
            this.button3.TabIndex = 27;
            this.button3.Text = "Satiş Listeleme";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(693, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 64);
            this.button4.TabIndex = 28;
            this.button4.Text = "Arşiv";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.BackColor = System.Drawing.Color.DarkGray;
            this.btnsatisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsatisyap.Location = new System.Drawing.Point(1124, 674);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(114, 54);
            this.btnsatisyap.TabIndex = 29;
            this.btnsatisyap.Text = "Satış Yap";
            this.btnsatisyap.UseVisualStyleBackColor = false;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // btnsatisiptal
            // 
            this.btnsatisiptal.BackColor = System.Drawing.Color.DarkGray;
            this.btnsatisiptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsatisiptal.Location = new System.Drawing.Point(1124, 79);
            this.btnsatisiptal.Name = "btnsatisiptal";
            this.btnsatisiptal.Size = new System.Drawing.Size(103, 55);
            this.btnsatisiptal.TabIndex = 30;
            this.btnsatisiptal.Text = "Satış İptal";
            this.btnsatisiptal.UseVisualStyleBackColor = false;
            this.btnsatisiptal.Click += new System.EventHandler(this.btnsatisiptal_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DarkGray;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Location = new System.Drawing.Point(993, 79);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(102, 55);
            this.btnsil.TabIndex = 31;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DarkGray;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Location = new System.Drawing.Point(373, 674);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(113, 54);
            this.btnekle.TabIndex = 32;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(71, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 29);
            this.button8.TabIndex = 34;
            this.button8.Text = "EN";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGray;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(12, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 29);
            this.button9.TabIndex = 33;
            this.button9.Text = "TR";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.BackColor = System.Drawing.Color.Transparent;
            this.lblgeneltoplam.Location = new System.Drawing.Point(795, 711);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(96, 16);
            this.lblgeneltoplam.TabIndex = 35;
            this.lblgeneltoplam.Text = "Genel Toplam:";
            this.lblgeneltoplam.Click += new System.EventHandler(this.lblgeneltoplam_Click);
            // 
            // lbltfiyat
            // 
            this.lbltfiyat.AutoSize = true;
            this.lbltfiyat.Location = new System.Drawing.Point(951, 711);
            this.lbltfiyat.Name = "lbltfiyat";
            this.lbltfiyat.Size = new System.Drawing.Size(0, 16);
            this.lbltfiyat.TabIndex = 35;
            // 
            // satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 783);
            this.Controls.Add(this.lbltfiyat);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnsatisiptal);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "satis";
            this.Load += new System.EventHandler(this.satis_Load);
            this.DoubleClick += new System.EventHandler(this.satis_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label lbltoplamfiyat;
        private System.Windows.Forms.Label lblsatisfiyati;
        private System.Windows.Forms.Label lblmiktari;
        private System.Windows.Forms.Label lblurunadi;
        private System.Windows.Forms.Label lblbarkodno;
        private System.Windows.Forms.TextBox txttfiyati;
        private System.Windows.Forms.TextBox txtsfiyati;
        private System.Windows.Forms.TextBox txtmiktari;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.Button btnsatisiptal;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblgeneltoplam;
        private System.Windows.Forms.Label lbltfiyat;
    }
}