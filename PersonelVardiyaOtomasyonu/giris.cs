using PersonelVardiyaOtomasyonu.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelVardiyaOtomasyonu
{
	public partial class giris : Form
	{
		public giris()
		{
			InitializeComponent();
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			string mail = emailtxt.Text;
			string password = sifretxt.Text;
			using (var context = new DatabaseManager())
			{
				// Personel tablosunu kontrol et
				var personel = context.personel.FirstOrDefault(p => p.email == mail && p.sifre == password);
				if (personel != null)
				{

					int personelId = personel.id;

					// Personel profil formunu oluştur ve ID'yi iletebilirsiniz
					personel_profil personelProfilForm = new personel_profil(personelId);

					// Personel profil formunu göster
					personelProfilForm.Show();

					// Şu anki formu gizle
					this.Hide();
				}

				// Yonetici tablosunu kontrol et
				var yonetici = context.yonetici.FirstOrDefault(y => y.yon_mail == mail && y.yon_sifre == password);
				if (yonetici != null)
				{
					menu mainForm = new menu();
					mainForm.Show();
					this.Hide();
				}


			}
		}

		private void ButtonSil_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
