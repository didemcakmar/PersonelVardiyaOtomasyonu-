using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelVardiyaOtomasyonu
{
    public partial class izin : Form
    {
        private SqlConnection connection;

        public izin()
        {
            InitializeComponent();
            connection = new SqlConnection(DatabaseManager.Instance.GetDBInfo());
			Loadizin();
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

		private void Loadizin()
        {
            try
            {
                string query = "SELECT izin_id,pers_sicil,izin_bas_saat,izin_bit_saat,izin_bas_tar,izin_bit_tar FROM izin";

                using (SqlConnection con = new SqlConnection(DatabaseManager.Instance.GetDBInfo()))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        izinDataTable.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void izinDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < izinDataTable.Rows.Count)
            {
                izinDataTable.ClearSelection();
                izinDataTable.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = izinDataTable.Rows[e.RowIndex];

                // Retrieve data for pers_sicil
                string pers_sicil = selectedRow.Cells["pers_sicil"].Value?.ToString();
                // Populate corresponding TextBox
                pers_sicilcomboBox.Text = pers_sicil;
                // Retrieve data for izin_bas_saat
                string izin_bas_saat = selectedRow.Cells["izin_bas_saat"].Value?.ToString();
                // Populate corresponding TextBox
                izin_bas_saatTextBox.Text = izin_bas_saat;
                // Retrieve data for izin_bit_saat
                string izin_bit_saat = selectedRow.Cells["izin_bit_saat"].Value?.ToString();
                // Populate corresponding TextBox
                izin_bit_saatTextBox.Text = izin_bit_saat;
                // Retrieve data for izin_bas_tar
                string izin_bas_tar = selectedRow.Cells["izin_bas_tar"].Value?.ToString();
                // Populate corresponding TextBox
                izin_bas_tardateTimePicker.Text = izin_bas_tar;
                // Retrieve data for izin_bit_tar
                string izin_bit_tar = selectedRow.Cells["izin_bit_tar"].Value?.ToString();
				// Populate corresponding TextBox
				izin_bit_tardateTimePicker.Text = izin_bit_tar;
            }
        }

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try
			{
					
				string pers_sicil = pers_sicilcomboBox.Text;
				string izin_bas_saat = izin_bas_saatTextBox.Text;
				string izin_bit_saat = izin_bit_saatTextBox.Text;
				DateTime izin_bas_tar = izin_bas_tardateTimePicker.Value;
				DateTime izin_bit_tar = izin_bit_tardateTimePicker.Value;

				if (string.IsNullOrEmpty(pers_sicil) ||
					string.IsNullOrEmpty(izin_bas_saat) ||
					string.IsNullOrEmpty(izin_bit_saat) ||
					izin_bas_tar == DateTime.MinValue ||
					izin_bit_tar == DateTime.MinValue)
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				string query = "INSERT INTO izin(pers_sicil,izin_bas_saat,izin_bit_saat,izin_bas_tar,izin_bit_tar) VALUES(@pers_sicil, @izin_bas_saat, @izin_bit_saat, @izin_bas_tar, @izin_bit_tar)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
                      
					command.Parameters.AddWithValue("@pers_sicil", pers_sicil);
					command.Parameters.AddWithValue("@izin_bas_saat", izin_bas_saat);
					command.Parameters.AddWithValue("@izin_bit_saat", izin_bit_saat);
					command.Parameters.AddWithValue("@izin_bas_tar", izin_bas_tar);
					command.Parameters.AddWithValue("@izin_bit_tar", izin_bit_tar);

					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();

					MessageBox.Show("Yeni veri başarıyla eklendi.");
					Loadizin();
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
			if (izinDataTable.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = izinDataTable.SelectedRows[0];
				int izin_id = Convert.ToInt32(selectedRow.Cells["izin_id"].Value);
				string pers_sicil = pers_sicilcomboBox.Text;
				string izin_bas_saat = izin_bas_saatTextBox.Text;
				string izin_bit_saat = izin_bit_saatTextBox.Text;
				DateTime izin_bas_tar = izin_bas_tardateTimePicker.Value;
				DateTime izin_bit_tar = izin_bit_tardateTimePicker.Value;	

				try
				{
					string query = "UPDATE izin SET pers_sicil = @pers_sicil, izin_bas_saat = @izin_bas_saat, izin_bit_saat = @izin_bit_saat, izin_bas_tar = @izin_bas_tar, izin_bit_tar = @izin_bit_tar WHERE izin_id = @izin_id";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
                        command.Parameters.AddWithValue("@izin_id", izin_id);
                        command.Parameters.AddWithValue("@pers_sicil", pers_sicil);
                        command.Parameters.AddWithValue("@izin_bas_saat", izin_bas_saat);
                        command.Parameters.AddWithValue("@izin_bit_saat", izin_bit_saat);
                        command.Parameters.AddWithValue("@izin_bas_tar", izin_bas_tar);
                        command.Parameters.AddWithValue("@izin_bit_tar", izin_bit_tar);

						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();

						MessageBox.Show("Veri başarıyla güncellendi.");
						Loadizin();
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
			DataGridViewRow selectedRow = izinDataTable.SelectedRows.Count > 0 ? izinDataTable.SelectedRows[0] : null;

			if (selectedRow != null)
			{
				int izin_id = Convert.ToInt32(selectedRow.Cells["izin_id"].Value);

				if (MessageBox.Show("Seçili veriyi silmek istediğinizden emin misiniz?", "Veri Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					try
					{
						string query = "DELETE FROM izin WHERE izin_id= @izin_id";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@izin_id", izin_id);
						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();
						MessageBox.Show("Veri başarıyla silindi.");
						Loadizin();
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
				izin_bas_saatTextBox.Text = string.Empty;
				izin_bit_saatTextBox.Text = string.Empty;
				izin_bas_tardateTimePicker.Value = DateTime.Now;
				izin_bit_tardateTimePicker.Value = DateTime.Now;
				izinDataTable.ClearSelection();
			}
    }
}
