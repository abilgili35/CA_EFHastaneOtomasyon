using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class Hasta
    {
        public int ID { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string Tckn { get; set; }

        public HastaBilgileri HastaBilgileri { get; set; }
        public List<TahlilSonucu> TahlilSonucus { get; set; }
        public List<Odeme> Odemes { get; set; }
    }
}
