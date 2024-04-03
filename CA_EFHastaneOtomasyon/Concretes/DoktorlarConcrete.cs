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
    public class DoktorlarConcrete : IDoktorlar
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateDoktor(Doktor doktor)
        {
            try
            {
                context.Doktors.Add(doktor);

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

        

        public bool DeleteDoktor(int doktorId)
        {
            try
            {
                Doktor deleted = context.Doktors.Find(doktorId);
                OdalarConcrete odalar = new OdalarConcrete();
                RandevularConcrete randevularConcrete = new RandevularConcrete();

                if (deleted != null)
                {
                    odalar.DeleteOda(doktorId);
                    randevularConcrete.DeleteRandevularByDoktorId(doktorId);
                    context.Doktors.Remove(deleted);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            
        }

        public List<Doktor> GetAllDoktorlars()
        {
            return context.Doktors.ToList();
        }

        public bool UpdateDoktor(Doktor updated)
        {
            try
            {
                Doktor doktor = context.Doktors.FirstOrDefault(x => x.ID == updated.ID);

                if (doktor != null)
                {
                    doktor.DoktorAd = updated.DoktorAd;
                    doktor.DoktorSoyad = updated.DoktorSoyad;
                    doktor.UzmanlikAlani = updated.UzmanlikAlani;
                    doktor.DiplomaTarihi = updated.DiplomaTarihi;

                    context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            
        }

       
    }
}
