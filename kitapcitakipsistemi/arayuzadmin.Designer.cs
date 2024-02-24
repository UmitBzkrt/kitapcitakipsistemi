namespace kitapcitakipsistemi
{
    partial class arayuzadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arayuzadmin));
            this.btnkullanici = new System.Windows.Forms.Button();
            this.btnurunbilgi = new System.Windows.Forms.Button();
            this.btnsatisbilgi = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkullanici
            // 
            this.btnkullanici.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnkullanici.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkullanici.Location = new System.Drawing.Point(336, 209);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(288, 110);
            this.btnkullanici.TabIndex = 1;
            this.btnkullanici.Text = "Kullanıcı Ekle-Sil";
            this.btnkullanici.UseVisualStyleBackColor = false;
            this.btnkullanici.Click += new System.EventHandler(this.btnkullanici_Click);
            // 
            // btnurunbilgi
            // 
            this.btnurunbilgi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnurunbilgi.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnurunbilgi.Location = new System.Drawing.Point(172, 45);
            this.btnurunbilgi.Name = "btnurunbilgi";
            this.btnurunbilgi.Size = new System.Drawing.Size(288, 112);
            this.btnurunbilgi.TabIndex = 2;
            this.btnurunbilgi.Text = "Ürün Bilgileri";
            this.btnurunbilgi.UseVisualStyleBackColor = false;
            this.btnurunbilgi.Click += new System.EventHandler(this.btnurunbilgi_Click);
            // 
            // btnsatisbilgi
            // 
            this.btnsatisbilgi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnsatisbilgi.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatisbilgi.Location = new System.Drawing.Point(3, 209);
            this.btnsatisbilgi.Name = "btnsatisbilgi";
            this.btnsatisbilgi.Size = new System.Drawing.Size(292, 110);
            this.btnsatisbilgi.TabIndex = 4;
            this.btnsatisbilgi.Text = "Satış Bilgileri";
            this.btnsatisbilgi.UseVisualStyleBackColor = false;
            this.btnsatisbilgi.Click += new System.EventHandler(this.btnsatisbilgi_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(12, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "Çıkış";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(62, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "EN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "TR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arayuzadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnsatisbilgi);
            this.Controls.Add(this.btnurunbilgi);
            this.Controls.Add(this.btnkullanici);
            this.Name = "arayuzadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arayuzadmin";
            this.Load += new System.EventHandler(this.arayuzadmin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnkullanici;
        private System.Windows.Forms.Button btnurunbilgi;
        private System.Windows.Forms.Button btnsatisbilgi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}