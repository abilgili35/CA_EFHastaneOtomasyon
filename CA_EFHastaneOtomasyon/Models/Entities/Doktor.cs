using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class Doktor
    {
        public int ID { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string UzmanlikAlani { get; set; }
        public Oda Oda { get; set; }
        public DateTime? DiplomaTarihi { get; set; }
        public List<Randevu> Randevus { get; set; }
    }
}
