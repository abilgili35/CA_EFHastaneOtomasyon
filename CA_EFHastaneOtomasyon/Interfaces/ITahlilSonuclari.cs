using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HastaneOtomasyon.Interfaces
{
    public interface ITahlilSonuclari
    {
        bool DeleteTahlilSonuclariByHastaId(int hastaId);
        List<TahlilSonucu> GetAllTahlilSonuclaris();
        bool CreateTahlilSonucu(TahlilSonucu tahlilSonucu);
        bool DeleteTahlilSonucu(int tahlilSonucuId);
        bool UpdateTahlilSonucu(TahlilSonucu updated);
    }
}
