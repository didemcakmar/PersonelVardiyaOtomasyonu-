namespace  PersonelVardiyaOtomasyonu
{

    partial class personel
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
			this.personelDataTable = new System.Windows.Forms.DataGridView();
			this.sicil_no = new System.Windows.Forms.Label();
			this.kadro_tipi = new System.Windows.Forms.Label();
			this.gorev_unvani = new System.Windows.Forms.Label();
			this.ad = new System.Windows.Forms.Label();
			this.soyad = new System.Windows.Forms.Label();
			this.kimlik_no = new System.Windows.Forms.Label();
			this.telefon = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			this.sifre = new System.Windows.Forms.Label();
			this.gorev_unvaniTextBox = new System.Windows.Forms.TextBox();
			this.adTextBox = new System.Windows.Forms.TextBox();
			this.soyadTextBox = new System.Windows.Forms.TextBox();
			this.kimlik_noTextBox = new System.Windows.Forms.TextBox();
			this.telefonTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.sifreTextBox = new System.Windows.Forms.TextBox();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.ButtonGuncelle = new System.Windows.Forms.Button();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.sicil_noTextBox = new System.Windows.Forms.TextBox();
			this.kadro_tipicomboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.personelDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// personelDataTable
			// 
			this.personelDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.personelDataTable.Location = new System.Drawing.Point(12, 251);
			this.personelDataTable.Name = "personelDataTable";
			this.personelDataTable.RowHeadersWidth = 51;
			this.personelDataTable.RowTemplate.Height = 24;
			this.personelDataTable.Size = new System.Drawing.Size(1043, 291);
			this.personelDataTable.TabIndex = 0;
			this.personelDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personelDataTable_CellContentClick);
			// 
			// sicil_no
			// 
			this.sicil_no.AutoSize = true;
			this.sicil_no.Location = new System.Drawing.Point(26, 81);
			this.sicil_no.Name = "sicil_no";
			this.sicil_no.Size = new System.Drawing.Size(52, 16);
			this.sicil_no.TabIndex = 1;
			this.sicil_no.Text = "sicil_no";
			// 
			// kadro_tipi
			// 
			this.kadro_tipi.AutoSize = true;
			this.kadro_tipi.Location = new System.Drawing.Point(19, 206);
			this.kadro_tipi.Name = "kadro_tipi";
			this.kadro_tipi.Size = new System.Drawing.Size(66, 16);
			this.kadro_tipi.TabIndex = 1;
			this.kadro_tipi.Text = "kadro_tipi";
			// 
			// gorev_unvani
			// 
			this.gorev_unvani.AutoSize = true;
			this.gorev_unvani.Location = new System.Drawing.Point(457, 78);
			this.gorev_unvani.Name = "gorev_unvani";
			this.gorev_unvani.Size = new System.Drawing.Size(88, 16);
			this.gorev_unvani.TabIndex = 1;
			this.gorev_unvani.Text = "gorev_unvani";
			// 
			// ad
			// 
			this.ad.AutoSize = true;
			this.ad.Location = new System.Drawing.Point(237, 81);
			this.ad.Name = "ad";
			this.ad.Size = new System.Drawing.Size(23, 16);
			this.ad.TabIndex = 1;
			this.ad.Text = "ad";
			// 
			// soyad
			// 
			this.soyad.AutoSize = true;
			this.soyad.Location = new System.Drawing.Point(237, 117);
			this.soyad.Name = "soyad";
			this.soyad.Size = new System.Drawing.Size(45, 16);
			this.soyad.TabIndex = 1;
			this.soyad.Text = "soyad";
			// 
			// kimlik_no
			// 
			this.kimlik_no.AutoSize = true;
			this.kimlik_no.Location = new System.Drawing.Point(15, 114);
			this.kimlik_no.Name = "kimlik_no";
			this.kimlik_no.Size = new System.Drawing.Size(63, 16);
			this.kimlik_no.TabIndex = 1;
			this.kimlik_no.Text = "kimlik_no";
			// 
			// telefon
			// 
			this.telefon.AutoSize = true;
			this.telefon.Location = new System.Drawing.Point(31, 161);
			this.telefon.Name = "telefon";
			this.telefon.Size = new System.Drawing.Size(47, 16);
			this.telefon.TabIndex = 1;
			this.telefon.Text = "telefon";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(237, 158);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(40, 16);
			this.email.TabIndex = 1;
			this.email.Text = "email";
			// 
			// sifre
			// 
			this.sifre.AutoSize = true;
			this.sifre.Location = new System.Drawing.Point(237, 197);
			this.sifre.Name = "sifre";
			this.sifre.Size = new System.Drawing.Size(32, 16);
			this.sifre.TabIndex = 1;
			this.sifre.Text = "sifre";
			// 
			// gorev_unvaniTextBox
			// 
			this.gorev_unvaniTextBox.Location = new System.Drawing.Point(595, 75);
			this.gorev_unvaniTextBox.Name = "gorev_unvaniTextBox";
			this.gorev_unvaniTextBox.Size = new System.Drawing.Size(121, 22);
			this.gorev_unvaniTextBox.TabIndex = 4;
			// 
			// adTextBox
			// 
			this.adTextBox.Location = new System.Drawing.Point(303, 75);
			this.adTextBox.Name = "adTextBox";
			this.adTextBox.Size = new System.Drawing.Size(121, 22);
			this.adTextBox.TabIndex = 4;
			// 
			// soyadTextBox
			// 
			this.soyadTextBox.Location = new System.Drawing.Point(303, 114);
			this.soyadTextBox.Name = "soyadTextBox";
			this.soyadTextBox.Size = new System.Drawing.Size(121, 22);
			this.soyadTextBox.TabIndex = 4;
			// 
			// kimlik_noTextBox
			// 
			this.kimlik_noTextBox.Location = new System.Drawing.Point(91, 111);
			this.kimlik_noTextBox.Name = "kimlik_noTextBox";
			this.kimlik_noTextBox.Size = new System.Drawing.Size(121, 22);
			this.kimlik_noTextBox.TabIndex = 4;
			// 
			// telefonTextBox
			// 
			this.telefonTextBox.Location = new System.Drawing.Point(91, 155);
			this.telefonTextBox.Name = "telefonTextBox";
			this.telefonTextBox.Size = new System.Drawing.Size(121, 22);
			this.telefonTextBox.TabIndex = 4;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(303, 158);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(121, 22);
			this.emailTextBox.TabIndex = 4;
			// 
			// sifreTextBox
			// 
			this.sifreTextBox.Location = new System.Drawing.Point(303, 200);
			this.sifreTextBox.Name = "sifreTextBox";
			this.sifreTextBox.Size = new System.Drawing.Size(121, 22);
			this.sifreTextBox.TabIndex = 4;
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
			// sicil_noTextBox
			// 
			this.sicil_noTextBox.Location = new System.Drawing.Point(91, 75);
			this.sicil_noTextBox.Name = "sicil_noTextBox";
			this.sicil_noTextBox.Size = new System.Drawing.Size(121, 22);
			this.sicil_noTextBox.TabIndex = 4;
			// 
			// kadro_tipicomboBox
			// 
			this.kadro_tipicomboBox.FormattingEnabled = true;
			this.kadro_tipicomboBox.Items.AddRange(new object[] {
            "İşçi",
            "Memur"});
			this.kadro_tipicomboBox.Location = new System.Drawing.Point(91, 197);
			this.kadro_tipicomboBox.Name = "kadro_tipicomboBox";
			this.kadro_tipicomboBox.Size = new System.Drawing.Size(121, 24);
			this.kadro_tipicomboBox.TabIndex = 11;
			// 
			// personel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.kadro_tipicomboBox);
			this.Controls.Add(this.sicil_noTextBox);
			this.Controls.Add(this.sicil_no);
			this.Controls.Add(this.kadro_tipi);
			this.Controls.Add(this.gorev_unvaniTextBox);
			this.Controls.Add(this.gorev_unvani);
			this.Controls.Add(this.adTextBox);
			this.Controls.Add(this.ad);
			this.Controls.Add(this.soyadTextBox);
			this.Controls.Add(this.soyad);
			this.Controls.Add(this.kimlik_noTextBox);
			this.Controls.Add(this.kimlik_no);
			this.Controls.Add(this.telefonTextBox);
			this.Controls.Add(this.telefon);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.email);
			this.Controls.Add(this.sifreTextBox);
			this.Controls.Add(this.sifre);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonGuncelle);
			this.Controls.Add(this.ButtonEkle);
			this.Controls.Add(this.personelDataTable);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "personel";
			this.Text = "PersonelVardiyaOtomasyonu";
			((System.ComponentModel.ISupportInitialize)(this.personelDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

         }
       #endregion

       private System.Windows.Forms.DataGridView personelDataTable;
		private System.Windows.Forms.Label sicil_no;
		private System.Windows.Forms.Label kadro_tipi;
		private System.Windows.Forms.Label gorev_unvani;
      private System.Windows.Forms.TextBox gorev_unvaniTextBox;
		private System.Windows.Forms.Label ad;
      private System.Windows.Forms.TextBox adTextBox;
		private System.Windows.Forms.Label soyad;
      private System.Windows.Forms.TextBox soyadTextBox;
		private System.Windows.Forms.Label kimlik_no;
      private System.Windows.Forms.TextBox kimlik_noTextBox;
		private System.Windows.Forms.Label telefon;
      private System.Windows.Forms.TextBox telefonTextBox;
		private System.Windows.Forms.Label email;
      private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label sifre;
      private System.Windows.Forms.TextBox sifreTextBox;
       private System.Windows.Forms.Button ButtonEkle;
       private System.Windows.Forms.Button ButtonGuncelle;
       private System.Windows.Forms.Button ButtonSil;
       private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.TextBox sicil_noTextBox;
		private System.Windows.Forms.ComboBox kadro_tipicomboBox;
	}
}
