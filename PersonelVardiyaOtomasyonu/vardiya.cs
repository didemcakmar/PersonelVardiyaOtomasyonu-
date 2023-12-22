using PersonelVardiyaOtomasyonu.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelVardiyaOtomasyonu
{
	public partial class vardiya : Form
	{
		private readonly DatabaseManager _context;
		private DataTable _dataTable;


		public vardiya()
		{
			InitializeComponent();
			_context = new DatabaseManager();
			_dataTable = new DataTable();
			LoadData();
			FillSicilComboBox();
		}


		private void FillSicilComboBox()
		{
			try
			{
				// Personel tablosundan tüm sicil numaralarını al
				var sicilNumaralari = _context.personel.Select(p => p.sicil_no.ToString()).ToList();

				// "Seçiniz" metnini ekleyin
				sicilNumaralari.Insert(0, "Seçiniz");

				// ComboBox'a sicil numaralarını ekle
				sicil_no_comboBox.DataSource = sicilNumaralari;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sicil numaralarını listelerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void LoadData()
		{
			var vardiya = _context.vardiya_kayit.ToList();
			_dataTable = ToDataTable(vardiya);
			vardiyaDataTable.DataSource = _dataTable;
			ListVardiyalar();
		}

		public void ListVardiyalar()
		{
			try
			{
				var vardiyalar = _context.vardiyalar.ToList();

				vardiyalar_comboBox.DataSource = vardiyalar;

				vardiyalar_comboBox.DisplayMember = "vardiye";

				vardiyalar_comboBox.ValueMember = "id";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Vardiyaları listelerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public DataTable ToDataTable<T>(List<T> items)
		{
			DataTable dataTable = new DataTable(typeof(T).Name);

			PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (PropertyInfo prop in props)
			{
				dataTable.Columns.Add(prop.Name);
			}
			foreach (T item in items)
			{
				DataRow row = dataTable.NewRow();
				foreach (PropertyInfo prop in props)
				{
					row[prop.Name] = prop.GetValue(item, null);
				}
				dataTable.Rows.Add(row);
			}

			return dataTable;
		}

		private void vardiyaDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < vardiyaDataTable.Rows.Count)
			{
				vardiyaDataTable.ClearSelection();
				vardiyaDataTable.Rows[e.RowIndex].Selected = true;

				DataGridViewRow selectedRow = vardiyaDataTable.Rows[e.RowIndex];

				string pers_sicil = selectedRow.Cells["Sicil"].Value?.ToString();
				sicil_no_comboBox.Text = pers_sicil;

				string vard_bas_saat = selectedRow.Cells["Gün"].Value?.ToString();
				gun_dateTimePicker.Text = vard_bas_saat;

				string vard_bit_saat = selectedRow.Cells["Saat"].Value?.ToString();
				vardiyalar_comboBox.Text = vard_bit_saat;

				string vard_gun = selectedRow.Cells["Bölge"].Value?.ToString();
				lokasyon_comboBox.Text = vard_gun;




			}
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(sicil_no_comboBox.Text) || string.IsNullOrWhiteSpace(vardiyalar_comboBox.Text) || string.IsNullOrWhiteSpace(lokasyon_comboBox.Text))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}


				if (int.TryParse(sicil_no_comboBox.Text, out int sicil))
				{
					int sicilss = Convert.ToInt32(sicil_no_comboBox.Text);



					var vardiya_kayit = new Tablolar.VardiyaKayit
					{
						Sicil = sicilss,
						Gün = gun_dateTimePicker.Value,
						Saat = vardiyalar_comboBox.Text,
						Bölge = lokasyon_comboBox.Text
					};

					_context.vardiya_kayit.Add(vardiya_kayit);
					_context.SaveChanges();

					var enSonEklenenVardiyaId = _context.vardiyalar
						.OrderByDescending(v => v.id)
						.Select(v => v.id)
						.FirstOrDefault();


					MessageBox.Show("Başarıyla vardiya eklendi", "Başarılı", MessageBoxButtons.OK);


					LoadData();
				}
				else
				{
					MessageBox.Show("Geçerli bir sicil numarası ve izin saatleri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata oluştu: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			if (vardiyaDataTable.SelectedRows.Count > 0)
			{
				int selectedRowIndex = vardiyaDataTable.SelectedRows[0].Index;
				int selectedId = Convert.ToInt32(vardiyaDataTable.Rows[selectedRowIndex].Cells["id"].Value);

				try
				{
					var selectedVardiya = _context.vardiya_kayit.FirstOrDefault(v => v.ID == selectedId);


					if (selectedVardiya != null)
					{
						// Update vardiya entity
						if (int.TryParse(sicil_no_comboBox.Text, out int sicil))
						{

						}
						else
						{
							MessageBox.Show("Geçerli bir sicil numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}

						int sicilss = Convert.ToInt32(sicil_no_comboBox.Text);


						selectedVardiya.Sicil = sicilss;
						selectedVardiya.Gün = gun_dateTimePicker.Value;
						selectedVardiya.Saat = vardiyalar_comboBox.Text;
						selectedVardiya.Bölge = lokasyon_comboBox.Text;

						_context.SaveChanges();


						MessageBox.Show($"Başarıyla Vardiya Güncellendi", "Başarılı", MessageBoxButtons.OK);

						LoadData();
					}



				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		private void ButtonSil_Click(object sender, EventArgs e)
		{
			if (vardiyaDataTable.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Seçili vardiyayı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.Yes)
				{
					int selectedRowIndex = vardiyaDataTable.SelectedRows[0].Index;
					int selectedId = Convert.ToInt32(vardiyaDataTable.Rows[selectedRowIndex].Cells["ID"].Value);

					try
					{
						var selectedVardiya = _context.vardiya_kayit.FirstOrDefault(v => v.ID == selectedId);

						if (selectedVardiya != null)
						{
							// Remove vardiya from the context
							_context.vardiya_kayit.Remove(selectedVardiya);

							// Save changes to the database
							_context.SaveChanges();

							MessageBox.Show($"Başarıyla Vardiya Silindi", "Başarılı", MessageBoxButtons.OK);

							LoadData();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen silinecek bir vardiya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		private void ButtonReset_Click(object sender, EventArgs e)
		{
			vardiyaDataTable.ClearSelection();
		}

		private void otomasyon_button_Click(object sender, EventArgs e)
		{
			otomasyon mainForm = new otomasyon();
			mainForm.Show();
		}

		private void vardiyalar_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

			var vardiyalar = _context.vardiyalar.ToList();


			vardiyalar_comboBox.DataSource = vardiyalar;


			vardiyalar_comboBox.DisplayMember = "vardiye";

			// ComboBox'ta kullanılacak değeri belirt (vardiyalar tablosundaki bir özellik)
			vardiyalar_comboBox.ValueMember = "id";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LoadData();
		}

	}
}
