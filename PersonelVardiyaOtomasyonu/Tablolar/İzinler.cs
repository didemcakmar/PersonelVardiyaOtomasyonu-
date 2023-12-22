using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
	public class İzinler
	{

		[Key]
		public int id { get; set; }
		public int pers_sicil { get; set; }

		public DateTime izin_bas_tar { get; set; }
		public int durum { get; set; }


	}
}
