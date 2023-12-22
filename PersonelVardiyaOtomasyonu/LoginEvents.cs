using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu
{
	internal class LoginEvents
	{
		public static string Id { get; set; }
		public static string Email { get; set; }
		public static string Isim { get; set; }
		public static string Yetki { get; set; }
		public static string Password { get; set; }

	}

	internal class LoginEventsPersonel
	{
		public static string id { get; set; }
		public static string sicil_no { get; set; }
		public static string kadro_tipi { get; set; }
		public static string gorev_unvani { get; set; }
		public static string ad { get; set; }
		public static string soyad { get; set; }
		public static string kimlik_no { get; set; }
		public static string telefon { get; set; }
		public static string email { get; set; }

		public static string sifre { get; set; }

	}


	internal class Vardiya
	{
		public static string vard_id { get; set; }
		public static string pers_sicil { get; set; }
		public static string vard_bas_saat { get; set; }
		public static string vard_bit_saat { get; set; }
		public static string vard_gun { get; set; }
		public static string vard_konum { get; set; }

		
	}
}
