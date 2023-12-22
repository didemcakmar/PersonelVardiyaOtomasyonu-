namespace PersonelVardiyaOtomasyonu
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
			this.izin_gün_1_comboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.izin_gün_2_comboBox = new System.Windows.Forms.ComboBox();
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
			this.sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sicil_no.ForeColor = System.Drawing.Color.White;
			this.sicil_no.Location = new System.Drawing.Point(109, 94);
			this.sicil_no.Name = "sicil_no";
			this.sicil_no.Size = new System.Drawing.Size(93, 20);
			this.sicil_no.TabIndex = 1;
			this.sicil_no.Text = "Sicil No : ";
			// 
			// kadro_tipi
			// 
			this.kadro_tipi.AutoSize = true;
			this.kadro_tipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kadro_tipi.ForeColor = System.Drawing.Color.White;
			this.kadro_tipi.Location = new System.Drawing.Point(704, 98);
			this.kadro_tipi.Name = "kadro_tipi";
			this.kadro_tipi.Size = new System.Drawing.Size(113, 20);
			this.kadro_tipi.TabIndex = 1;
			this.kadro_tipi.Text = "Kadro Tipi : ";
			// 
			// gorev_unvani
			// 
			this.gorev_unvani.AutoSize = true;
			this.gorev_unvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gorev_unvani.ForeColor = System.Drawing.Color.White;
			this.gorev_unvani.Location = new System.Drawing.Point(677, 138);
			this.gorev_unvani.Name = "gorev_unvani";
			this.gorev_unvani.Size = new System.Drawing.Size(140, 20);
			this.gorev_unvani.TabIndex = 1;
			this.gorev_unvani.Text = "Görev Ünvanı : ";
			// 
			// ad
			// 
			this.ad.AutoSize = true;
			this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ad.ForeColor = System.Drawing.Color.White;
			this.ad.Location = new System.Drawing.Point(153, 132);
			this.ad.Name = "ad";
			this.ad.Size = new System.Drawing.Size(49, 20);
			this.ad.TabIndex = 1;
			this.ad.Text = "Ad : ";
			// 
			// soyad
			// 
			this.soyad.AutoSize = true;
			this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.soyad.ForeColor = System.Drawing.Color.White;
			this.soyad.Location = new System.Drawing.Point(423, 130);
			this.soyad.Name = "soyad";
			this.soyad.Size = new System.Drawing.Size(78, 20);
			this.soyad.TabIndex = 1;
			this.soyad.Text = "Soyad : ";
			// 
			// kimlik_no
			// 
			this.kimlik_no.AutoSize = true;
			this.kimlik_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kimlik_no.ForeColor = System.Drawing.Color.White;
			this.kimlik_no.Location = new System.Drawing.Point(398, 94);
			this.kimlik_no.Name = "kimlik_no";
			this.kimlik_no.Size = new System.Drawing.Size(113, 20);
			this.kimlik_no.TabIndex = 1;
			this.kimlik_no.Text = "Kimlik No :  ";
			// 
			// telefon
			// 
			this.telefon.AutoSize = true;
			this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.telefon.ForeColor = System.Drawing.Color.White;
			this.telefon.Location = new System.Drawing.Point(113, 208);
			this.telefon.Name = "telefon";
			this.telefon.Size = new System.Drawing.Size(89, 20);
			this.telefon.TabIndex = 1;
			this.telefon.Text = "Telefon : ";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.email.ForeColor = System.Drawing.Color.White;
			this.email.Location = new System.Drawing.Point(128, 172);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(74, 20);
			this.email.TabIndex = 1;
			this.email.Text = "Email : ";
			// 
			// sifre
			// 
			this.sifre.AutoSize = true;
			this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sifre.ForeColor = System.Drawing.Color.White;
			this.sifre.Location = new System.Drawing.Point(434, 168);
			this.sifre.Name = "sifre";
			this.sifre.Size = new System.Drawing.Size(67, 20);
			this.sifre.TabIndex = 1;
			this.sifre.Text = "Şifre : ";
			// 
			// gorev_unvaniTextBox
			// 
			this.gorev_unvaniTextBox.Location = new System.Drawing.Point(842, 138);
			this.gorev_unvaniTextBox.Name = "gorev_unvaniTextBox";
			this.gorev_unvaniTextBox.Size = new System.Drawing.Size(121, 22);
			this.gorev_unvaniTextBox.TabIndex = 4;
			// 
			// adTextBox
			// 
			this.adTextBox.Location = new System.Drawing.Point(208, 130);
			this.adTextBox.Name = "adTextBox";
			this.adTextBox.Size = new System.Drawing.Size(121, 22);
			this.adTextBox.TabIndex = 4;
			// 
			// soyadTextBox
			// 
			this.soyadTextBox.Location = new System.Drawing.Point(517, 130);
			this.soyadTextBox.Name = "soyadTextBox";
			this.soyadTextBox.Size = new System.Drawing.Size(121, 22);
			this.soyadTextBox.TabIndex = 4;
			// 
			// kimlik_noTextBox
			// 
			this.kimlik_noTextBox.Location = new System.Drawing.Point(517, 94);
			this.kimlik_noTextBox.Name = "kimlik_noTextBox";
			this.kimlik_noTextBox.Size = new System.Drawing.Size(121, 22);
			this.kimlik_noTextBox.TabIndex = 4;
			// 
			// telefonTextBox
			// 
			this.telefonTextBox.Location = new System.Drawing.Point(208, 206);
			this.telefonTextBox.Name = "telefonTextBox";
			this.telefonTextBox.Size = new System.Drawing.Size(121, 22);
			this.telefonTextBox.TabIndex = 4;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(208, 170);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(121, 22);
			this.emailTextBox.TabIndex = 4;
			// 
			// sifreTextBox
			// 
			this.sifreTextBox.Location = new System.Drawing.Point(517, 170);
			this.sifreTextBox.Name = "sifreTextBox";
			this.sifreTextBox.Size = new System.Drawing.Size(121, 22);
			this.sifreTextBox.TabIndex = 4;
			// 
			// ButtonEkle
			// 
			this.ButtonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ButtonEkle.Cursor = System.Windows.Forms.Cursors.Default;
			this.ButtonEkle.FlatAppearance.BorderSize = 0;
			this.ButtonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonEkle.ForeColor = System.Drawing.Color.White;
			this.ButtonEkle.Location = new System.Drawing.Point(320, 12);
			this.ButtonEkle.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonEkle.Name = "ButtonEkle";
			this.ButtonEkle.Size = new System.Drawing.Size(100, 39);
			this.ButtonEkle.TabIndex = 7;
			this.ButtonEkle.Text = "Ekle";
			this.ButtonEkle.UseVisualStyleBackColor = false;
			this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
			// 
			// ButtonGuncelle
			// 
			this.ButtonGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ButtonGuncelle.FlatAppearance.BorderSize = 0;
			this.ButtonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonGuncelle.ForeColor = System.Drawing.Color.White;
			this.ButtonGuncelle.Location = new System.Drawing.Point(435, 12);
			this.ButtonGuncelle.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGuncelle.Name = "ButtonGuncelle";
			this.ButtonGuncelle.Size = new System.Drawing.Size(100, 39);
			this.ButtonGuncelle.TabIndex = 8;
			this.ButtonGuncelle.Text = "Güncelle";
			this.ButtonGuncelle.UseVisualStyleBackColor = false;
			this.ButtonGuncelle.Click += new System.EventHandler(this.ButtonGuncelle_Click);
			// 
			// ButtonSil
			// 
			this.ButtonSil.BackColor = System.Drawing.Color.Red;
			this.ButtonSil.FlatAppearance.BorderSize = 0;
			this.ButtonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonSil.ForeColor = System.Drawing.Color.White;
			this.ButtonSil.Location = new System.Drawing.Point(541, 12);
			this.ButtonSil.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonSil.Name = "ButtonSil";
			this.ButtonSil.Size = new System.Drawing.Size(100, 39);
			this.ButtonSil.TabIndex = 9;
			this.ButtonSil.Text = "Sil";
			this.ButtonSil.UseVisualStyleBackColor = false;
			this.ButtonSil.Click += new System.EventHandler(this.ButtonSil_Click);
			// 
			// ButtonReset
			// 
			this.ButtonReset.BackColor = System.Drawing.Color.DodgerBlue;
			this.ButtonReset.FlatAppearance.BorderSize = 0;
			this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonReset.ForeColor = System.Drawing.Color.White;
			this.ButtonReset.Location = new System.Drawing.Point(647, 12);
			this.ButtonReset.Name = "ButtonReset";
			this.ButtonReset.Size = new System.Drawing.Size(100, 39);
			this.ButtonReset.TabIndex = 10;
			this.ButtonReset.Text = "Sıfırla";
			this.ButtonReset.UseVisualStyleBackColor = false;
			this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// sicil_noTextBox
			// 
			this.sicil_noTextBox.CausesValidation = false;
			this.sicil_noTextBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.sicil_noTextBox.Location = new System.Drawing.Point(208, 92);
			this.sicil_noTextBox.Name = "sicil_noTextBox";
			this.sicil_noTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.sicil_noTextBox.Size = new System.Drawing.Size(121, 22);
			this.sicil_noTextBox.TabIndex = 4;
			// 
			// kadro_tipicomboBox
			// 
			this.kadro_tipicomboBox.FormattingEnabled = true;
			this.kadro_tipicomboBox.Items.AddRange(new object[] {
			"İşçi",
			"Memur"});
			this.kadro_tipicomboBox.Location = new System.Drawing.Point(842, 92);
			this.kadro_tipicomboBox.Name = "kadro_tipicomboBox";
			this.kadro_tipicomboBox.Size = new System.Drawing.Size(121, 24);
			this.kadro_tipicomboBox.TabIndex = 11;
			// 
			// izin_gün_1_comboBox
			// 
			this.izin_gün_1_comboBox.FormattingEnabled = true;
			this.izin_gün_1_comboBox.Items.AddRange(new object[] {
			"Pazartesi",
			"Salı",
			"Çarşamba",
			"Perşembe",
			"Cuma",
			"Cumartesi",
			"Pazar"});
			this.izin_gün_1_comboBox.Location = new System.Drawing.Point(842, 172);
			this.izin_gün_1_comboBox.Name = "izin_gün_1_comboBox";
			this.izin_gün_1_comboBox.Size = new System.Drawing.Size(121, 24);
			this.izin_gün_1_comboBox.TabIndex = 12;
			this.izin_gün_1_comboBox.SelectedIndexChanged += new System.EventHandler(this.izin_gün_1_comboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(704, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "İzin Gün 1: ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(704, 214);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "İzin Gün 2:  ";
			// 
			// izin_gün_2_comboBox
			// 
			this.izin_gün_2_comboBox.FormattingEnabled = true;
			this.izin_gün_2_comboBox.Items.AddRange(new object[] {
			"Pazartesi",
			"Salı",
			"Çarşamba",
			"Perşembe",
			"Cuma",
			"Cumartesi",
			"Pazar"});
			this.izin_gün_2_comboBox.Location = new System.Drawing.Point(842, 214);
			this.izin_gün_2_comboBox.Name = "izin_gün_2_comboBox";
			this.izin_gün_2_comboBox.Size = new System.Drawing.Size(121, 24);
			this.izin_gün_2_comboBox.TabIndex = 14;
			// 
			// personel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.izin_gün_2_comboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.izin_gün_1_comboBox);
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
			this.MaximizeBox = false;
			this.Name = "personel";
			this.ShowIcon = false;
			this.Text = "Personel";
			this.Load += new System.EventHandler(this.personel_Load);
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
		private System.Windows.Forms.ComboBox izin_gün_1_comboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox izin_gün_2_comboBox;
	}
}
