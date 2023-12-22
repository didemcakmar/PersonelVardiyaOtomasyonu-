using Microsoft.EntityFrameworkCore;
using PersonelVardiyaOtomasyonu.Tablolar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PersonelVardiyaOtomasyonu
{
	public partial class personel_profil : Form
	{
		private readonly DatabaseManager _context;
		private DataTable _dataTable;
		private int personelId;

		public personel_profil(int personelId)
		{
			InitializeComponent();
			this.personelId = personelId;
			_context = new DatabaseManager();
			_dataTable = new DataTable();

			// Personel bilgilerini yükle
			LoadPersonelInfo();
		}

		private void LoadPersonelInfo()
		{
			Personel personel = _context.personel.FirstOrDefault(p => p.id == personelId);

			var personel_sicil = personel.sicil_no;
			var personel_vardiya = _context.vardiya_kayit.Where(p => p.Sicil == personel_sicil).ToList();

			if (personel_vardiya.Any())
			{


				// Vardiya bilgilerini bir DataTable'e aktar
				DataTable vardiyaTable = new DataTable();
				vardiyaTable.Columns.Add("Gün");
				vardiyaTable.Columns.Add("Saat");
				vardiyaTable.Columns.Add("Bölge");

				foreach (var result in personel_vardiya)
				{
					// Tarih bilgisini sadece gün, ay ve yıl olarak al
					string tarihStr = result.Gün.ToString("dd.MM.yyyy");

					// DataTable'e ekleyerek saat kısmını göstermeme
					vardiyaTable.Rows.Add(tarihStr, result.Saat, result.Bölge);
				}

				// DataTable'i DataGridView'e bağla
				personel_profilDataTable.DataSource = vardiyaTable;
			}
			else
			{
				MessageBox.Show("Personelin vardiya bilgisi bulunamadı.");
			}


			if (personel != null)
			{

				ad_label.Text = $"{personel.ad}";
				soyad_label.Text = $"{personel.soyad}";
				sicil_no_label.Text = $"{personel.sicil_no}";
				kadro_label.Text = $"{personel.kadro_tipi}";
				ünvan_label.Text = $"{personel.gorev_unvani}";
				email_label.Text = $"{personel.email}";
				telefon_label.Text = $"{personel.telefon}";
				tc_label.Text = $"{personel.kimlik_no}";
				izin_günü_1_label.Text = $"{personel.izin_günü_1}";
				izin_günü_2_label.Text = $"{personel.izin_günü_2}";



			}
			else
			{
				MessageBox.Show("Personel bilgileri bulunamadı.");
			}
		}

		private void personel_profil_Load(object sender, EventArgs e)
		{

		}

		private void telefon_label_Click(object sender, EventArgs e)
		{

		}

		private void telefon_Click(object sender, EventArgs e)
		{

		}
	}
}
