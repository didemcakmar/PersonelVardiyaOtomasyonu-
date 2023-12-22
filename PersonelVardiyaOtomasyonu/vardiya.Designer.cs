namespace PersonelVardiyaOtomasyonu
{

	partial class vardiya
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
			this.vardiyaDataTable = new System.Windows.Forms.DataGridView();
			this.sicil_no = new System.Windows.Forms.Label();
			this.ad = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.ButtonGuncelle = new System.Windows.Forms.Button();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lokasyon_comboBox = new System.Windows.Forms.ComboBox();
			this.otomasyon_button = new System.Windows.Forms.Button();
			this.vardiyalar_comboBox = new System.Windows.Forms.ComboBox();
			this.gun_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.sicil_no_comboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.vardiyaDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// vardiyaDataTable
			// 
			this.vardiyaDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vardiyaDataTable.Location = new System.Drawing.Point(12, 251);
			this.vardiyaDataTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.vardiyaDataTable.Name = "vardiyaDataTable";
			this.vardiyaDataTable.RowHeadersWidth = 51;
			this.vardiyaDataTable.RowTemplate.Height = 24;
			this.vardiyaDataTable.Size = new System.Drawing.Size(1043, 290);
			this.vardiyaDataTable.TabIndex = 0;
			this.vardiyaDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vardiyaDataTable_CellContentClick);
			// 
			// sicil_no
			// 
			this.sicil_no.AutoSize = true;
			this.sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sicil_no.ForeColor = System.Drawing.Color.White;
			this.sicil_no.Location = new System.Drawing.Point(35, 95);
			this.sicil_no.Name = "sicil_no";
			this.sicil_no.Size = new System.Drawing.Size(167, 20);
			this.sicil_no.TabIndex = 1;
			this.sicil_no.Text = "Personel Sicil No :";
			// 
			// ad
			// 
			this.ad.AutoSize = true;
			this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ad.ForeColor = System.Drawing.Color.White;
			this.ad.Location = new System.Drawing.Point(133, 191);
			this.ad.Name = "ad";
			this.ad.Size = new System.Drawing.Size(90, 20);
			this.ad.TabIndex = 1;
			this.ad.Text = "Vardiya : ";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.email.ForeColor = System.Drawing.Color.White;
			this.email.Location = new System.Drawing.Point(153, 143);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(61, 20);
			this.email.TabIndex = 1;
			this.email.Text = "Gün : ";
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
			this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonReset.Name = "ButtonReset";
			this.ButtonReset.Size = new System.Drawing.Size(100, 39);
			this.ButtonReset.TabIndex = 10;
			this.ButtonReset.Text = "Sıfırla";
			this.ButtonReset.UseVisualStyleBackColor = false;
			this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(493, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Lokasyon : ";
			// 
			// lokasyon_comboBox
			// 
			this.lokasyon_comboBox.FormattingEnabled = true;
			this.lokasyon_comboBox.Items.AddRange(new object[] {
            "Kampüs İçi",
            "Kampüs Dışı"});
			this.lokasyon_comboBox.Location = new System.Drawing.Point(623, 90);
			this.lokasyon_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.lokasyon_comboBox.Name = "lokasyon_comboBox";
			this.lokasyon_comboBox.Size = new System.Drawing.Size(160, 24);
			this.lokasyon_comboBox.TabIndex = 13;
			// 
			// otomasyon_button
			// 
			this.otomasyon_button.BackColor = System.Drawing.Color.DodgerBlue;
			this.otomasyon_button.FlatAppearance.BorderSize = 0;
			this.otomasyon_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.otomasyon_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.otomasyon_button.ForeColor = System.Drawing.Color.White;
			this.otomasyon_button.Location = new System.Drawing.Point(15, 12);
			this.otomasyon_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.otomasyon_button.Name = "otomasyon_button";
			this.otomasyon_button.Size = new System.Drawing.Size(192, 39);
			this.otomasyon_button.TabIndex = 14;
			this.otomasyon_button.Text = "Vardiya Oluştur";
			this.otomasyon_button.UseVisualStyleBackColor = false;
			this.otomasyon_button.Click += new System.EventHandler(this.otomasyon_button_Click);
			// 
			// vardiyalar_comboBox
			// 
			this.vardiyalar_comboBox.FormattingEnabled = true;
			this.vardiyalar_comboBox.Location = new System.Drawing.Point(229, 191);
			this.vardiyalar_comboBox.Name = "vardiyalar_comboBox";
			this.vardiyalar_comboBox.Size = new System.Drawing.Size(191, 24);
			this.vardiyalar_comboBox.TabIndex = 15;
			this.vardiyalar_comboBox.SelectedIndexChanged += new System.EventHandler(this.vardiyalar_comboBox_SelectedIndexChanged);
			// 
			// gun_dateTimePicker
			// 
			this.gun_dateTimePicker.Location = new System.Drawing.Point(229, 143);
			this.gun_dateTimePicker.Name = "gun_dateTimePicker";
			this.gun_dateTimePicker.Size = new System.Drawing.Size(199, 22);
			this.gun_dateTimePicker.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(908, 13);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 39);
			this.button1.TabIndex = 17;
			this.button1.Text = "Tabloyu yenile";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// sicil_no_comboBox
			// 
			this.sicil_no_comboBox.FormattingEnabled = true;
			this.sicil_no_comboBox.Location = new System.Drawing.Point(229, 95);
			this.sicil_no_comboBox.Name = "sicil_no_comboBox";
			this.sicil_no_comboBox.Size = new System.Drawing.Size(191, 24);
			this.sicil_no_comboBox.TabIndex = 18;
			// 
			// vardiya
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.sicil_no_comboBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gun_dateTimePicker);
			this.Controls.Add(this.vardiyalar_comboBox);
			this.Controls.Add(this.otomasyon_button);
			this.Controls.Add(this.lokasyon_comboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sicil_no);
			this.Controls.Add(this.ad);
			this.Controls.Add(this.email);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonGuncelle);
			this.Controls.Add(this.ButtonEkle);
			this.Controls.Add(this.vardiyaDataTable);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "vardiya";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Personel";
			((System.ComponentModel.ISupportInitialize)(this.vardiyaDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.DataGridView vardiyaDataTable;
		private System.Windows.Forms.Label sicil_no;
		private System.Windows.Forms.Label ad;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.Button ButtonEkle;
		private System.Windows.Forms.Button ButtonGuncelle;
		private System.Windows.Forms.Button ButtonSil;
		private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox lokasyon_comboBox;
		private System.Windows.Forms.Button otomasyon_button;
		private System.Windows.Forms.ComboBox vardiyalar_comboBox;
		private System.Windows.Forms.DateTimePicker gun_dateTimePicker;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox sicil_no_comboBox;
	}
}
