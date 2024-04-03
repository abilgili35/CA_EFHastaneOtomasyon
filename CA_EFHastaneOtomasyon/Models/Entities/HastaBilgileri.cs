using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class HastaBilgileri
    {
        public int ID { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public double? Boy { get; set; }
        public double? Kilo { get; set; }
        public string? Email { get; set; }
        public string? Adres { get; set; }
        public string? TelefonNo { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
    }
}
