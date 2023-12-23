namespace PersonelVardiyaOtomasyonu
{

	partial class izinler
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
			this.izinlerDataTable = new System.Windows.Forms.DataGridView();
			this.sicil_no = new System.Windows.Forms.Label();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.ButtonGuncelle = new System.Windows.Forms.Button();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.pers_sicil_noTextBox = new System.Windows.Forms.TextBox();
			this.izin_bas_tar_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.izin_bit_tar_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.izinlerDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// izinlerDataTable
			// 
			this.izinlerDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.izinlerDataTable.Location = new System.Drawing.Point(9, 204);
			this.izinlerDataTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.izinlerDataTable.Name = "izinlerDataTable";
			this.izinlerDataTable.RowHeadersWidth = 51;
			this.izinlerDataTable.RowTemplate.Height = 24;
			this.izinlerDataTable.Size = new System.Drawing.Size(782, 236);
			this.izinlerDataTable.TabIndex = 0;
			this.izinlerDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.izinlerDataTable_CellContentClick);
			// 
			// sicil_no
			// 
			this.sicil_no.AutoSize = true;
			this.sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sicil_no.ForeColor = System.Drawing.Color.White;
			this.sicil_no.Location = new System.Drawing.Point(82, 76);
			this.sicil_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.sicil_no.Name = "sicil_no";
			this.sicil_no.Size = new System.Drawing.Size(147, 17);
			this.sicil_no.TabIndex = 1;
			this.sicil_no.Text = "Personel Sicil No : ";
			// 
			// ButtonEkle
			// 
			this.ButtonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ButtonEkle.Cursor = System.Windows.Forms.Cursors.Default;
			this.ButtonEkle.FlatAppearance.BorderSize = 0;
			this.ButtonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonEkle.ForeColor = System.Drawing.Color.White;
			this.ButtonEkle.Location = new System.Drawing.Point(240, 10);
			this.ButtonEkle.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonEkle.Name = "ButtonEkle";
			this.ButtonEkle.Size = new System.Drawing.Size(75, 32);
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
			this.ButtonGuncelle.Location = new System.Drawing.Point(326, 10);
			this.ButtonGuncelle.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonGuncelle.Name = "ButtonGuncelle";
			this.ButtonGuncelle.Size = new System.Drawing.Size(75, 32);
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
			this.ButtonSil.Location = new System.Drawing.Point(406, 10);
			this.ButtonSil.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonSil.Name = "ButtonSil";
			this.ButtonSil.Size = new System.Drawing.Size(75, 32);
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
			this.ButtonReset.Location = new System.Drawing.Point(485, 10);
			this.ButtonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ButtonReset.Name = "ButtonReset";
			this.ButtonReset.Size = new System.Drawing.Size(75, 32);
			this.ButtonReset.TabIndex = 10;
			this.ButtonReset.Text = "Sıfırla";
			this.ButtonReset.UseVisualStyleBackColor = false;
			this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// pers_sicil_noTextBox
			// 
			this.pers_sicil_noTextBox.CausesValidation = false;
			this.pers_sicil_noTextBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.pers_sicil_noTextBox.Location = new System.Drawing.Point(261, 75);
			this.pers_sicil_noTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pers_sicil_noTextBox.Name = "pers_sicil_noTextBox";
			this.pers_sicil_noTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.pers_sicil_noTextBox.Size = new System.Drawing.Size(151, 20);
			this.pers_sicil_noTextBox.TabIndex = 4;
			// 
			// izin_bas_tar_dateTimePicker
			// 
			this.izin_bas_tar_dateTimePicker.Location = new System.Drawing.Point(261, 128);
			this.izin_bas_tar_dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.izin_bas_tar_dateTimePicker.Name = "izin_bas_tar_dateTimePicker";
			this.izin_bas_tar_dateTimePicker.Size = new System.Drawing.Size(151, 20);
			this.izin_bas_tar_dateTimePicker.TabIndex = 13;
			// 
			// izin_bit_tar_dateTimePicker
			// 
			this.izin_bit_tar_dateTimePicker.Location = new System.Drawing.Point(261, 164);
			this.izin_bit_tar_dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.izin_bit_tar_dateTimePicker.Name = "izin_bit_tar_dateTimePicker";
			this.izin_bit_tar_dateTimePicker.Size = new System.Drawing.Size(151, 20);
			this.izin_bit_tar_dateTimePicker.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(72, 126);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 17);
			this.label3.TabIndex = 17;
			this.label3.Text = "İzin Başlangıç Tarihi : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(111, 164);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 17);
			this.label4.TabIndex = 18;
			this.label4.Text = "İzin Bitiş Tarihi : ";
			// 
			// izinler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.izin_bit_tar_dateTimePicker);
			this.Controls.Add(this.izin_bas_tar_dateTimePicker);
			this.Controls.Add(this.pers_sicil_noTextBox);
			this.Controls.Add(this.sicil_no);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonGuncelle);
			this.Controls.Add(this.ButtonEkle);
			this.Controls.Add(this.izinlerDataTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "izinler";
			this.ShowIcon = false;
			this.Text = "Personel";
			((System.ComponentModel.ISupportInitialize)(this.izinlerDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.DataGridView izinlerDataTable;
		private System.Windows.Forms.Label sicil_no;
		private System.Windows.Forms.Button ButtonEkle;
		private System.Windows.Forms.Button ButtonGuncelle;
		private System.Windows.Forms.Button ButtonSil;
		private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.TextBox pers_sicil_noTextBox;
		private System.Windows.Forms.DateTimePicker izin_bas_tar_dateTimePicker;
		private System.Windows.Forms.DateTimePicker izin_bit_tar_dateTimePicker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}
