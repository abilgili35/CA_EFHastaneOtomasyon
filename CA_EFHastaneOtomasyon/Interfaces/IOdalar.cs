using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface IOdalar
    {
        bool CreateOda(Oda odaBilgisi);
        List<Oda> GetAllOdalars();
        bool DeleteOda(int odaId);
        bool UpdateOda(Oda updated);
    }
}
