namespace PersonelVardiyaOtomasyonu
{

	partial class giris
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
			this.ad = new System.Windows.Forms.Label();
			this.telefon = new System.Windows.Forms.Label();
			this.sifretxt = new System.Windows.Forms.TextBox();
			this.emailtxt = new System.Windows.Forms.TextBox();
			this.ButtonSil = new System.Windows.Forms.Button();
			this.ButtonEkle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ad
			// 
			this.ad.AutoSize = true;
			this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ad.ForeColor = System.Drawing.Color.White;
			this.ad.Location = new System.Drawing.Point(39, 112);
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
			this.telefon.Location = new System.Drawing.Point(21, 71);
			this.telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.telefon.Name = "telefon";
			this.telefon.Size = new System.Drawing.Size(80, 17);
			this.telefon.TabIndex = 1;
			this.telefon.Text = "E-Posta : ";
			// 
			// sifretxt
			// 
			this.sifretxt.Location = new System.Drawing.Point(105, 112);
			this.sifretxt.Margin = new System.Windows.Forms.Padding(2);
			this.sifretxt.Name = "sifretxt";
			this.sifretxt.Size = new System.Drawing.Size(92, 20);
			this.sifretxt.TabIndex = 4;
			// 
			// emailtxt
			// 
			this.emailtxt.Location = new System.Drawing.Point(105, 68);
			this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
			this.emailtxt.Name = "emailtxt";
			this.emailtxt.Size = new System.Drawing.Size(92, 20);
			this.emailtxt.TabIndex = 4;
			// 
			// ButtonSil
			// 
			this.ButtonSil.BackColor = System.Drawing.Color.Red;
			this.ButtonSil.FlatAppearance.BorderSize = 0;
			this.ButtonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ButtonSil.ForeColor = System.Drawing.Color.White;
			this.ButtonSil.Location = new System.Drawing.Point(151, 166);
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
			this.ButtonEkle.Location = new System.Drawing.Point(9, 166);
			this.ButtonEkle.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonEkle.Name = "ButtonEkle";
			this.ButtonEkle.Size = new System.Drawing.Size(75, 32);
			this.ButtonEkle.TabIndex = 7;
			this.ButtonEkle.Text = "Giriş";
			this.ButtonEkle.UseVisualStyleBackColor = false;
			this.ButtonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
			// 
			// giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(235, 231);
			this.Controls.Add(this.sifretxt);
			this.Controls.Add(this.ad);
			this.Controls.Add(this.emailtxt);
			this.Controls.Add(this.telefon);
			this.Controls.Add(this.ButtonSil);
			this.Controls.Add(this.ButtonEkle);
			this.MaximizeBox = false;
			this.Name = "giris";
			this.ShowIcon = false;
			this.Text = "Personel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.Label ad;
		private System.Windows.Forms.TextBox sifretxt;
		private System.Windows.Forms.Label telefon;
		private System.Windows.Forms.TextBox emailtxt;
		private System.Windows.Forms.Button ButtonSil;
		private System.Windows.Forms.Button ButtonEkle;
	}
}
