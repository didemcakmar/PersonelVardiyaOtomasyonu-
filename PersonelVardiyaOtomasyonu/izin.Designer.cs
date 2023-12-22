namespace  PersonelVardiyaOtomasyonu
{

    partial class izin
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
			this.izinDataTable = new System.Windows.Forms.DataGridView();
			this.pers_sicil = new System.Windows.Forms.Label();
			this.izin_bas_saat = new System.Windows.Forms.Label();
			this.izin_bit_saat = new System.Windows.Forms.Label();
			this.izin_bas_tar = new System.Windows.Forms.Label();
			this.izin_bit_tar = new System.Windows.Forms.Label();
			this.izin_bas_saatTextBox = new System.Windows.Forms.TextBox();
			this.izin_bit_saatTextBox = new System.Windows.Forms.TextBox();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.ButtonGuncelle = new System.Windows.Forms.Button();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.pers_sicilcomboBox = new System.Windows.Forms.ComboBox();
			this.izin_bas_tardateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.izin_bit_tardateTimePicker = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.izinDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// izinDataTable
			// 
			this.izinDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.izinDataTable.Location = new System.Drawing.Point(12, 284);
			this.izinDataTable.Name = "izinDataTable";
			this.izinDataTable.RowHeadersWidth = 51;
			this.izinDataTable.RowTemplate.Height = 24;
			this.izinDataTable.Size = new System.Drawing.Size(1043, 249);
			this.izinDataTable.TabIndex = 0;
			this.izinDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.izinDataTable_CellContentClick);
			// 
			// pers_sicil
			// 
			this.pers_sicil.AutoSize = true;
			this.pers_sicil.Location = new System.Drawing.Point(25, 90);
			this.pers_sicil.Name = "pers_sicil";
			this.pers_sicil.Size = new System.Drawing.Size(64, 16);
			this.pers_sicil.TabIndex = 1;
			this.pers_sicil.Text = "pers_sicil";
			// 
			// izin_bas_saat
			// 
			this.izin_bas_saat.AutoSize = true;
			this.izin_bas_saat.Location = new System.Drawing.Point(25, 120);
			this.izin_bas_saat.Name = "izin_bas_saat";
			this.izin_bas_saat.Size = new System.Drawing.Size(89, 16);
			this.izin_bas_saat.TabIndex = 1;
			this.izin_bas_saat.Text = "izin_bas_saat";
			// 
			// izin_bit_saat
			// 
			this.izin_bit_saat.AutoSize = true;
			this.izin_bit_saat.Location = new System.Drawing.Point(25, 150);
			this.izin_bit_saat.Name = "izin_bit_saat";
			this.izin_bit_saat.Size = new System.Drawing.Size(80, 16);
			this.izin_bit_saat.TabIndex = 1;
			this.izin_bit_saat.Text = "izin_bit_saat";
			// 
			// izin_bas_tar
			// 
			this.izin_bas_tar.AutoSize = true;
			this.izin_bas_tar.Location = new System.Drawing.Point(25, 180);
			this.izin_bas_tar.Name = "izin_bas_tar";
			this.izin_bas_tar.Size = new System.Drawing.Size(78, 16);
			this.izin_bas_tar.TabIndex = 1;
			this.izin_bas_tar.Text = "izin_bas_tar";
			// 
			// izin_bit_tar
			// 
			this.izin_bit_tar.AutoSize = true;
			this.izin_bit_tar.Location = new System.Drawing.Point(25, 210);
			this.izin_bit_tar.Name = "izin_bit_tar";
			this.izin_bit_tar.Size = new System.Drawing.Size(69, 16);
			this.izin_bit_tar.TabIndex = 1;
			this.izin_bit_tar.Text = "izin_bit_tar";
			// 
			// izin_bas_saatTextBox
			// 
			this.izin_bas_saatTextBox.Location = new System.Drawing.Point(127, 122);
			this.izin_bas_saatTextBox.Name = "izin_bas_saatTextBox";
			this.izin_bas_saatTextBox.Size = new System.Drawing.Size(121, 22);
			this.izin_bas_saatTextBox.TabIndex = 4;
			// 
			// izin_bit_saatTextBox
			// 
			this.izin_bit_saatTextBox.Location = new System.Drawing.Point(127, 150);
			this.izin_bit_saatTextBox.Name = "izin_bit_saatTextBox";
			this.izin_bit_saatTextBox.Size = new System.Drawing.Size(121, 22);
			this.izin_bit_saatTextBox.TabIndex = 4;
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
			// pers_sicilcomboBox
			// 
			this.pers_sicilcomboBox.FormattingEnabled = true;
			this.pers_sicilcomboBox.Location = new System.Drawing.Point(127, 87);
			this.pers_sicilcomboBox.Name = "pers_sicilcomboBox";
			this.pers_sicilcomboBox.Size = new System.Drawing.Size(121, 24);
			this.pers_sicilcomboBox.TabIndex = 11;
			// 
			// izin_bas_tardateTimePicker
			// 
			this.izin_bas_tardateTimePicker.Location = new System.Drawing.Point(127, 180);
			this.izin_bas_tardateTimePicker.Name = "izin_bas_tardateTimePicker";
			this.izin_bas_tardateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.izin_bas_tardateTimePicker.TabIndex = 12;
			// 
			// izin_bit_tardateTimePicker
			// 
			this.izin_bit_tardateTimePicker.Location = new System.Drawing.Point(127, 210);
			this.izin_bit_tardateTimePicker.Name = "izin_bit_tardateTimePicker";
			this.izin_bit_tardateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.izin_bit_tardateTimePicker.TabIndex = 13;
			// 
			// izin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.izin_bit_tardateTimePicker);
			this.Controls.Add(this.izin_bas_tardateTimePicker);
			this.Controls.Add(this.pers_sicilcomboBox);
			this.Controls.Add(this.pers_sicil);
			this.Controls.Add(this.izin_bas_saatTextBox);
			this.Controls.Add(this.izin_bas_saat);
			this.Controls.Add(this.izin_bit_saatTextBox);
			this.Controls.Add(this.izin_bit_saat);
			this.Controls.Add(this.izin_bas_tar);
			this.Controls.Add(this.izin_bit_tar);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonGuncelle);
			this.Controls.Add(this.ButtonEkle);
			this.Controls.Add(this.izinDataTable);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "izin";
			this.Text = "PersonelVardiyaOtomasyonu";
			((System.ComponentModel.ISupportInitialize)(this.izinDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

         }
       #endregion

       private System.Windows.Forms.DataGridView izinDataTable;
		private System.Windows.Forms.Label pers_sicil;
		private System.Windows.Forms.Label izin_bas_saat;
      private System.Windows.Forms.TextBox izin_bas_saatTextBox;
		private System.Windows.Forms.Label izin_bit_saat;
      private System.Windows.Forms.TextBox izin_bit_saatTextBox;
		private System.Windows.Forms.Label izin_bas_tar;
		private System.Windows.Forms.Label izin_bit_tar;
       private System.Windows.Forms.Button ButtonEkle;
       private System.Windows.Forms.Button ButtonGuncelle;
       private System.Windows.Forms.Button ButtonSil;
       private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.ComboBox pers_sicilcomboBox;
		private System.Windows.Forms.DateTimePicker izin_bas_tardateTimePicker;
		private System.Windows.Forms.DateTimePicker izin_bit_tardateTimePicker;
	}
}
