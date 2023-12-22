using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using PersonelVardiyaOtomasyonu.Tablolar;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;


namespace PersonelVardiyaOtomasyonu
{
	public partial class otomasyon : Form
	{

		private readonly DatabaseManager _context;


		public otomasyon()
		{
			InitializeComponent();
			_context = new DatabaseManager();

		}

		private void ButtonEkle_Click(object sender, EventArgs e)
		{
			List<string> kampüs = new List<string>();
			kampüs.Add("00:00-08:00");
			kampüs.Add("08:00-16:00");
			kampüs.Add("16:00-24:00");
			List<string> kampüs2 = new List<string>();
			kampüs2.Add("08:00-16:00");
			kampüs2.Add("09:00-17:00");



			DateTime baslangictarihi = DateTime.Parse(baslangic_dateTimePicker.Text);
			DateTime bitistarihi = DateTime.Parse(bitis_dateTimePicker.Text);


			int daysBetween = (int)(bitistarihi - baslangictarihi).TotalDays;

			var işcisicil = _context.personel.Select(p => p.sicil_no).ToList();

			List<int> sicillistesi = new List<int>(işcisicil);


			int gunfarki = (int)(bitistarihi - baslangictarihi).TotalDays;

			for (int i = 0; i < gunfarki + 1; i++)
			{
				DateTime Days = baslangictarihi.AddDays(i);
				if (işcisicil.Any())
				{
					foreach (int sicil in işcisicil)
					{
						if (izinsorgulama(sicil, Days))
						{
							var kampusIciVardiyaCount = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampus ici" && vk.Gün == Days);
							var kampusDisiVardiyaCount = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampüs Disi" && vk.Gün == Days);



							//en son bak
							string sql2 = "SELECT COUNT(*) FROM vardiya_kayit WHERE Place = @Place AND Gun = @Gun And Saat = @Saat";
							string sql3 = "INSERT INTO vardiya_kayit (Sicil, Gun, Saat, Place) VALUES (@Sicil, @Gun, @Saat, @Place)";


							string saat = " ";
							if ((kampusIciVardiyaCount / 3) < (kampusDisiVardiyaCount / 2))
							{
								string bölge = "Kampus İçi";

								var vardiyaA = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampus ici" && vk.Gün == Days && vk.Saat == kampüs[0]);
								var vardiyaB = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampus ici" && vk.Gün == Days && vk.Saat == kampüs[1]);
								var vardiyaC = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampus ici" && vk.Gün == Days && vk.Saat == kampüs[2]);
								int enKucukVardiye = Math.Min(vardiyaA, Math.Min(vardiyaB, vardiyaC));
								if (enKucukVardiye == vardiyaA)
								{
									saat = kampüs[0];
								}
								else if (enKucukVardiye == vardiyaB)
								{
									saat = kampüs[1];
								}
								else if (enKucukVardiye == vardiyaC)
								{
									saat = kampüs[2];
								}
								var vardiya_kayit = new Tablolar.VardiyaKayit
								{
									Sicil = sicil,
									Gün = Days,
									Saat = saat,
									Bölge = bölge
								};

								_context.vardiya_kayit.Add(vardiya_kayit);
								_context.SaveChanges();

							}
							else
							{
								string bölge = "Kampüs Dışı";
								var vardiyaA = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampus ici" && vk.Gün == Days && vk.Saat == kampüs2[0]);
								var vardiyaB = _context.vardiya_kayit.Count(vk => vk.Bölge == "Kampus ici" && vk.Gün == Days && vk.Saat == kampüs2[1]);
								if (vardiyaA < vardiyaB)
								{
									saat = kampüs2[0];
								}
								else
								{
									saat = kampüs2[1];
								}
								var vardiya_kayit = new Tablolar.VardiyaKayit
								{
									Sicil = sicil,
									Gün = Days,
									Saat = saat,
									Bölge = bölge
								};

								_context.vardiya_kayit.Add(vardiya_kayit);
								_context.SaveChanges();

							}
						}
					}
				}

			}


			MessageBox.Show("Vardiye Oluşturuldu");


		}
		public List<int> getSicilList()
		{
			var personel_sicil = _context.personel.Select(p => p.sicil_no).ToList();

			return personel_sicil;
		}
		public bool izinsorgulama(int sicil_no, DateTime tarih)
		{


			var izinSayisi = _context.izinler.Count(izin => izin.pers_sicil == sicil_no && izin.izin_bas_tar == tarih);

			if (izinSayisi == 0)
			{
				var izinSayisiVardiya = _context.vardiya_kayit.Count(izin => izin.Sicil == sicil_no && izin.Gün == tarih);

				if (izinSayisiVardiya == 0)
				{



					string gunAdi = "";

					switch (tarih.DayOfWeek)
					{
						case DayOfWeek.Sunday:
							gunAdi = "Pazar";
							break;
						case DayOfWeek.Monday:
							gunAdi = "Pazartesi";
							break;
						case DayOfWeek.Tuesday:
							gunAdi = "Salı";
							break;
						case DayOfWeek.Wednesday:
							gunAdi = "Çarşamba";
							break;
						case DayOfWeek.Thursday:
							gunAdi = "Perşembe";
							break;
						case DayOfWeek.Friday:
							gunAdi = "Cuma";
							break;
						case DayOfWeek.Saturday:
							gunAdi = "Cumartesi";
							break;
					}

					var personel_izin_gün_1 = _context.personel
						.FirstOrDefault(izin => izin.sicil_no == sicil_no && izin.izin_günü_1 == gunAdi);

					var personel_izin_gün_2 = _context.personel
						.FirstOrDefault(izin => izin.sicil_no == sicil_no && izin.izin_günü_2 == gunAdi);

					if (personel_izin_gün_1 == null && personel_izin_gün_2 == null)
					{

						return true;
					}
					else
					{
						return false;
					}




				}

			}
			return false;
		}


		private void ButtonSil_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
