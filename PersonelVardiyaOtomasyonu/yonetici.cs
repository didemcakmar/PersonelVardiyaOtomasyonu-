using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelVardiyaOtomasyonu
{
    public partial class yonetici : Form
    {
        private SqlConnection connection;

        public yonetici()
        {
            InitializeComponent();
            connection = new SqlConnection(DatabaseManager.Instance.GetDBInfo());
			Loadyonetici();

		}

        private void Loadyonetici()
        {
            try
            {
                string query = "SELECT yon_id,yon_ad_soyad,yon_mail,yon_sifre FROM yonetici";

                using (SqlConnection con = new SqlConnection(DatabaseManager.Instance.GetDBInfo()))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        yoneticiDataTable.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void yoneticiDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < yoneticiDataTable.Rows.Count)
            {
                yoneticiDataTable.ClearSelection();
                yoneticiDataTable.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = yoneticiDataTable.Rows[e.RowIndex];

                // Retrieve data for yon_ad_soyad
                string yon_ad_soyad = selectedRow.Cells["Yönetici Ad Soyad"].Value?.ToString();
                // Populate corresponding TextBox
                yon_ad_soyadTextBox.Text = yon_ad_soyad;
                // Retrieve data for yon_mail
                string yon_mail = selectedRow.Cells["Yönetici Mail"].Value?.ToString();
                // Populate corresponding TextBox
                yon_mailTextBox.Text = yon_mail;
                // Retrieve data for yon_sifre
                string yon_sifre = selectedRow.Cells["Yönetici Şifre"].Value?.ToString();
                // Populate corresponding TextBox
                yon_sifreTextBox.Text = yon_sifre;
            }
        }

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			try
			{
				string Yoneticiadsoyad = yon_ad_soyadTextBox.Text;
				string YoneticiMail = yon_mailTextBox.Text;
				string YoneticiŞifre = yon_sifreTextBox.Text;

				if (string.IsNullOrEmpty(Yoneticiadsoyad) || string.IsNullOrEmpty(YoneticiMail) || string.IsNullOrEmpty(YoneticiŞifre))
				{
					MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}


				string query = "INSERT INTO yonetici(Yoneticiadsoyad,YoneticiMail,YoneticiŞifre) VALUES(@Yoneticiadsoyad, @YoneticiMail, @)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{

					command.Parameters.AddWithValue("@Yoneticiadsoyad", Yoneticiadsoyad);
                    command.Parameters.AddWithValue("@YoneticiMail", YoneticiMail);
                    command.Parameters.AddWithValue("@YoneticiŞifre", YoneticiŞifre);

					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();

					MessageBox.Show("Yeni veri başarıyla eklendi.");
					Loadyonetici();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message);
			}
		}
		public void ButtonGuncelle_Click(object sender, EventArgs e)
		{
			if (yoneticiDataTable.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = yoneticiDataTable.SelectedRows[0];
				int yon_id = Convert.ToInt32(selectedRow.Cells["yon_id"].Value);

				string yon_ad_soyad = yon_ad_soyadTextBox.Text;
				string yon_mail = yon_mailTextBox.Text;
				string yon_sifre = yon_sifreTextBox.Text;

				try
				{
					string query = "UPDATE yonetici SET yon_ad_soyad = @yon_ad_soyad, yon_mail = @yon_mail, yon_sifre = @yon_sifre WHERE yon_id = @yon_id";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
                        command.Parameters.AddWithValue("@yon_id", yon_id);
                        command.Parameters.AddWithValue("@yon_ad_soyad", yon_ad_soyad);
                        command.Parameters.AddWithValue("@yon_mail", yon_mail);
                        command.Parameters.AddWithValue("@yon_sifre", yon_sifre);

						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();

						MessageBox.Show("Veri başarıyla güncellendi.");
						Loadyonetici();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata oluştu: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Güncellenecek bir veri seçin.");
			}
		}
		public void ButtonSil_Click(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = yoneticiDataTable.SelectedRows.Count > 0 ? yoneticiDataTable.SelectedRows[0] : null;

			if (selectedRow != null)
			{
				int yon_id = Convert.ToInt32(selectedRow.Cells["yon_id"].Value);

				if (MessageBox.Show("Seçili veriyi silmek istediğinizden emin misiniz?", "Veri Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					try
					{
						string query = "DELETE FROM yonetici WHERE yon_id= @yon_id";
						SqlCommand command = new SqlCommand(query, connection);
						command.Parameters.AddWithValue("@yon_id", yon_id);
						connection.Open();
						command.ExecuteNonQuery();
						connection.Close();
						MessageBox.Show("Veri başarıyla silindi.");
						Loadyonetici();
					}
					catch (Exception ex)
					{
						MessageBox.Show("Hata oluştu: " + ex.Message);
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

				yon_ad_soyadTextBox.Text = string.Empty;
				yon_mailTextBox.Text = string.Empty;
				yon_sifreTextBox.Text = string.Empty;
				yoneticiDataTable.ClearSelection();
			}

        private void yon_sifre_Click(object sender, EventArgs e)
        {

        }
    }
}
