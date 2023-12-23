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

namespace PersonelVardiyaOtomasyonu
{
	public partial class yonetici : Form
	{
		private readonly DatabaseManager _context;
		private DataTable _dataTable;
		public yonetici()
		{
			InitializeComponent();
			_context = new DatabaseManager();
			_dataTable = new DataTable();
			LoadData();
		}

		private void LoadData()
		{
			var yonetici = _context.yonetici.ToList();
			_dataTable = ToDataTable(yonetici);
			yoneticiDataTable.DataSource = _dataTable;
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

		private void yoneticiDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < yoneticiDataTable.Rows.Count)
			{
				yoneticiDataTable.ClearSelection();
				yoneticiDataTable.Rows[e.RowIndex].Selected = true;

				DataGridViewRow selectedRow = yoneticiDataTable.Rows[e.RowIndex];

				string yon_ad_soyad = selectedRow.Cells["yon_ad_soyad"].Value?.ToString();
				ad_soyad_TextBox.Text = yon_ad_soyad;

				string yon_mail = selectedRow.Cells["yon_mail"].Value?.ToString();
				email_TextBox.Text = yon_mail;

				string yon_sifre = selectedRow.Cells["yon_sifre"].Value?.ToString();
				sifre_TextBox.Text = yon_sifre;


			}
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(ad_soyad_TextBox.Text) || string.IsNullOrWhiteSpace(email_TextBox.Text) || string.IsNullOrWhiteSpace(sifre_TextBox.Text))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}


					var yonetici = new Tablolar.Yonetici
					{
						yon_ad_soyad = ad_soyad_TextBox.Text,
						yon_mail = email_TextBox.Text,
						yon_sifre = sifre_TextBox.Text,


					};

				
					_context.yonetici.Add(yonetici);


					_context.SaveChanges();

					MessageBox.Show("Başarıyla yönetici eklendi", "Başarılı", MessageBoxButtons.OK);


					LoadData();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata oluştu: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			if (yoneticiDataTable.SelectedRows.Count > 0)
			{
				int selectedRowIndex = yoneticiDataTable.SelectedRows[0].Index;
				int selectedId = Convert.ToInt32(yoneticiDataTable.Rows[selectedRowIndex].Cells["id"].Value);

				try
				{
					var selectedYonetici = _context.yonetici.FirstOrDefault(y => y.id == selectedId);

					if (selectedYonetici != null)
					{


						selectedYonetici.yon_ad_soyad = ad_soyad_TextBox.Text;
						selectedYonetici.yon_mail = email_TextBox.Text;
						selectedYonetici.yon_sifre = sifre_TextBox.Text;


						// Save changes to the database
						_context.SaveChanges();

						MessageBox.Show($"Başarıyla Yönetici Güncellendi", "Başarılı", MessageBoxButtons.OK);

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
			if (yoneticiDataTable.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Seçili yöneticiyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.Yes)
				{
					int selectedRowIndex = yoneticiDataTable.SelectedRows[0].Index;
					int selectedId = Convert.ToInt32(yoneticiDataTable.Rows[selectedRowIndex].Cells["id"].Value);

					try
					{
						var selectedYonetici = _context.yonetici.FirstOrDefault(y => y.id == selectedId);

						if (selectedYonetici != null)
						{
							
							_context.yonetici.Remove(selectedYonetici);

							
							_context.SaveChanges();

							MessageBox.Show($"Başarıyla Yönetici Silindi", "Başarılı", MessageBoxButtons.OK);

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
				MessageBox.Show("Lütfen silinecek bir yönetici seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ButtonReset_Click(object sender, EventArgs e)
		{
			ad_soyad_TextBox.Clear();
			email_TextBox.Clear();
			sifre_TextBox.Clear();
			yoneticiDataTable.ClearSelection();
		}


	}
}
