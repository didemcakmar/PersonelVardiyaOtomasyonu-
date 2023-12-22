namespace  PersonelVardiyaOtomasyonu
{

    partial class yonetici
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
           if (disposing && (components != null))
           {
               components.Dispose();
            }
              base.Dispose(disposing);
         }
         #region Windows Form Designer generated code
          private void InitializeComponent()
         {
            this.yoneticiDataTable = new System.Windows.Forms.DataGridView();
            this.yon_ad_soyad = new System.Windows.Forms.Label();
            this.yon_mail = new System.Windows.Forms.Label();
            this.yon_sifre = new System.Windows.Forms.Label();
            this.yon_ad_soyadTextBox = new System.Windows.Forms.TextBox();
            this.yon_mailTextBox = new System.Windows.Forms.TextBox();
            this.yon_sifreTextBox = new System.Windows.Forms.TextBox();
            this.ButtonEkle = new System.Windows.Forms.Button();
            this.ButtonGuncelle = new System.Windows.Forms.Button();
            this.ButtonSil = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // yoneticiDataTable
            // 
            this.yoneticiDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yoneticiDataTable.Location = new System.Drawing.Point(12, 284);
            this.yoneticiDataTable.Name = "yoneticiDataTable";
            this.yoneticiDataTable.RowHeadersWidth = 51;
            this.yoneticiDataTable.RowTemplate.Height = 24;
            this.yoneticiDataTable.Size = new System.Drawing.Size(1043, 249);
            this.yoneticiDataTable.TabIndex = 0;
            this.yoneticiDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yoneticiDataTable_CellContentClick);
            // 
            // yon_ad_soyad
            // 
            this.yon_ad_soyad.AutoSize = true;
            this.yon_ad_soyad.Location = new System.Drawing.Point(25, 90);
            this.yon_ad_soyad.Name = "yon_ad_soyad";
            this.yon_ad_soyad.Size = new System.Drawing.Size(127, 17);
            this.yon_ad_soyad.TabIndex = 1;
            this.yon_ad_soyad.Text = "Yönetici Ad Soyad:";
            // 
            // yon_mail
            // 
            this.yon_mail.AutoSize = true;
            this.yon_mail.Location = new System.Drawing.Point(47, 120);
            this.yon_mail.Name = "yon_mail";
            this.yon_mail.Size = new System.Drawing.Size(105, 17);
            this.yon_mail.TabIndex = 1;
            this.yon_mail.Text = "Yönetici E-mail:";
            // 
            // yon_sifre
            // 
            this.yon_sifre.AutoSize = true;
            this.yon_sifre.Location = new System.Drawing.Point(57, 150);
            this.yon_sifre.Name = "yon_sifre";
            this.yon_sifre.Size = new System.Drawing.Size(95, 17);
            this.yon_sifre.TabIndex = 1;
            this.yon_sifre.Text = "Yönetici Şifre:";
            this.yon_sifre.Click += new System.EventHandler(this.yon_sifre_Click);
            // 
            // yon_ad_soyadTextBox
            // 
            this.yon_ad_soyadTextBox.Location = new System.Drawing.Point(153, 84);
            this.yon_ad_soyadTextBox.Name = "yon_ad_soyadTextBox";
            this.yon_ad_soyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.yon_ad_soyadTextBox.TabIndex = 4;
            // 
            // yon_mailTextBox
            // 
            this.yon_mailTextBox.Location = new System.Drawing.Point(153, 114);
            this.yon_mailTextBox.Name = "yon_mailTextBox";
            this.yon_mailTextBox.Size = new System.Drawing.Size(100, 22);
            this.yon_mailTextBox.TabIndex = 4;
            // 
            // yon_sifreTextBox
            // 
            this.yon_sifreTextBox.Location = new System.Drawing.Point(153, 144);
            this.yon_sifreTextBox.Name = "yon_sifreTextBox";
            this.yon_sifreTextBox.Size = new System.Drawing.Size(100, 22);
            this.yon_sifreTextBox.TabIndex = 4;
            // 
            // ButtonEkle
            // 
            this.ButtonEkle.Location = new System.Drawing.Point(303, 28);
            this.ButtonEkle.Name = "ButtonEkle";
            this.ButtonEkle.Size = new System.Drawing.Size(75, 23);
            this.ButtonEkle.TabIndex = 7;
            this.ButtonEkle.Text = "Ekle";
            this.ButtonEkle.UseVisualStyleBackColor = true;
            this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
            // 
            // ButtonGuncelle
            // 
            this.ButtonGuncelle.Location = new System.Drawing.Point(402, 28);
            this.ButtonGuncelle.Name = "ButtonGuncelle";
            this.ButtonGuncelle.Size = new System.Drawing.Size(75, 23);
            this.ButtonGuncelle.TabIndex = 8;
            this.ButtonGuncelle.Text = "Güncelle";
            this.ButtonGuncelle.UseVisualStyleBackColor = true;
            this.ButtonGuncelle.Click += new System.EventHandler(this.ButtonGuncelle_Click);
            // 
            // ButtonSil
            // 
            this.ButtonSil.Location = new System.Drawing.Point(483, 28);
            this.ButtonSil.Name = "ButtonSil";
            this.ButtonSil.Size = new System.Drawing.Size(75, 23);
            this.ButtonSil.TabIndex = 9;
            this.ButtonSil.Text = "Sil";
            this.ButtonSil.UseVisualStyleBackColor = true;
            this.ButtonSil.Click += new System.EventHandler(this.ButtonSil_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(577, 28);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 10;
            this.ButtonReset.Text = "Sıfırla";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.yon_ad_soyadTextBox);
            this.Controls.Add(this.yon_ad_soyad);
            this.Controls.Add(this.yon_mailTextBox);
            this.Controls.Add(this.yon_mail);
            this.Controls.Add(this.yon_sifreTextBox);
            this.Controls.Add(this.yon_sifre);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSil);
            this.Controls.Add(this.ButtonGuncelle);
            this.Controls.Add(this.ButtonEkle);
            this.Controls.Add(this.yoneticiDataTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yonetici";
            this.Text = "PersonelVardiyaOtomasyonu";
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

         }
       #endregion

       private System.Windows.Forms.DataGridView yoneticiDataTable;
		private System.Windows.Forms.Label yon_ad_soyad;
      private System.Windows.Forms.TextBox yon_ad_soyadTextBox;
		private System.Windows.Forms.Label yon_mail;
      private System.Windows.Forms.TextBox yon_mailTextBox;
		private System.Windows.Forms.Label yon_sifre;
      private System.Windows.Forms.TextBox yon_sifreTextBox;
       private System.Windows.Forms.Button ButtonEkle;
       private System.Windows.Forms.Button ButtonGuncelle;
       private System.Windows.Forms.Button ButtonSil;
       private System.Windows.Forms.Button ButtonReset;
	}
}
