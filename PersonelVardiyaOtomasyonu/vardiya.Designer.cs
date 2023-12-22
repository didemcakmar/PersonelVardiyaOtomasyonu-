namespace  PersonelVardiyaOtomasyonu
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
			this.pers_sicil = new System.Windows.Forms.Label();
			this.vard_bas_saat = new System.Windows.Forms.Label();
			this.vard_bit_saat = new System.Windows.Forms.Label();
			this.vard_gun = new System.Windows.Forms.Label();
			this.vard_konum = new System.Windows.Forms.Label();
			this.vard_gunTextBox = new System.Windows.Forms.TextBox();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.ButtonGuncelle = new System.Windows.Forms.Button();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.vard_konumcomboBox = new System.Windows.Forms.ComboBox();
			this.vard_bit_saatcomboBox = new System.Windows.Forms.ComboBox();
			this.vard_bas_saatcomboBox = new System.Windows.Forms.ComboBox();
			this.pers_sicilcomboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.vardiyaDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// vardiyaDataTable
			// 
			this.vardiyaDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vardiyaDataTable.Location = new System.Drawing.Point(12, 284);
			this.vardiyaDataTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.vardiyaDataTable.Name = "vardiyaDataTable";
			this.vardiyaDataTable.RowHeadersWidth = 51;
			this.vardiyaDataTable.RowTemplate.Height = 24;
			this.vardiyaDataTable.Size = new System.Drawing.Size(1043, 249);
			this.vardiyaDataTable.TabIndex = 0;
			this.vardiyaDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vardiyaDataTable_CellContentClick);
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
			// vard_bas_saat
			// 
			this.vard_bas_saat.AutoSize = true;
			this.vard_bas_saat.Location = new System.Drawing.Point(25, 121);
			this.vard_bas_saat.Name = "vard_bas_saat";
			this.vard_bas_saat.Size = new System.Drawing.Size(97, 16);
			this.vard_bas_saat.TabIndex = 1;
			this.vard_bas_saat.Text = "vard_bas_saat";
			// 
			// vard_bit_saat
			// 
			this.vard_bit_saat.AutoSize = true;
			this.vard_bit_saat.Location = new System.Drawing.Point(25, 150);
			this.vard_bit_saat.Name = "vard_bit_saat";
			this.vard_bit_saat.Size = new System.Drawing.Size(88, 16);
			this.vard_bit_saat.TabIndex = 1;
			this.vard_bit_saat.Text = "vard_bit_saat";
			// 
			// vard_gun
			// 
			this.vard_gun.AutoSize = true;
			this.vard_gun.Location = new System.Drawing.Point(25, 180);
			this.vard_gun.Name = "vard_gun";
			this.vard_gun.Size = new System.Drawing.Size(63, 16);
			this.vard_gun.TabIndex = 1;
			this.vard_gun.Text = "vard_gun";
			// 
			// vard_konum
			// 
			this.vard_konum.AutoSize = true;
			this.vard_konum.Location = new System.Drawing.Point(25, 210);
			this.vard_konum.Name = "vard_konum";
			this.vard_konum.Size = new System.Drawing.Size(81, 16);
			this.vard_konum.TabIndex = 1;
			this.vard_konum.Text = "vard_konum";
			// 
			// vard_gunTextBox
			// 
			this.vard_gunTextBox.Location = new System.Drawing.Point(128, 180);
			this.vard_gunTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.vard_gunTextBox.Name = "vard_gunTextBox";
			this.vard_gunTextBox.Size = new System.Drawing.Size(121, 22);
			this.vard_gunTextBox.TabIndex = 4;
			// 
			// ButtonEkle
			// 
			this.ButtonEkle.Location = new System.Drawing.Point(303, 28);
			this.ButtonEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonEkle.Name = "ButtonEkle";
			this.ButtonEkle.Size = new System.Drawing.Size(75, 23);
			this.ButtonEkle.TabIndex = 7;
			this.ButtonEkle.Text = "Ekle";
			this.ButtonEkle.UseVisualStyleBackColor = true;
			this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
			// 
			// ButtonGuncelle
			// 
			this.ButtonGuncelle.Location = new System.Drawing.Point(403, 28);
			this.ButtonGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
			this.ButtonSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
			this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonReset.Name = "ButtonReset";
			this.ButtonReset.Size = new System.Drawing.Size(75, 23);
			this.ButtonReset.TabIndex = 10;
			this.ButtonReset.Text = "Sıfırla";
			this.ButtonReset.UseVisualStyleBackColor = true;
			this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// vard_konumcomboBox
			// 
			this.vard_konumcomboBox.FormattingEnabled = true;
			this.vard_konumcomboBox.Items.AddRange(new object[] {
            "Kampüs İçi",
            "Kampüs Dışı"});
			this.vard_konumcomboBox.Location = new System.Drawing.Point(128, 210);
			this.vard_konumcomboBox.Name = "vard_konumcomboBox";
			this.vard_konumcomboBox.Size = new System.Drawing.Size(121, 24);
			this.vard_konumcomboBox.TabIndex = 11;
			// 
			// vard_bit_saatcomboBox
			// 
			this.vard_bit_saatcomboBox.FormattingEnabled = true;
			this.vard_bit_saatcomboBox.Items.AddRange(new object[] {
            "08:00",
            "16:00",
            "17:00",
            "24:00"});
			this.vard_bit_saatcomboBox.Location = new System.Drawing.Point(128, 151);
			this.vard_bit_saatcomboBox.Name = "vard_bit_saatcomboBox";
			this.vard_bit_saatcomboBox.Size = new System.Drawing.Size(121, 24);
			this.vard_bit_saatcomboBox.TabIndex = 12;
			// 
			// vard_bas_saatcomboBox
			// 
			this.vard_bas_saatcomboBox.FormattingEnabled = true;
			this.vard_bas_saatcomboBox.Items.AddRange(new object[] {
            "00:00",
            "08:00",
            "09:00",
            "16:00"});
			this.vard_bas_saatcomboBox.Location = new System.Drawing.Point(128, 121);
			this.vard_bas_saatcomboBox.Name = "vard_bas_saatcomboBox";
			this.vard_bas_saatcomboBox.Size = new System.Drawing.Size(121, 24);
			this.vard_bas_saatcomboBox.TabIndex = 13;
			// 
			// pers_sicilcomboBox
			// 
			this.pers_sicilcomboBox.FormattingEnabled = true;
			this.pers_sicilcomboBox.Location = new System.Drawing.Point(128, 87);
			this.pers_sicilcomboBox.Name = "pers_sicilcomboBox";
			this.pers_sicilcomboBox.Size = new System.Drawing.Size(121, 24);
			this.pers_sicilcomboBox.TabIndex = 14;
		
			// 
			// vardiya
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.pers_sicilcomboBox);
			this.Controls.Add(this.vard_bas_saatcomboBox);
			this.Controls.Add(this.vard_bit_saatcomboBox);
			this.Controls.Add(this.vard_konumcomboBox);
			this.Controls.Add(this.pers_sicil);
			this.Controls.Add(this.vard_bas_saat);
			this.Controls.Add(this.vard_bit_saat);
			this.Controls.Add(this.vard_gunTextBox);
			this.Controls.Add(this.vard_gun);
			this.Controls.Add(this.vard_konum);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonGuncelle);
			this.Controls.Add(this.ButtonEkle);
			this.Controls.Add(this.vardiyaDataTable);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "vardiya";
			this.Text = "PersonelVardiyaOtomasyonu";
			((System.ComponentModel.ISupportInitialize)(this.vardiyaDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

         }
       #endregion

       private System.Windows.Forms.DataGridView vardiyaDataTable;
		private System.Windows.Forms.Label pers_sicil;
		private System.Windows.Forms.Label vard_bas_saat;
		private System.Windows.Forms.Label vard_bit_saat;
		private System.Windows.Forms.Label vard_gun;
      private System.Windows.Forms.TextBox vard_gunTextBox;
		private System.Windows.Forms.Label vard_konum;
       private System.Windows.Forms.Button ButtonEkle;
       private System.Windows.Forms.Button ButtonGuncelle;
       private System.Windows.Forms.Button ButtonSil;
       private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.ComboBox vard_konumcomboBox;
		private System.Windows.Forms.ComboBox vard_bit_saatcomboBox;
		private System.Windows.Forms.ComboBox vard_bas_saatcomboBox;
		private System.Windows.Forms.ComboBox pers_sicilcomboBox;
	}
}
