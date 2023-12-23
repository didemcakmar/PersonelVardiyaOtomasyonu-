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

        public string izin_bas_tar { get; set; }
        public string izin_bit_tar { get; set; }
		public string durum { get; set; }


	}
}
