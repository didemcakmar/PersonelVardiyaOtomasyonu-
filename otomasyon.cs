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
			string baslangic_tarihi = baslangic_dateTimePicker.Text;
			string bitis_tarihi = bitis_dateTimePicker.Text;

			DateTime baslangicTarihi = DateTime.Parse(baslangic_tarihi);
			DateTime bitisTarihi = DateTime.Parse(bitis_tarihi);

			var işciSicil = _context.personel.Select(p => p.sicil_no).ToList();
			List<int> sicilListesi = new List<int>(işciSicil);


			int gunFarki = (int)(bitisTarihi - baslangicTarihi).TotalDays;

			foreach (int sicil in sicilListesi)
			{
				for (int i = 0; i < gunFarki; i++)
				{
					try
					{
						string formattedBaslangicTarihi = baslangicTarihi.AddDays(i).ToString("yyyy-MM-dd");
						string formattedBitisTarihi = baslangicTarihi.AddDays(i).ToString("yyyy-MM-dd");

						var cevap = _context.izinler.Count(ı => ı.pers_sicil == sicil && ı.izin_bas_tar == formattedBaslangicTarihi && ı.izin_bit_tar == formattedBitisTarihi);

						if (cevap == 0)
						{
							_context.izinler.Add(new İzinler
							{
								pers_sicil = sicil,
								izin_bas_tar = formattedBaslangicTarihi,
								izin_bit_tar = formattedBitisTarihi,
								durum = "0"
							});

							_context.SaveChanges();
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("Hata: " + ex.Message);
						MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}





			try
			{
				
				var vardiyalar = _context.vardiyalar.Select(vk => vk.id).ToList();
	

				foreach (int vardiyeId in vardiyalar)
				{
					

					for (int i = 0; i < gunFarki; i++)
					{
						
						string formattedGün = baslangicTarihi.AddDays(i).ToString("dd-MM-yyyy");
						
						int cevap = _context.vardiyeKontrol.Count(vk => vk.Vardiye == vardiyeId && vk.Gün == formattedGün);

						if (cevap == 0)
						{
							
							_context.vardiyeKontrol.Add(new VardiyaKontrol
							{
								Vardiye = vardiyeId,
								Sayi = 0,
								Gün = formattedGün
							});

							_context.SaveChanges();
						}

					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Hata: " + ex.Message);
				MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



			foreach (int sicil in sicilListesi)
			{
				

				for (int i = 0; i < gunFarki; i++)
				{
					
					bool izinli = WhereBoolean3(sicil, baslangicTarihi.AddDays(i));




					if (izinli)
					{


						string hedefTarih = baslangicTarihi.AddDays(i).ToString("dd.MM.yyyy");

						// 22.18.2004 22.22
						var xd = hedefTarih.ToString().Split(' ').FirstOrDefault();
						var xx = xd.ToString().Replace('.', '-');
						// 12-01-2022
						// 2022-01-12



						var enDusukMiktarliVardiyeId = _context.vardiyeKontrol
								.Where(pv => pv.Gün == xx)
								.OrderBy(pv => pv.Sayi)
								.Select(pv => pv.Vardiye
								)
								.FirstOrDefault();





							if (enDusukMiktarliVardiyeId != null)
							{


							
								// Vardiye ID'sine ait vardiyanın Sayi sütununu al
								var vardiyeBilgisi = _context.vardiyalar
									.Where(v => v.id == enDusukMiktarliVardiyeId)
									.Select(v => new { Vardiye = v.vardiye, Tur = v.tur })
									.FirstOrDefault();



							

								if (vardiyeBilgisi != null)
								{
									string formattedDate = baslangicTarihi.AddDays(i).ToString("dd.MM.yyyy");


									// 22.18.2004 22.22
									var xd1 = formattedDate.ToString().Split(' ').FirstOrDefault();
									var xxs = xd1.ToString().Replace('.', '-');

								
									// Yeni kayıt oluştur
									_context.vardiya_kayit.Add(new VardiyaKayit
									{
										Sicil = sicil,
										Gün = xxs,
										Saat = vardiyeBilgisi.Vardiye,
										Bölge = vardiyeBilgisi.Tur
									});


							


									_context.SaveChanges();
									


									
									var izin = _context.izinler.FirstOrDefault(iz => iz.pers_sicil == sicil && 
																				iz.izin_bas_tar == formattedDate);

									if (izin != null)
									{
										izin.durum = "3"; 
										_context.SaveChanges();
										MessageBox.Show("Veritabanı güncellendi.");
									}




								var vardiyekontrol = _context.vardiyeKontrol.FirstOrDefault(vr => vr.Vardiye == enDusukMiktarliVardiyeId &&
																										   vr.Gün == xxs);


									if (vardiyekontrol != null)
									{
									// Vardiye kontrol kaydını bulduysanız Sayi özelliğini artırın
										
										vardiyekontrol.Sayi++;
										_context.SaveChanges();
									}



								}
								else
								{
									MessageBox.Show("Belirtilen vardiye için Sayi değeri bulunamadı.");
								}

							}
							else
							{
								MessageBox.Show("Tarih dönüşümü başarısız!");
							}
						

					}
				}
			}
			MessageBox.Show("Başarılı");


		}
		public bool WhereBoolean3(int sicil, DateTime gun)
		{

			// 22.18.2004 22.22
			var xd = gun.ToString().Split(' ').FirstOrDefault();
			var xx = xd.ToString().Replace('.', '-');
			// 12-01-2022
			// 2022-01-12
			var aa = string.Join("-", xx.Split('-').Reverse());


			var personel = _context.personel.FirstOrDefault(p => p.sicil_no == sicil);

			string izinGunleri = personel.izin_günü;

			string günDeğeri = gun.ToString("dddd");


			if (izinGunleri.IndexOf(günDeğeri.Trim()) == -1)
			{

				



			

				var izin = _context.izinler.FirstOrDefault(p => p.pers_sicil == sicil &&
																(p.izin_bas_tar) == aa);

				if (izin != null)
				{
				
				}

				if (izin.durum == "0")
				{
					return true; // İzinli
				}


			}

			return false; // İzinli değil
		}


		private void ButtonSil_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
