using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface IDoktorlar
    {
        bool CreateDoktor(Doktor doktor);
        List<Doktor> GetAllDoktorlars();
        bool DeleteDoktor(int doktorId);
        bool UpdateDoktor(Doktor updated);
    }
}
