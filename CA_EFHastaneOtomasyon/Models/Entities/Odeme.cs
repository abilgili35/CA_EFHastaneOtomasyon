using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class Odeme
    {
        public int ID { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public decimal Miktar { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
    }
}
