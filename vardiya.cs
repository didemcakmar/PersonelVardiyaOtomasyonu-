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
		}

		private void LoadData()
		{
			var vardiya = _context.vardiya_kayit.ToList();
			_dataTable = ToDataTable(vardiya);
			vardiyaDataTable.DataSource = _dataTable;
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

		private void vardiyaDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < vardiyaDataTable.Rows.Count)
			{
				vardiyaDataTable.ClearSelection();
				vardiyaDataTable.Rows[e.RowIndex].Selected = true;

				DataGridViewRow selectedRow = vardiyaDataTable.Rows[e.RowIndex];

				string pers_sicil = selectedRow.Cells["Sicil"].Value?.ToString();
				sicil_no_TextBox.Text = pers_sicil;

				string vard_bas_saat = selectedRow.Cells["Gün"].Value?.ToString();
				gun_TextBox.Text = vard_bas_saat;

				string vard_bit_saat = selectedRow.Cells["Saat"].Value?.ToString();
				saati_TextBox.Text = vard_bit_saat;

				string vard_gun = selectedRow.Cells["Bölge"].Value?.ToString();
				lokasyon_comboBox.Text = vard_gun;




			}
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	if (string.IsNullOrWhiteSpace(sicil_no_TextBox.Text) || string.IsNullOrWhiteSpace(baslangic_saati_TextBox.Text) || string.IsNullOrWhiteSpace(bitis_saati_TextBox.Text) || string.IsNullOrWhiteSpace(gun_TextBox.Text) || string.IsNullOrWhiteSpace(lokasyon_comboBox.Text))
			//	{
			//		MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//		return;
			//	}

			//	// Parse input values
			//	if (int.TryParse(sicil_no_TextBox.Text, out int sicil) &&
			//		int.TryParse(baslangic_saati_TextBox.Text, out int basSaat) &&
			//		int.TryParse(bitis_saati_TextBox.Text, out int bitSaat))
			//	{
			//		// Create new izin entity
			//		var vardiya = new Tablolar.Vardiya
			//		{

			//			vard_bas_saat = basSaat,
			//			vard_bit_saat = bitSaat,
			//			vard_gun = gun_TextBox.Text,
			//			vard_konum = lokasyon_comboBox.Text,

			//		};

			//		// Add izin to the context
			//		_context.personel_vardiya.Add(vardiya);

			//		// Save changes to the database
			//		_context.SaveChanges();

			//		MessageBox.Show("Başarıyla vardiya eklendi", "Başarılı", MessageBoxButtons.OK);


			//		LoadData();
			//	}
			//	else
			//	{
			//		MessageBox.Show("Geçerli bir sicil numarası ve izin saatleri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show($"Hata oluştu: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			//if (vardiyaDataTable.SelectedRows.Count > 0)
			//{
			//	int selectedRowIndex = vardiyaDataTable.SelectedRows[0].Index;
			//	int selectedId = Convert.ToInt32(vardiyaDataTable.Rows[selectedRowIndex].Cells["id"].Value);

			//	try
			//	{
			//		var selectedVardiya = _context.personel_vardiya.FirstOrDefault(v => v.id == selectedId);

			//		if (selectedVardiya != null)
			//		{
			//			// Update vardiya entity
			//			if (int.TryParse(sicil_no_TextBox.Text, out int sicil))
			//			{

			//			}
			//			else
			//			{
			//				MessageBox.Show("Geçerli bir sicil numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//				return;
			//			}

			//			selectedVardiya.vard_bas_saat = int.Parse(baslangic_saati_TextBox.Text);
			//			selectedVardiya.vard_bit_saat = int.Parse(bitis_saati_TextBox.Text);
			//			selectedVardiya.vard_gun = gun_TextBox.Text;
			//			selectedVardiya.vard_konum = lokasyon_comboBox.Text;

			//			// Save changes to the database
			//			_context.SaveChanges();

			//			MessageBox.Show($"Başarıyla Vardiya Güncellendi", "Başarılı", MessageBoxButtons.OK);

			//			LoadData();
			//		}
			//	}
			//	catch (Exception ex)
			//	{
			//		MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
		}


		private void ButtonSil_Click(object sender, EventArgs e)
		{
			//if (vardiyaDataTable.SelectedRows.Count > 0)
			//{
			//	DialogResult result = MessageBox.Show("Seçili vardiyayı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			//	if (result == DialogResult.Yes)
			//	{
			//		int selectedRowIndex = vardiyaDataTable.SelectedRows[0].Index;
			//		int selectedId = Convert.ToInt32(vardiyaDataTable.Rows[selectedRowIndex].Cells["id"].Value);

			//		try
			//		{
			//			var selectedVardiya = _context.personel_vardiya.FirstOrDefault(v => v.id == selectedId);

			//			if (selectedVardiya != null)
			//			{
			//				// Remove vardiya from the context
			//				_context.personel_vardiya.Remove(selectedVardiya);

			//				// Save changes to the database
			//				_context.SaveChanges();

			//				MessageBox.Show($"Başarıyla Vardiya Silindi", "Başarılı", MessageBoxButtons.OK);

			//				LoadData();
			//			}
			//		}
			//		catch (Exception ex)
			//		{
			//			MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//		}
			//	}
			//}
			//else
			//{
			//	MessageBox.Show("Lütfen silinecek bir vardiya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}


		private void ButtonReset_Click(object sender, EventArgs e)
		{
			sicil_no_TextBox.Clear();
			saati_TextBox.Clear();
			gun_TextBox.Clear();
			vardiyaDataTable.ClearSelection();


		}

		private void otomasyon_button_Click(object sender, EventArgs e)
		{
			otomasyon mainForm = new otomasyon();
			mainForm.Show();
		}
	}
}
