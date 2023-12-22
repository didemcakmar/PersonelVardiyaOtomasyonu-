namespace PersonelVardiyaOtomasyonu
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
			this.sicil_no = new System.Windows.Forms.Label();
			this.ad = new System.Windows.Forms.Label();
			this.telefon = new System.Windows.Forms.Label();
			this.sifre_TextBox = new System.Windows.Forms.TextBox();
			this.email_TextBox = new System.Windows.Forms.TextBox();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.ButtonGuncelle = new System.Windows.Forms.Button();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.ad_soyad_TextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.yoneticiDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// yoneticiDataTable
			// 
			this.yoneticiDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.yoneticiDataTable.Location = new System.Drawing.Point(9, 204);
			this.yoneticiDataTable.Margin = new System.Windows.Forms.Padding(2);
			this.yoneticiDataTable.Name = "yoneticiDataTable";
			this.yoneticiDataTable.RowHeadersWidth = 51;
			this.yoneticiDataTable.RowTemplate.Height = 24;
			this.yoneticiDataTable.Size = new System.Drawing.Size(782, 236);
			this.yoneticiDataTable.TabIndex = 0;
			this.yoneticiDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yoneticiDataTable_CellContentClick);
			// 
			// sicil_no
			// 
			this.sicil_no.AutoSize = true;
			this.sicil_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sicil_no.ForeColor = System.Drawing.Color.White;
			this.sicil_no.Location = new System.Drawing.Point(77, 77);
			this.sicil_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.sicil_no.Name = "sicil_no";
			this.sicil_no.Size = new System.Drawing.Size(87, 17);
			this.sicil_no.TabIndex = 1;
			this.sicil_no.Text = "Ad Soyad :";
			// 
			// ad
			// 
			this.ad.AutoSize = true;
			this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ad.ForeColor = System.Drawing.Color.White;
			this.ad.Location = new System.Drawing.Point(102, 154);
			this.ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ad.Name = "ad";
			this.ad.Size = new System.Drawing.Size(62, 17);
			this.ad.TabIndex = 1;
			this.ad.Text = "Şifre :  ";
			// 
			// telefon
			// 
			this.telefon.AutoSize = true;
			this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.telefon.ForeColor = System.Drawing.Color.White;
			this.telefon.Location = new System.Drawing.Point(88, 116);
			this.telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.telefon.Name = "telefon";
			this.telefon.Size = new System.Drawing.Size(80, 17);
			this.telefon.TabIndex = 1;
			this.telefon.Text = "E-Posta : ";
			// 
			// sifre_TextBox
			// 
			this.sifre_TextBox.Location = new System.Drawing.Point(172, 154);
			this.sifre_TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.sifre_TextBox.Name = "sifre_TextBox";
			this.sifre_TextBox.Size = new System.Drawing.Size(92, 20);
			this.sifre_TextBox.TabIndex = 4;
			// 
			// email_TextBox
			// 
			this.email_TextBox.Location = new System.Drawing.Point(172, 113);
			this.email_TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.email_TextBox.Name = "email_TextBox";
			this.email_TextBox.Size = new System.Drawing.Size(92, 20);
			this.email_TextBox.TabIndex = 4;
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
			this.ButtonReset.Margin = new System.Windows.Forms.Padding(2);
			this.ButtonReset.Name = "ButtonReset";
			this.ButtonReset.Size = new System.Drawing.Size(75, 32);
			this.ButtonReset.TabIndex = 10;
			this.ButtonReset.Text = "Sıfırla";
			this.ButtonReset.UseVisualStyleBackColor = false;
			this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// ad_soyad_TextBox
			// 
			this.ad_soyad_TextBox.CausesValidation = false;
			this.ad_soyad_TextBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.ad_soyad_TextBox.Location = new System.Drawing.Point(172, 77);
			this.ad_soyad_TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.ad_soyad_TextBox.Name = "ad_soyad_TextBox";
			this.ad_soyad_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.ad_soyad_TextBox.Size = new System.Drawing.Size(92, 20);
			this.ad_soyad_TextBox.TabIndex = 4;
			// 
			// yonetici
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ad_soyad_TextBox);
			this.Controls.Add(this.sicil_no);
			this.Controls.Add(this.sifre_TextBox);
			this.Controls.Add(this.ad);
			this.Controls.Add(this.email_TextBox);
			this.Controls.Add(this.telefon);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonGuncelle);
			this.Controls.Add(this.ButtonEkle);
			this.Controls.Add(this.yoneticiDataTable);
			this.MaximizeBox = false;
			this.Name = "yonetici";
			this.ShowIcon = false;
			this.Text = "Personel";
			((System.ComponentModel.ISupportInitialize)(this.yoneticiDataTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.DataGridView yoneticiDataTable;
		private System.Windows.Forms.Label sicil_no;
		private System.Windows.Forms.Label ad;
		private System.Windows.Forms.TextBox sifre_TextBox;
		private System.Windows.Forms.Label telefon;
		private System.Windows.Forms.TextBox email_TextBox;
		private System.Windows.Forms.Button ButtonEkle;
		private System.Windows.Forms.Button ButtonGuncelle;
		private System.Windows.Forms.Button ButtonSil;
		private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.TextBox ad_soyad_TextBox;
	}
}
