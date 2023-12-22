using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
	public class Vardiyalar
	{

		[Key]
		public int id { get; set; }
		public string vardiye { get; set; }

		public string tur { get; set; }



	}
}
