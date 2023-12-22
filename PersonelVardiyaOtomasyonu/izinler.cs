using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using PersonelVardiyaOtomasyonu.Tablolar;

namespace PersonelVardiyaOtomasyonu
{
	public partial class izinler : Form
	{
		private readonly DatabaseManager _context;
		private DataTable _dataTable;

		public izinler()
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
		private void LoadData()
		{
			var izin = _context.izin
				.Where(i => i.id != 1 && i.id != 2)
				.ToList();

			_dataTable = ToDataTable(izin);
			izinlerDataTable.DataSource = _dataTable;

			// "id" ve "durum" sütunlarını DataGridView üzerinde gizle
			izinlerDataTable.Columns["id"].Visible = false;

		}

		private DataTable ToDataTable<T>(List<T> items)
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

		private void UpdateTextBoxesFromSelectedRow(DataGridViewRow selectedRow)
		{
			sicil_no_comboBox.Text = selectedRow.Cells["sicil_no"].Value?.ToString();
			izin_bas_tar_dateTimePicker.Text = selectedRow.Cells["baslangic_tarihi"].Value?.ToString();
			izin_bit_tar_dateTimePicker.Text = selectedRow.Cells["bitis_tarihi"].Value?.ToString();
		}



		private void izinlerDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < izinlerDataTable.Rows.Count)
			{
				izinlerDataTable.ClearSelection();
				izinlerDataTable.Rows[e.RowIndex].Selected = true;

				DataGridViewRow selectedRow = izinlerDataTable.Rows[e.RowIndex];
				UpdateTextBoxesFromSelectedRow(selectedRow);
			}
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try
			{
				

				if (int.TryParse(sicil_no_comboBox.Text, out int sicil))
				{
					string baslangic_tarihi = izin_bas_tar_dateTimePicker.Text;
					string bitis_tarihi = izin_bit_tar_dateTimePicker.Text;

					DateTime baslangicTarihi, bitisTarihi;

					if (DateTime.TryParse(baslangic_tarihi, out baslangicTarihi) && DateTime.TryParse(bitis_tarihi, out bitisTarihi))
					{
						int gunFarki = (int)(bitisTarihi - baslangicTarihi).TotalDays;

						var izin = new Tablolar.İzin
						{
							sicil_no = sicil,
							baslangic_tarihi = baslangicTarihi,
							bitis_tarihi = bitisTarihi,

						};

						_context.izin.Add(izin);
						_context.SaveChanges();


						int sonIzinId = izin.id;

						for (int i = 0; i < gunFarki; i++)
						{
							DateTime izinBaslangic = baslangicTarihi.AddDays(i);
							var izinler = new Tablolar.İzinler
							{
								pers_sicil = sicil,
								izin_bas_tar = izinBaslangic,
								durum = sonIzinId,
							};
							_context.izinler.Add(izinler);
							_context.SaveChanges();
						}

						LoadData();
					}
					else
					{
						// Tarih formatı hatalı durumu
					}
				}
				else
				{
					// Sicil numarası geçerli bir sayı değil.
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata oluştu: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Input validation method
		private bool ValidateInput()
		{
			return !string.IsNullOrWhiteSpace(sicil_no_comboBox.Text) &&
				   !string.IsNullOrWhiteSpace(izin_bas_tar_dateTimePicker.Text) &&
				   !string.IsNullOrWhiteSpace(izin_bit_tar_dateTimePicker.Text);
		}
		private void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			if (izinlerDataTable.SelectedRows.Count > 0)
			{
				int selectedRowIndex = izinlerDataTable.SelectedRows[0].Index;
				int selectedId = Convert.ToInt32(izinlerDataTable.Rows[selectedRowIndex].Cells["id"].Value);

				try
				{
					var selectedPerson = _context.izin.FirstOrDefault(i => i.id == selectedId);

					if (selectedPerson != null)
					{


						selectedPerson.sicil_no = int.Parse(sicil_no_comboBox.Text);
						selectedPerson.baslangic_tarihi = izin_bas_tar_dateTimePicker.Value;
						selectedPerson.bitis_tarihi = izin_bit_tar_dateTimePicker.Value;


						_context.SaveChanges();

						MessageBox.Show($"Başarıyla izin güncellendi", "Başarılı", MessageBoxButtons.OK);

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
			if (izinlerDataTable.SelectedRows.Count > 0)
			{
				int selectedRowIndex = izinlerDataTable.SelectedRows[0].Index;
				int selectedIzinId = Convert.ToInt32(izinlerDataTable.Rows[selectedRowIndex].Cells["id"].Value);

				var selectedIzin = _context.izin.Find(selectedIzinId);
				if (selectedIzin != null)
				{
					DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						_context.izin.Remove(selectedIzin);
						_context.SaveChanges();



						MessageBox.Show("Başarıyla izin kaldırıldı", "Başarılı", MessageBoxButtons.OK);
						LoadData();
					}
				}
			}
		}

		private void ButtonReset_Click(object sender, EventArgs e)
		{
		

			izin_bas_tar_dateTimePicker.Text = "";
			izin_bit_tar_dateTimePicker.Text = "";
			izinlerDataTable.ClearSelection();
		}

		internal static object FirstOrDefault(Func<object, bool> value)
		{
			throw new NotImplementedException();
		}
	}
}
