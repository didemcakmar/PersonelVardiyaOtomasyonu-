namespace PersonelVardiyaOtomasyonu
{

	partial class otomasyon
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
			this.baslangic_tarihi = new System.Windows.Forms.Label();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.bitis_tarihi = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.baslangic_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.bitis_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// baslangic_tarihi
			// 
			this.baslangic_tarihi.AutoSize = true;
			this.baslangic_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.baslangic_tarihi.ForeColor = System.Drawing.Color.White;
			this.baslangic_tarihi.Location = new System.Drawing.Point(39, 81);
			this.baslangic_tarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.baslangic_tarihi.Name = "baslangic_tarihi";
			this.baslangic_tarihi.Size = new System.Drawing.Size(140, 17);
			this.baslangic_tarihi.TabIndex = 1;
			this.baslangic_tarihi.Text = "Başlangıç Tarihi : ";
			// 
			// ButtonSil
			// 
			this.ButtonSil.BackColor = System.Drawing.Color.Red;
			this.ButtonSil.FlatAppearance.BorderSize = 0;
			this.ButtonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonSil.ForeColor = System.Drawing.Color.White;
			this.ButtonSil.Location = new System.Drawing.Point(322, 183);
			this.ButtonSil.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonSil.Name = "ButtonSil";
			this.ButtonSil.Size = new System.Drawing.Size(75, 32);
			this.ButtonSil.TabIndex = 9;
			this.ButtonSil.Text = "Çıkış";
			this.ButtonSil.UseVisualStyleBackColor = false;
			this.ButtonSil.Click += new System.EventHandler(this.ButtonSil_Click);
			// 
			// ButtonEkle
			// 
			this.ButtonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ButtonEkle.Cursor = System.Windows.Forms.Cursors.Default;
			this.ButtonEkle.FlatAppearance.BorderSize = 0;
			this.ButtonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonEkle.ForeColor = System.Drawing.Color.White;
			this.ButtonEkle.Location = new System.Drawing.Point(42, 183);
			this.ButtonEkle.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonEkle.Name = "ButtonEkle";
			this.ButtonEkle.Size = new System.Drawing.Size(75, 32);
			this.ButtonEkle.TabIndex = 7;
			this.ButtonEkle.Text = "Oluştura";
			this.ButtonEkle.UseVisualStyleBackColor = false;
			this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
			// 
			// bitis_tarihi
			// 
			this.bitis_tarihi.AutoSize = true;
			this.bitis_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bitis_tarihi.ForeColor = System.Drawing.Color.White;
			this.bitis_tarihi.Location = new System.Drawing.Point(73, 132);
			this.bitis_tarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.bitis_tarihi.Name = "bitis_tarihi";
			this.bitis_tarihi.Size = new System.Drawing.Size(106, 17);
			this.bitis_tarihi.TabIndex = 1;
			this.bitis_tarihi.Text = "Bitiş Tarihi :  ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(118, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Vardiya Otomasyon";
			// 
			// baslangic_dateTimePicker
			// 
			this.baslangic_dateTimePicker.Location = new System.Drawing.Point(181, 78);
			this.baslangic_dateTimePicker.Name = "baslangic_dateTimePicker";
			this.baslangic_dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.baslangic_dateTimePicker.TabIndex = 11;
			// 
			// bitis_dateTimePicker
			// 
			this.bitis_dateTimePicker.Location = new System.Drawing.Point(181, 129);
			this.bitis_dateTimePicker.Name = "bitis_dateTimePicker";
			this.bitis_dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.bitis_dateTimePicker.TabIndex = 12;
			// 
			// otomasyon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(431, 250);
			this.Controls.Add(this.bitis_dateTimePicker);
			this.Controls.Add(this.baslangic_dateTimePicker);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bitis_tarihi);
			this.Controls.Add(this.baslangic_tarihi);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonEkle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "otomasyon";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Yap";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.Label baslangic_tarihi;
		private System.Windows.Forms.Button ButtonSil;
		private System.Windows.Forms.Button ButtonEkle;
		private System.Windows.Forms.Label bitis_tarihi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker baslangic_dateTimePicker;
		private System.Windows.Forms.DateTimePicker bitis_dateTimePicker;
	}
}
