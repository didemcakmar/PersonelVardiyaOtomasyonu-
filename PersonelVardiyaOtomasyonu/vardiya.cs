using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelVardiyaOtomasyonu
{
	public partial class vardiya : Form
	{
		private SqlConnection connection;

		public vardiya()
		{
			InitializeComponent();
			connection = new SqlConnection(DatabaseManager.Instance.GetDBInfo());
			Loadvardiya();
			LoadSicilNoToComboBox();

		}

		private void LoadSicilNoToComboBox()
		{
			try
			{
				// ComboBox'ı temizle
				pers_sicilcomboBox.Items.Clear();

				// Veritabanından sicil_no'ları al
				using (SqlConnection connection = new SqlConnection(DatabaseManager.Instance.GetDBInfo()))
				{
					connection.Open();

					string sicilNoSorgu = "SELECT sicil_no FROM personel";

					using (SqlCommand command = new SqlCommand(sicilNoSorgu, connection))
					using (SqlDataReader reader = command.ExecuteReader())
					{
						// Sicil_no'ları ComboBox'a ekle
						while (reader.Read())
						{
							string sicilNo = reader["sicil_no"].ToString();
							pers_sicilcomboBox.Items.Add(sicilNo);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
			}
		}

		private void Loadvardiya()
		{
			try
			{
				string query = "SELECT vard_id,pers_sicil,vard_bas_saat,vard_bit_saat,vard_gun,vard_konum FROM vardiya";

				using (SqlConnection con = new SqlConnection(DatabaseManager.Instance.GetDBInfo()))
				{
					con.Open();

					using (SqlCommand command = new SqlCommand(query, con))
					{
						SqlDataAdapter adapter = new SqlDataAdapter(command);
						DataTable dataTable = new DataTable();
						adapter.Fill(dataTable);

						vardiyaDataTable.DataSource = dataTable;

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
			}
		}

		private void vardiyaDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < vardiyaDataTable.Rows.Count)
			{
				vardiyaDataTable.ClearSelection();
				vardiyaDataTable.Rows[e.RowIndex].Selected = true;

				DataGridViewRow selectedRow = vardiyaDataTable.Rows[e.RowIndex];

				// Retrieve data for pers_sicil
				string pers_sicil = selectedRow.Cells["Personel Sicil No"].Value?.ToString();
				// Populate corresponding TextBox
				pers_sicilcomboBox.Text = pers_sicil;
				// Retrieve data for vard_bas_saat
				string vard_bas_saat = selectedRow.Cells["Başlama Saati"].Value?.ToString();
				// Populate corresponding TextBox
				vard_bas_saatcomboBox.Text = vard_bas_saat;
				// Retrieve data for vard_bit_saat
				string vard_bit_saat = selectedRow.Cells["Bitiş Saati"].Value?.ToString();
				// Populate corresponding TextBox
				vard_bit_saatcomboBox.Text = vard_bit_saat;
				// Retrieve data for vard_gun
				string vard_gun = selectedRow.Cells["Vardiya Günü"].Value?.ToString();
				// Populate corresponding TextBox
				vard_gunTextBox.Text = vard_gun;
				// Retrieve data for vard_konum
				string vard_konum = selectedRow.Cells["Vardiya Konumu"].Value?.ToString();
				// Populate corresponding TextBox
				vard_konumcomboBox.Text = vard_konum;
			}
		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try
			{
					
				
				string pers_sicil = pers_sicilcomboBox.Text;
				string vard_bas_saat = vard_bas_saatcomboBox.Text;
				string vard_bit_saat = vard_bit_saatcomboBox.Text;
				string vard_gun = vard_gunTextBox.Text;
				string vard_konum = vard_konumcomboBox.Text;

				if (string.IsNullOrEmpty(pers_sicil) || string.IsNullOrEmpty(vard_bas_saat) || string.IsNullOrEmpty(vard_bit_saat) || string.IsNullOrEmpty(vard_gun) || string.IsNullOrEmpty(vard_konum))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string query = "INSERT INTO vardiya(pers_sicil,vard_bas_saat,vard_bit_saat,vard_gun,vard_konum) VALUES(@pers_sicil, @vard_bas_saat, @vard_bit_saat, @vard_gun, @vard_konum)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					 
					command.Parameters.AddWithValue("@pers_sicil", pers_sicil);
					command.Parameters.AddWithValue("@vard_bas_saat", vard_bas_saat);
					command.Parameters.AddWithValue("@vard_bit_saat", vard_bit_saat);
					command.Parameters.AddWithValue("@vard_gun", vard_gun);
					command.Parameters.AddWithValue("@vard_konum", vard_konum);

					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();

					MessageBox.Show("Yeni veri başarıyla eklendi.");
					Loadvardiya();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
				connection.Close();
			}
		}
		public void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			if (vardiyaDataTable.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = vardiyaDataTable.SelectedRows[0];
				int vard_id = Convert.ToInt32(selectedRow.Cells["vard_id"].Value);
				
				string pers_sicil = pers_sicilcomboBox.Text;
				string vard_bas_saat = vard_bas_saatcomboBox.Text;
				string vard_bit_saat = vard_bit_saatcomboBox.Text;
				string vard_gun = vard_gunTextBox.Text;
				string vard_konum = vard_konumcomboBox.Text;

				try
				{
					Console.Write(vard_id);
					string query = "UPDATE vardiya SET pers_sicil = @pers_sicil, vard_bas_saat = @vard_bas_saat, vard_bit_saat = @vard_bit_saat, vard_gun = @vard_gun, vard_konum = @vard_konum WHERE vard_id = @vard_id";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@vard_id", vard_id);
						command.Parameters.AddWithValue("@pers_sicil", pers_sicil);
						command.Parameters.AddWithValue("@vard_bas_saat", vard_bas_saat);
						command.Parameters.AddWithValue("@vard_bit_saat", vard_bit_saat);
						command.Parameters.AddWithValue("@vard_gun", vard_gun);
						command.Parameters.AddWithValue("@vard_konum", vard_konum);

						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();

						MessageBox.Show("Veri başarıyla güncellendi.");
						Loadvardiya();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata oluştu: " + ex.Message);
					connection.Close();
				}
			}
			else
			{
				MessageBox.Show("Güncellenecek bir veri seçin.");
			}
		}
		public void ButtonSil_Click(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = vardiyaDataTable.SelectedRows.Count > 0 ? vardiyaDataTable.SelectedRows[0] : null;

			if (selectedRow != null)
			{
				int vard_id = Convert.ToInt32(selectedRow.Cells["vard_id"].Value);

				if (MessageBox.Show("Seçili veriyi silmek istediğinizden emin misiniz?", "Veri Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					try
					{
						string query = "DELETE FROM vardiya WHERE vard_id= @vard_id";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@vard_id", vard_id);
						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();
						MessageBox.Show("Veri başarıyla silindi.");
						Loadvardiya();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Hata oluştu: " + ex.Message);
						connection.Close();
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		private void ButtonReset_Click(object sender, EventArgs e)
			{

				pers_sicilcomboBox.Text = string.Empty;
				vard_bas_saatcomboBox.Text = string.Empty;
				vard_bit_saatcomboBox.Text = string.Empty;
				vard_gunTextBox.Text = string.Empty;
				vard_konumcomboBox.Text = string.Empty;
				vardiyaDataTable.ClearSelection();
			}



	}
}
