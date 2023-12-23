using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
	public class VardiyaKontrol
	{
	
		public int id { get; set; }
		public int Vardiye { get; set; }

		public int Sayi { get; set; }

		public string Gün { get; set; }
	}
}
