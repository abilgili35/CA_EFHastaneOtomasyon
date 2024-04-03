using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface IHastaBilgileri
    {
        bool CreateHastaBilgileri(HastaBilgileri hastaBilgisi);
        List<HastaBilgileri> GetAllHastaBilgileris();
        bool DeleteHastaBilgileri(int hastaBilgileriId);
        bool UpdateHastaBilgileri(HastaBilgileri updated);
    }
}
