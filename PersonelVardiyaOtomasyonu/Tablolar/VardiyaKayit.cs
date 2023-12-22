using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
	public class VardiyaKayit
	{
		public int ID { get; set; }
		public int Sicil { get; set; }
		public DateTime Gün { get; set; }
		public string Saat { get; set; }
		public string Bölge { get; set; }
	}
}
