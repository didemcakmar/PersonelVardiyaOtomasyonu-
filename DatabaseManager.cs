using Microsoft.EntityFrameworkCore;
using PersonelVardiyaOtomasyonu.Tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;


namespace PersonelVardiyaOtomasyonu.Tablolar
{
    public class DatabaseManager : DbContext
    {
        public DbSet<Personel> personel { get; set; }
        public DbSet<İzinler> izinler { get; set; }
        public DbSet<Yonetici> yonetici { get; set; }

		public DbSet<Vardiyalar> vardiyalar { get; set; }

		public DbSet<VardiyaKontrol> vardiyeKontrol { get; set; }

		public DbSet<VardiyaKayit> vardiya_kayit { get; set; }

		//Database bağlantısı
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PersonelVardiyaOtomasyonu;Integrated Security=True");
        }

    }
}
