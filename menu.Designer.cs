namespace PersonelVardiyaOtomasyonu
{
	partial class menu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.personeller = new System.Windows.Forms.Button();
			this.vardiyalar = new System.Windows.Forms.Button();
			this.izinler = new System.Windows.Forms.Button();
			this.yöneticiler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// personeller
			// 
			this.personeller.BackColor = System.Drawing.Color.White;
			this.personeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.personeller.ForeColor = System.Drawing.Color.Black;
			this.personeller.Location = new System.Drawing.Point(12, 12);
			this.personeller.Name = "personeller";
			this.personeller.Size = new System.Drawing.Size(110, 43);
			this.personeller.TabIndex = 0;
			this.personeller.Text = "Personeller";
			this.personeller.UseVisualStyleBackColor = false;
			this.personeller.Click += new System.EventHandler(this.personeller_Click);
			// 
			// vardiyalar
			// 
			this.vardiyalar.BackColor = System.Drawing.Color.White;
			this.vardiyalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.vardiyalar.Location = new System.Drawing.Point(209, 12);
			this.vardiyalar.Name = "vardiyalar";
			this.vardiyalar.Size = new System.Drawing.Size(110, 43);
			this.vardiyalar.TabIndex = 1;
			this.vardiyalar.Text = "Vardiyalar";
			this.vardiyalar.UseVisualStyleBackColor = false;
			this.vardiyalar.Click += new System.EventHandler(this.vardiyalar_Click);
			// 
			// izinler
			// 
			this.izinler.BackColor = System.Drawing.Color.White;
			this.izinler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.izinler.Location = new System.Drawing.Point(12, 85);
			this.izinler.Name = "izinler";
			this.izinler.Size = new System.Drawing.Size(110, 43);
			this.izinler.TabIndex = 2;
			this.izinler.Text = "İzinler";
			this.izinler.UseVisualStyleBackColor = false;
			this.izinler.Click += new System.EventHandler(this.izinler_Click);
			// 
			// yöneticiler
			// 
			this.yöneticiler.BackColor = System.Drawing.Color.White;
			this.yöneticiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yöneticiler.Location = new System.Drawing.Point(209, 85);
			this.yöneticiler.Name = "yöneticiler";
			this.yöneticiler.Size = new System.Drawing.Size(110, 43);
			this.yöneticiler.TabIndex = 3;
			this.yöneticiler.Text = "Yöneticiler";
			this.yöneticiler.UseVisualStyleBackColor = false;
			this.yöneticiler.Click += new System.EventHandler(this.yöneticiler_Click);
			// 
			// menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
			this.ClientSize = new System.Drawing.Size(344, 163);
			this.Controls.Add(this.yöneticiler);
			this.Controls.Add(this.izinler);
			this.Controls.Add(this.vardiyalar);
			this.Controls.Add(this.personeller);
			this.MaximizeBox = false;
			this.Name = "menu";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button personeller;
		private System.Windows.Forms.Button vardiyalar;
		private System.Windows.Forms.Button izinler;
		private System.Windows.Forms.Button yöneticiler;
	}
}