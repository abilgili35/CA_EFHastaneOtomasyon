using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface IOdemeler
    {
        bool DeleteOdemelerByHastaId(int hastaId);
        List<Odeme> GetAllOdemelers();
        bool CreateOdeme(Odeme odeme);
        bool DeleteOdeme(int odemeId);
        bool UpdateOdeme(Odeme updated);
    }
}
