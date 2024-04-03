using CA_EFHastaneOtomasyon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Context
{
    public class EFHastaneOtomasyonContext:DbContext
    {
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<TahlilSonucu> TahlilSonucus { get; set; }
        public DbSet<Odeme> Odemes { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<HastaBilgileri> HastaBilgileris { get; set; }
        public DbSet<Oda> Odas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //aşağıdaki işlem veritabanını ilk kez oluşturmak istenildiğinde tatiklecek karar yapısıdır. Bu yüzden veritabanı daha önce konfigürasyon edilmemişse karar yapısı içerisinde bulunan connectionstring çalıştırılacak ve SqlServer kullanıma alınacak.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=ABILGILI\\SQLEXPRESS;database=efhastaneotomasyon;Integrated Security=SSPI;TrustServerCertificate=true");
            }




            base.OnConfiguring(optionsBuilder);
        }
    }
}
