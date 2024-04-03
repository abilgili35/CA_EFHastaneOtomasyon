using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface IRandevular
    {
        bool DeleteRandevularByDoktorId(int doktorId);
        bool DeleteRandevularByHastaId(int hastaId);
        List<Randevu> GetAllRandevulars();
        bool CreateRandevu(Randevu randevu);
        bool DeleteRandevu(int randevuId);
        bool UpdateRandevu(Randevu updated);
    }
}
