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
using PersonelVardiyaOtomasyonu.Tablolar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelVardiyaOtomasyonu
{
	public partial class personel : Form
	{
		private readonly DatabaseManager _context;
		private DataTable _dataTable;

		public personel()
		{
			InitializeComponent();
			_context = new DatabaseManager();
			_dataTable = new DataTable();
			LoadData();

		}


		private void LoadData()
		{
			var Personel = _context.personel.ToList();
			_dataTable = ToDataTable(Personel);
			personelDataTable.DataSource = _dataTable;

		}

		//veri listeleme
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



		private void personelDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < personelDataTable.Rows.Count)
			{
				personelDataTable.ClearSelection();
				personelDataTable.Rows[e.RowIndex].Selected = true;

				DataGridViewRow selectedRow = personelDataTable.Rows[e.RowIndex];

				string ad = selectedRow.Cells["ad"].Value?.ToString();
				adTextBox.Text = ad;

				string soyad = selectedRow.Cells["soyad"].Value?.ToString();
				soyadTextBox.Text = soyad;

				string sicil_no = selectedRow.Cells["sicil_no"].Value?.ToString();
				sicil_noTextBox.Text = sicil_no;

				string kadro_tipi = selectedRow.Cells["kadro_tipi"].Value?.ToString();
				kadro_tipicomboBox.Text = kadro_tipi;

				string gorev_unvani = selectedRow.Cells["gorev_unvani"].Value?.ToString();
				gorev_unvaniTextBox.Text = gorev_unvani;

				string email = selectedRow.Cells["email"].Value?.ToString();
				emailTextBox.Text = email;

				string sifre = selectedRow.Cells["sifre"].Value?.ToString();
				sifreTextBox.Text = sifre;

				string telefon = selectedRow.Cells["telefon"].Value?.ToString();
				telefonTextBox.Text = telefon;

				string kimlik_no = selectedRow.Cells["kimlik_no"].Value?.ToString();
				kimlik_noTextBox.Text = kimlik_no;

				string izin_günü_1 = selectedRow.Cells["izin_günü_1"].Value?.ToString();
				izin_gün_1_comboBox.Text = izin_günü_1;

				string izin_günü_2 = selectedRow.Cells["izin_günü_2"].Value?.ToString();
				izin_gün_2_comboBox.Text = izin_günü_2;


			}
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{

			try
			{

				if (string.IsNullOrWhiteSpace(adTextBox.Text) || string.IsNullOrWhiteSpace(soyadTextBox.Text) || string.IsNullOrWhiteSpace(sicil_noTextBox.Text) || string.IsNullOrWhiteSpace(kadro_tipicomboBox.Text) || string.IsNullOrWhiteSpace(gorev_unvaniTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(sifreTextBox.Text) || string.IsNullOrWhiteSpace(telefonTextBox.Text) || string.IsNullOrWhiteSpace(kimlik_noTextBox.Text))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (int.TryParse(sicil_noTextBox.Text, out int sicil))
				{
					var personel = new Personel
					{


						sicil_no = sicil,
						ad = adTextBox.Text,
						soyad = soyadTextBox.Text,
						email = emailTextBox.Text,
						telefon = telefonTextBox.Text,
						kimlik_no = kimlik_noTextBox.Text,

						kadro_tipi = kadro_tipicomboBox.Text,
						gorev_unvani = gorev_unvaniTextBox.Text,
						sifre = sifreTextBox.Text,
						izin_günü_1 = izin_gün_1_comboBox.Text,
						izin_günü_2 = izin_gün_2_comboBox.Text,


					};

					_context.personel.Add(personel);
					_context.SaveChanges();
				}
				else
				{
					MessageBox.Show("Geçerli bir sicil numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}




				MessageBox.Show("Başarıyla personel eklendi", "Başarılı", MessageBoxButtons.OK);

				adTextBox.Text = "";
				soyadTextBox.Text = "";
				sicil_noTextBox.Text = "";
				kadro_tipicomboBox.Text = "";
				gorev_unvaniTextBox.Text = "";
				emailTextBox.Text = "";
				sifreTextBox.Text = "";
				telefonTextBox.Text = "";
				kimlik_noTextBox.Text = "";


				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			if (personelDataTable.SelectedRows.Count > 0)
			{
				int selectedRowIndex = personelDataTable.SelectedRows[0].Index;
				int selectedId = Convert.ToInt32(personelDataTable.Rows[selectedRowIndex].Cells["id"].Value);

				try
				{

					var selectedPerson = _context.personel.FirstOrDefault(p => p.id == selectedId);


					if (selectedPerson != null)
					{
						if (int.TryParse(sicil_noTextBox.Text, out int sicil))
						{
							selectedPerson.sicil_no = sicil;
						}
						else
						{
							MessageBox.Show("Geçerli bir sicil numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}


						selectedPerson.ad = adTextBox.Text;
						selectedPerson.soyad = soyadTextBox.Text;
						selectedPerson.kadro_tipi = kadro_tipicomboBox.Text;
						selectedPerson.gorev_unvani = gorev_unvaniTextBox.Text;
						selectedPerson.email = emailTextBox.Text;
						selectedPerson.sifre = sifreTextBox.Text;
						selectedPerson.telefon = telefonTextBox.Text;
						selectedPerson.kimlik_no = kimlik_noTextBox.Text;

						_context.SaveChanges();

						MessageBox.Show($"Başarıyla Personel Güncellendi", "Başarılı", MessageBoxButtons.OK);

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
			if (personelDataTable.SelectedRows.Count > 0)
			{
				int selectedRowIndex = personelDataTable.SelectedRows[0].Index;
				int selectedPersonId = Convert.ToInt32(personelDataTable.Rows[selectedRowIndex].Cells["id"].Value);

				var selectedPerson = _context.personel.Find(selectedPersonId);
				if (selectedPerson != null)
				{
					// Silme işlemi öncesi onay al
					DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						_context.personel.Remove(selectedPerson);
						_context.SaveChanges();

						MessageBox.Show("Başarıyla personel kaldırıldı", "Başarılı", MessageBoxButtons.OK);
						LoadData();
					}
				}
			}
		}


		private void ButtonReset_Click(object sender, EventArgs e)
		{
			adTextBox.Clear();
			soyadTextBox.Clear();
			sicil_noTextBox.Clear();
			kadro_tipicomboBox.Text = "";
			gorev_unvaniTextBox.Clear();
			emailTextBox.Clear();
			sifreTextBox.Clear();
			telefonTextBox.Clear();
			kimlik_noTextBox.Clear();
			personelDataTable.ClearSelection();
		}

		private void personel_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void izin_gün_1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
