using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EFHastaneOtomasyon.Models.Entities
{
    public class Oda
    {
        public int ID { get; set; }
        public int BinaNo { get; set; }
        public int KatNo { get; set; }
        public int OdaNo { get; set; }
        public int DoktorId { get; set; }
        public Doktor Doktor { get; set; }
    }
}
