namespace kitapcitakipsistemi
{
    partial class kullanicieklesil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicieklesil));
            this.lblkad = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.kullanici_bilgiTableAdapter1 = new kitapcitakipsistemi.kullanicigirisDataSetTableAdapters.kullanici_bilgiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtkullanicitipi = new System.Windows.Forms.TextBox();
            this.lblktipi = new System.Windows.Forms.Label();
            this.kadlbl = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.kullanicitipitxt = new System.Windows.Forms.TextBox();
            this.ktipilbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.kullaniciidlbl = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.lblkullaniciid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkad
            // 
            this.lblkad.AutoSize = true;
            this.lblkad.BackColor = System.Drawing.Color.Transparent;
            this.lblkad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkad.Location = new System.Drawing.Point(69, 140);
            this.lblkad.Name = "lblkad";
            this.lblkad.Size = new System.Drawing.Size(107, 24);
            this.lblkad.TabIndex = 0;
            this.lblkad.Text = "Kullanıcı Adı:";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblsifre.Location = new System.Drawing.Point(69, 193);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(48, 24);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(202, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtkullaniciadi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.Location = new System.Drawing.Point(202, 137);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(134, 30);
            this.txtkullaniciadi.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtsifre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(202, 190);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(134, 30);
            this.txtsifre.TabIndex = 4;
            // 
            // kullanici_bilgiTableAdapter1
            // 
            this.kullanici_bilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 216);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(669, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtkullanicitipi
            // 
            this.txtkullanicitipi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtkullanicitipi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanicitipi.Location = new System.Drawing.Point(202, 237);
            this.txtkullanicitipi.Name = "txtkullanicitipi";
            this.txtkullanicitipi.Size = new System.Drawing.Size(134, 30);
            this.txtkullanicitipi.TabIndex = 7;
            // 
            // lblktipi
            // 
            this.lblktipi.AutoSize = true;
            this.lblktipi.BackColor = System.Drawing.Color.Transparent;
            this.lblktipi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblktipi.Location = new System.Drawing.Point(69, 240);
            this.lblktipi.Name = "lblktipi";
            this.lblktipi.Size = new System.Drawing.Size(107, 24);
            this.lblktipi.TabIndex = 8;
            this.lblktipi.Text = "Kullanıcı Tipi:";
            // 
            // kadlbl
            // 
            this.kadlbl.AutoSize = true;
            this.kadlbl.BackColor = System.Drawing.Color.Transparent;
            this.kadlbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadlbl.Location = new System.Drawing.Point(513, 143);
            this.kadlbl.Name = "kadlbl";
            this.kadlbl.Size = new System.Drawing.Size(107, 24);
            this.kadlbl.TabIndex = 0;
            this.kadlbl.Text = "Kullanıcı Adı:";
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.BackColor = System.Drawing.Color.Transparent;
            this.sifrelbl.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.sifrelbl.Location = new System.Drawing.Point(513, 196);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(48, 24);
            this.sifrelbl.TabIndex = 1;
            this.sifrelbl.Text = "Şifre:";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.kullaniciaditxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciaditxt.Location = new System.Drawing.Point(645, 137);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(134, 30);
            this.kullaniciaditxt.TabIndex = 3;
            // 
            // sifretxt
            // 
            this.sifretxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sifretxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretxt.Location = new System.Drawing.Point(645, 190);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(134, 30);
            this.sifretxt.TabIndex = 4;
            // 
            // kullanicitipitxt
            // 
            this.kullanicitipitxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.kullanicitipitxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicitipitxt.Location = new System.Drawing.Point(645, 237);
            this.kullanicitipitxt.Name = "kullanicitipitxt";
            this.kullanicitipitxt.Size = new System.Drawing.Size(134, 30);
            this.kullanicitipitxt.TabIndex = 7;
            // 
            // ktipilbl
            // 
            this.ktipilbl.AutoSize = true;
            this.ktipilbl.BackColor = System.Drawing.Color.Transparent;
            this.ktipilbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ktipilbl.Location = new System.Drawing.Point(513, 243);
            this.ktipilbl.Name = "ktipilbl";
            this.ktipilbl.Size = new System.Drawing.Size(107, 24);
            this.ktipilbl.TabIndex = 8;
            this.ktipilbl.Text = "Kullanıcı Tipi:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(661, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 43);
            this.button4.TabIndex = 10;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kullaniciidlbl
            // 
            this.kullaniciidlbl.AutoSize = true;
            this.kullaniciidlbl.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciidlbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciidlbl.Location = new System.Drawing.Point(513, 94);
            this.kullaniciidlbl.Name = "kullaniciidlbl";
            this.kullaniciidlbl.Size = new System.Drawing.Size(94, 24);
            this.kullaniciidlbl.TabIndex = 0;
            this.kullaniciidlbl.Text = "Kullanıcı id:";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.idtxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idtxt.Location = new System.Drawing.Point(645, 88);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(134, 30);
            this.idtxt.TabIndex = 3;
            // 
            // lblkullaniciid
            // 
            this.lblkullaniciid.AutoSize = true;
            this.lblkullaniciid.BackColor = System.Drawing.Color.Transparent;
            this.lblkullaniciid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullaniciid.Location = new System.Drawing.Point(69, 88);
            this.lblkullaniciid.Name = "lblkullaniciid";
            this.lblkullaniciid.Size = new System.Drawing.Size(94, 24);
            this.lblkullaniciid.TabIndex = 0;
            this.lblkullaniciid.Text = "Kullanıcı id:";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Menu;
            this.txtid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(202, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(134, 30);
            this.txtid.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(71, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "EN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkGray;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 29);
            this.button5.TabIndex = 14;
            this.button5.Text = "TR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // kullanicieklesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 604);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ktipilbl);
            this.Controls.Add(this.lblktipi);
            this.Controls.Add(this.kullanicitipitxt);
            this.Controls.Add(this.txtkullanicitipi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.lblkullaniciid);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.kullaniciidlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kadlbl);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkad);
            this.Name = "kullanicieklesil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanicieklesil";
            this.Load += new System.EventHandler(this.kullanicieklesil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkad;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private kullanicigirisDataSetTableAdapters.kullanici_bilgiTableAdapter kullanici_bilgiTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtkullanicitipi;
        private System.Windows.Forms.Label lblktipi;
        private System.Windows.Forms.Label kadlbl;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox kullaniciaditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.TextBox kullanicitipitxt;
        private System.Windows.Forms.Label ktipilbl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label kullaniciidlbl;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label lblkullaniciid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}