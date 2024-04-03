using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class Randevu
    {
        public int ID { get; set; }
        public DateTime RandevuZamani { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
        public int DoktorId { get; set; }
        public Doktor Doktor { get; set; }

    }
}
