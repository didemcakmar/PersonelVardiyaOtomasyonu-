using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PersonelVardiyaOtomasyonu
{
	

	public partial class giris : Form
	{
		private SqlConnection connection;

		public giris()
		{
			InitializeComponent();

			connection = new SqlConnection(DatabaseManager.Instance.GetDBInfo());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string email = emailtxtbox.Text;
			string sifre = sifretxtbox.Text;



			using (SqlConnection con = new SqlConnection(DatabaseManager.Instance.GetDBInfo()))
			{
				con.Open();
		
				string personelQuery = "SELECT id, ad, soyad, kimlik_no, kadro_tipi, gorev_unvani, sicil_no, telefon, email " +
										"FROM personel WHERE email = @email AND sifre = @sifre";

				using (SqlCommand personelCommand = new SqlCommand(personelQuery, con))
				{ 
					personelCommand.Parameters.AddWithValue("@email", email);
					personelCommand.Parameters.AddWithValue("@sifre", sifre);

					using (SqlDataReader personelReader = personelCommand.ExecuteReader())
					{
						if (personelReader.Read())
						{
							
							string id = personelReader["id"].ToString();
							string ad = personelReader["ad"].ToString();
							string soyad = personelReader["soyad"].ToString();
							string kimlik_no = personelReader["kimlik_no"].ToString();
							string kadro_tipi = personelReader["kadro_tipi"].ToString();
							string gorev_unvani = personelReader["gorev_unvani"].ToString();
							string sicil_no = personelReader["sicil_no"].ToString();
							string telefon = personelReader["telefon"].ToString();


							
							LoginEventsPersonel.ad = ad;
							LoginEventsPersonel.soyad = soyad;
							LoginEventsPersonel.kimlik_no = kimlik_no;
							LoginEventsPersonel.kadro_tipi = kadro_tipi;
							LoginEventsPersonel.gorev_unvani = gorev_unvani;
							LoginEventsPersonel.sicil_no = sicil_no;
							LoginEventsPersonel.telefon = telefon;

							con.Close();

							con.Open();
							string vardiyaQuery = "SELECT vard_id,pers_sicil,vard_bas_saat,vard_bit_saat,vard_gun,vard_konum FROM Vardiya WHERE pers_sicil = @pers_sicil";

							using (SqlCommand vardiyaCommand = new SqlCommand(vardiyaQuery, con))
							{
								vardiyaCommand.Parameters.AddWithValue("@pers_sicil", sicil_no);

								using (SqlDataReader vardiyaReader = vardiyaCommand.ExecuteReader())
								{
									if (vardiyaReader.Read())
									{
										string vard_id = vardiyaReader["vard_id"].ToString();
										string pers_sicil = vardiyaReader["pers_sicil"].ToString();
										string vard_bas_saat = vardiyaReader["vard_bas_saat"].ToString();
										string vard_bit_saat = vardiyaReader["vard_bit_saat"].ToString();
										string vard_gun = vardiyaReader["vard_gun"].ToString();
										string vard_konum = vardiyaReader["vard_konum"].ToString();

										Vardiya.vard_id = vard_id;
										Vardiya.pers_sicil = pers_sicil;
										Vardiya.vard_bas_saat = vard_bas_saat;
										Vardiya.vard_bit_saat = vard_bit_saat;
										Vardiya.vard_gun = vard_gun;
										Vardiya.vard_konum = vard_konum;
									}
									else
									{
										string vard_id = "";
										string pers_sicil = "";
										string vard_bas_saat = "";
										string vard_bit_saat = "";
										string vard_gun = "";
										string vard_konum = "";

										Vardiya.vard_id = vard_id;
										Vardiya.pers_sicil = pers_sicil;
										Vardiya.vard_bas_saat = vard_bas_saat;
										Vardiya.vard_bit_saat = vard_bit_saat;
										Vardiya.vard_gun = vard_gun;
										Vardiya.vard_konum = vard_konum;

									}

								}

							}

							con.Close();
							personel_profil mainForm = new personel_profil();
							mainForm.Show();
							this.Hide();
							return;
						}



					}
				}
				

				string yoneticiQuery = "SELECT yon_id, yon_ad_soyad, yon_mail, yon_sifre FROM yonetici WHERE yon_mail = @email AND yon_sifre = @sifre";

				using (SqlCommand yoneticiCommand = new SqlCommand(yoneticiQuery, con))
				{
					
					yoneticiCommand.Parameters.AddWithValue("@email", email);
					yoneticiCommand.Parameters.AddWithValue("@sifre", sifre);

					using (SqlDataReader yoneticiReader = yoneticiCommand.ExecuteReader())
					{
						if (yoneticiReader.Read())
						{
					
							LoginEvents.Id = yoneticiReader["yon_id"].ToString();
							LoginEvents.Isim = yoneticiReader["yon_ad_soyad"].ToString();
							LoginEvents.Email = email;
							LoginEvents.Password = sifre;


							menu mainForm = new menu();
							mainForm.Show();
							this.Hide();
							return;
						}
					}
				}

				
				MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
