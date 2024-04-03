using CA_HastaneOtomasyon.Interfaces;
using CA_EFHastaneOtomasyon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_EFHastaneOtomasyon.Models.Context;

namespace CA_HastaneOtomasyon.Concretes
{
    public class TahlilSonuclariConcrete : ITahlilSonuclari
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateTahlilSonucu(TahlilSonucu tahlilSonucu)
        {
            try
            {
                context.TahlilSonucus.Add(tahlilSonucu);

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

        public bool DeleteTahlilSonuclariByHastaId(int hastaId)
        {
            try
            {
                List<TahlilSonucu> deletedList = context.TahlilSonucus.Where(x => x.HastaId == hastaId).ToList();

                if (deletedList.Count != 0)
                {

                    foreach (TahlilSonucu tahlilSonucu in deletedList)
                    {
                        context.TahlilSonucus.Remove(tahlilSonucu);
                    }

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

        public bool DeleteTahlilSonucu(int tahlilSonucuId)
        {
            try
            {
                TahlilSonucu deleted = context.TahlilSonucus.Find(tahlilSonucuId);

                if (deleted != null)
                {
                    context.TahlilSonucus.Remove(deleted);
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

        public List<TahlilSonucu> GetAllTahlilSonuclaris()
        {
            return context.TahlilSonucus.ToList();
        }

        public bool UpdateTahlilSonucu(TahlilSonucu updated)
        {
            try
            {
                TahlilSonucu tahlilSonucu = context.TahlilSonucus.FirstOrDefault(x => x.ID == updated.ID);

                if (tahlilSonucu != null)
                {
                    tahlilSonucu.TahlilZamani = updated.TahlilZamani;
                    tahlilSonucu.TahlilDosyaLinki = updated.TahlilDosyaLinki;
                    tahlilSonucu.HastaId = updated.HastaId;

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
