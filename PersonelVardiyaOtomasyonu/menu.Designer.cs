namespace PersonelVardiyaOtomasyonu
{
	partial class menu
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
            this.Personeller = new System.Windows.Forms.Button();
            this.izin = new System.Windows.Forms.Button();
            this.vardiya = new System.Windows.Forms.Button();
            this.yönetici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Personeller
            // 
            this.Personeller.Location = new System.Drawing.Point(12, 12);
            this.Personeller.Name = "Personeller";
            this.Personeller.Size = new System.Drawing.Size(165, 53);
            this.Personeller.TabIndex = 1;
            this.Personeller.Text = "Personel";
            this.Personeller.UseVisualStyleBackColor = true;
            this.Personeller.Click += new System.EventHandler(this.Personeller_Click);
            // 
            // izin
            // 
            this.izin.Location = new System.Drawing.Point(12, 87);
            this.izin.Name = "izin";
            this.izin.Size = new System.Drawing.Size(165, 53);
            this.izin.TabIndex = 2;
            this.izin.Text = "İzin";
            this.izin.UseVisualStyleBackColor = true;
            this.izin.Click += new System.EventHandler(this.izin_Click);
            // 
            // vardiya
            // 
            this.vardiya.Location = new System.Drawing.Point(206, 12);
            this.vardiya.Name = "vardiya";
            this.vardiya.Size = new System.Drawing.Size(165, 53);
            this.vardiya.TabIndex = 3;
            this.vardiya.Text = "Vardiya";
            this.vardiya.UseVisualStyleBackColor = true;
            this.vardiya.Click += new System.EventHandler(this.button3_Click);
            // 
            // yönetici
            // 
            this.yönetici.Location = new System.Drawing.Point(206, 87);
            this.yönetici.Name = "yönetici";
            this.yönetici.Size = new System.Drawing.Size(165, 53);
            this.yönetici.TabIndex = 4;
            this.yönetici.Text = "Yönetici";
            this.yönetici.UseVisualStyleBackColor = true;
            this.yönetici.Click += new System.EventHandler(this.yönetici_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 164);
            this.Controls.Add(this.yönetici);
            this.Controls.Add(this.vardiya);
            this.Controls.Add(this.izin);
            this.Controls.Add(this.Personeller);
            this.Name = "menu";
            this.Text = "Menü";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Personeller;
		private System.Windows.Forms.Button izin;
		private System.Windows.Forms.Button vardiya;
		private System.Windows.Forms.Button yönetici;
	}
}

