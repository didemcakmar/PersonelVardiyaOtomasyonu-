using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
	public class Personel
	{

		public int id { get; set; }
		public string ad { get; set; }
		public string soyad { get; set; }
		public int sicil_no { get; set; }
		public string kadro_tipi { get; set; }
		public string gorev_unvani { get; set; }
		public string email { get; set; }
		public string sifre { get; set; }
		public string telefon { get; set; }
		public string kimlik_no { get; set; }

		public string izin_günü_1 { get; set; }

		public string izin_günü_2 { get; set; }
	}
}

