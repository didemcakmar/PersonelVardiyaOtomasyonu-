using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
	public class İzin
	{

		[Key]
		public int id { get; set; }
		public int sicil_no { get; set; }

		public DateTime baslangic_tarihi { get; set; }
		public DateTime bitis_tarihi { get; set; }


	}
}
