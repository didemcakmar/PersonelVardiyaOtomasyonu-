using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
    public class Vardiya
    {
        [Key]
        public int id { get; set; }
        public int pers_sicil{ get; set; }
        public int vard_bas_saat { get; set; }
        public int vard_bit_saat { get; set; }
        public string vard_gun { get; set; }
        public string vard_konum { get; set; }

    }
}
