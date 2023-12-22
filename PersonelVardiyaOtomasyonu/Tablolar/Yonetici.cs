using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelVardiyaOtomasyonu.Tablolar
{
    public class Yonetici
    {
        [Key]
        public int id { get; set; }
        public string yon_ad_soyad{ get; set; }
        public string yon_mail { get; set; }
        public string yon_sifre { get; set; }
    }
}
