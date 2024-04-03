using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class TahlilSonucu
    {
        public int ID { get; set; }
        public DateTime TahlilZamani { get; set; }
        public string TahlilDosyaLinki { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }

    }
}
