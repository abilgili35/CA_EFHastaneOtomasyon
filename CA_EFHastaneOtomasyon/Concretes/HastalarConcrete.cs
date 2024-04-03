using CA_HastaneOtomasyon.Interfaces;
using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using CA_EFHastaneOtomasyon.Models.Context;

namespace CA_HastaneOtomasyon.Concretes
{
    public class HastalarConcrete : IHastalar
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateHasta(Hasta hasta)
        {
            try
            {
                context.Hastas.Add(hasta);

                if (context.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteHasta(int hastaId)
        {
            try
            {
                Hasta deleted = context.Hastas.Find(hastaId);
                HastaBilgileriConcrete hastaBilgileriConcrete = new HastaBilgileriConcrete();
                RandevularConcrete randevularConcrete = new RandevularConcrete();
                TahlilSonuclariConcrete tahlilSonuclariConcrete = new TahlilSonuclariConcrete();
                OdemelerConcrete odemelerConcrete = new OdemelerConcrete();

                if (deleted != null)
                {
                    hastaBilgileriConcrete.DeleteHastaBilgileri(hastaId);
                    randevularConcrete.DeleteRandevularByHastaId(hastaId);
                    tahlilSonuclariConcrete.DeleteTahlilSonuclariByHastaId(hastaId);
                    odemelerConcrete.DeleteOdemelerByHastaId(hastaId);
                    context.Hastas.Remove(deleted);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Hasta> GetAllHastalars()
        {
            return context.Hastas.ToList();
        }

        public bool UpdateHasta(Hasta updated)
        {
            try
            {
                Hasta hasta = context.Hastas.FirstOrDefault(x => x.ID == updated.ID);

                if (hasta != null)
                {
                    hasta.HastaAd = updated.HastaAd;
                    hasta.HastaSoyad = updated.HastaSoyad;
                    hasta.Tckn = updated.Tckn;

                    context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
