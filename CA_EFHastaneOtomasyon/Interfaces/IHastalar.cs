using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface IHastalar
    {
        bool CreateHasta(Hasta hasta);
        List<Hasta> GetAllHastalars();
        bool DeleteHasta(int hastaId);
        bool UpdateHasta(Hasta updated);
    }
}
