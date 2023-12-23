using System;
using System.Collections.Generic;
using System.Data;
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
		}

		private void LoadData()
		{
			var izinler = _context.izinler.Where(i => i.durum == "1").ToList();
			_dataTable = ToDataTable(izinler);
			izinlerDataTable.DataSource = _dataTable;

			// "id" ve "durum" sütunlarını DataGridView üzerinde gizle
			izinlerDataTable.Columns["id"].Visible = false;
			izinlerDataTable.Columns["durum"].Visible = false;
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
			pers_sicil_noTextBox.Text = selectedRow.Cells["pers_sicil"].Value?.ToString();
			izin_bas_tar_dateTimePicker.Text = selectedRow.Cells["izin_bas_tar"].Value?.ToString();
			izin_bit_tar_dateTimePicker.Text = selectedRow.Cells["izin_bit_tar"].Value?.ToString();
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
				// Input validation
				if (!ValidateInput())
				{
					MessageBox.Show("Lütfen tüm alanları geçerli bir şekilde doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Parse input values
				if (int.TryParse(pers_sicil_noTextBox.Text, out int sicil))
				{
					// Create new izin entity
					var izin = new Tablolar.İzinler
					{
						pers_sicil = sicil,
						izin_bas_tar = izin_bas_tar_dateTimePicker.Text,
						izin_bit_tar = izin_bit_tar_dateTimePicker.Text,
						durum = "1",
					};

					// Add izin to the context
					_context.izinler.Add(izin);

					// Save changes to the database
					_context.SaveChanges();

					MessageBox.Show("Başarıyla izin eklendi", "Başarılı", MessageBoxButtons.OK);


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

		// Input validation method
		private bool ValidateInput()
		{
			return !string.IsNullOrWhiteSpace(pers_sicil_noTextBox.Text) &&
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
					var selectedPerson = _context.izinler.FirstOrDefault(i => i.id == selectedId);

					if (selectedPerson != null)
					{
						// Input validation

						selectedPerson.pers_sicil = int.Parse(pers_sicil_noTextBox.Text);
						selectedPerson.izin_bas_tar = izin_bas_tar_dateTimePicker.Text;
						selectedPerson.izin_bit_tar = izin_bit_tar_dateTimePicker.Text;

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

				var selectedIzin = _context.izinler.Find(selectedIzinId);
				if (selectedIzin != null)
				{
					DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						_context.izinler.Remove(selectedIzin);
						_context.SaveChanges();

						MessageBox.Show("Başarıyla izin kaldırıldı", "Başarılı", MessageBoxButtons.OK);
						LoadData();
					}
				}
			}
		}

		private void ButtonReset_Click(object sender, EventArgs e)
		{
			pers_sicil_noTextBox.Text = "";

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
