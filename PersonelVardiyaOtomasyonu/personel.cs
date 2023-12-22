using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonelVardiyaOtomasyonu
{
    public partial class personel : Form
    {
        private SqlConnection connection;

        public personel()
        {
            InitializeComponent();
            connection = new SqlConnection(DatabaseManager.Instance.GetDBInfo());
			Loadpersonel();

		}



        private void Loadpersonel()
        {
            try
            {
                string query = "SELECT id,sicil_no,kadro_tipi,gorev_unvani,ad,soyad,kimlik_no,telefon,email,sifre FROM personel";

                using (SqlConnection con = new SqlConnection(DatabaseManager.Instance.GetDBInfo()))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        personelDataTable.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
				connection.Close();
			}
        }

        private void personelDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < personelDataTable.Rows.Count)
            {
                personelDataTable.ClearSelection();
                personelDataTable.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = personelDataTable.Rows[e.RowIndex];
               
                // Retrieve data for sicil_no
                string sicil_no = selectedRow.Cells["sicil_no"].Value?.ToString();
                // Populate corresponding TextBox
                sicil_noTextBox.Text = sicil_no;
                // Retrieve data for kadro_tipi
                string kadro_tipi = selectedRow.Cells["kadro_tipi"].Value?.ToString();
                // Populate corresponding TextBox
                kadro_tipicomboBox.Text = kadro_tipi;
                // Retrieve data for gorev_unvani
                string gorev_unvani = selectedRow.Cells["gorev_unvani"].Value?.ToString();
                // Populate corresponding TextBox
                gorev_unvaniTextBox.Text = gorev_unvani;
                // Retrieve data for ad
                string ad = selectedRow.Cells["ad"].Value?.ToString();
                // Populate corresponding TextBox
                adTextBox.Text = ad;
                // Retrieve data for soyad
                string soyad = selectedRow.Cells["soyad"].Value?.ToString();
                // Populate corresponding TextBox
                soyadTextBox.Text = soyad;
                // Retrieve data for kimlik_no
                string kimlik_no = selectedRow.Cells["kimlik_no"].Value?.ToString();
                // Populate corresponding TextBox
                kimlik_noTextBox.Text = kimlik_no;
                // Retrieve data for telefon
                string telefon = selectedRow.Cells["telefon"].Value?.ToString();
                // Populate corresponding TextBox
                telefonTextBox.Text = telefon;
                // Retrieve data for email
                string email = selectedRow.Cells["email"].Value?.ToString();
                // Populate corresponding TextBox
                emailTextBox.Text = email;
                // Retrieve data for sifre
                string sifre = selectedRow.Cells["sifre"].Value?.ToString();
                // Populate corresponding TextBox
                sifreTextBox.Text = sifre;
            }
        }

			
		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try	
			{

				string sicil_no = sicil_noTextBox.Text;
				string kadro_tipi = kadro_tipicomboBox.Text;
				string gorev_unvani = gorev_unvaniTextBox.Text;
				string ad = adTextBox.Text;
				string soyad = soyadTextBox.Text;
				string kimlik_no = kimlik_noTextBox.Text;
				string telefon = telefonTextBox.Text;
				string email = emailTextBox.Text;
				string sifre = sifreTextBox.Text;

				
				if (string.IsNullOrEmpty(sicil_no) || string.IsNullOrEmpty(kadro_tipi) || string.IsNullOrEmpty(gorev_unvani) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(kimlik_no) || string.IsNullOrEmpty(telefon) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string query = "INSERT INTO personel(sicil_no,kadro_tipi,gorev_unvani,ad,soyad,kimlik_no,telefon,email,sifre) VALUES(@sicil_no, @kadro_tipi, @gorev_unvani, @ad, @soyad, @kimlik_no, @telefon, @email, @sifre)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@sicil_no", sicil_no);
                    command.Parameters.AddWithValue("@kadro_tipi", kadro_tipi);
                    command.Parameters.AddWithValue("@gorev_unvani", gorev_unvani);
                    command.Parameters.AddWithValue("@ad", ad);
                    command.Parameters.AddWithValue("@soyad", soyad);
                    command.Parameters.AddWithValue("@kimlik_no", kimlik_no);
                    command.Parameters.AddWithValue("@telefon", telefon);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@sifre", sifre);

					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();

					MessageBox.Show("Yeni veri başarıyla eklendi.");
					Loadpersonel();
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
			if (personelDataTable.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = personelDataTable.SelectedRows[0];
				int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
					
				string sicil_no = sicil_noTextBox.Text;
				string kadro_tipi = kadro_tipicomboBox.Text;
				string gorev_unvani = gorev_unvaniTextBox.Text;
				string ad = adTextBox.Text;
				string soyad = soyadTextBox.Text;
				string kimlik_no = kimlik_noTextBox.Text;
				string telefon = telefonTextBox.Text;
				string email = emailTextBox.Text;
				string sifre = sifreTextBox.Text;

				try
				{
					string query = "UPDATE personel SET  sicil_no = @sicil_no, kadro_tipi = @kadro_tipi, gorev_unvani = @gorev_unvani, ad = @ad, soyad = @soyad, kimlik_no = @kimlik_no, telefon = @telefon, email = @email, sifre = @sifre WHERE id = @id";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@sicil_no", sicil_no);
                        command.Parameters.AddWithValue("@kadro_tipi", kadro_tipi);
                        command.Parameters.AddWithValue("@gorev_unvani", gorev_unvani);
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);
                        command.Parameters.AddWithValue("@kimlik_no", kimlik_no);
                        command.Parameters.AddWithValue("@telefon", telefon);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@sifre", sifre);

						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();

						MessageBox.Show("Veri başarıyla güncellendi.");
						Loadpersonel();
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
           
			DataGridViewRow selectedRow = personelDataTable.SelectedRows.Count > 0 ? personelDataTable.SelectedRows[0] : null;

			if (selectedRow != null)
			{
				int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

				if (MessageBox.Show("Seçili veriyi silmek istediğinizden emin misiniz?", "Veri Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					try
					{
						string query = "DELETE FROM personel WHERE id= @id";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@id", id);
						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();
						MessageBox.Show("Veri başarıyla silindi.");
						Loadpersonel();
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
				
			sicil_noTextBox.Text = string.Empty;
			kadro_tipicomboBox.Text = string.Empty;
			gorev_unvaniTextBox.Text = string.Empty;
			adTextBox.Text = string.Empty;
			soyadTextBox.Text = string.Empty;
			kimlik_noTextBox.Text = string.Empty;
			telefonTextBox.Text = string.Empty;
			emailTextBox.Text = string.Empty;
			sifreTextBox.Text = string.Empty;
			personelDataTable.ClearSelection();
		}
    }
}
