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
    public class OdalarConcrete : IOdalar
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateOda(Oda odaBilgisi)
        {
            try
            {
                context.Odas.Add(odaBilgisi);

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

        public bool DeleteOda(int odaId)
        {
            try
            {
                Oda deleted = context.Odas.Find(odaId);

                if (deleted != null)
                {
                    context.Odas.Remove(deleted);
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

        public List<Oda> GetAllOdalars()
        {
            return context.Odas.ToList();
        }

        public bool UpdateOda(Oda updated)
        {
            try
            {
                Oda odaBilgileri = context.Odas.FirstOrDefault(x => x.ID == updated.ID);

                if (odaBilgileri != null)
                {
                    odaBilgileri.BinaNo = updated.BinaNo;
                    odaBilgileri.KatNo = updated.KatNo;
                    odaBilgileri.OdaNo = updated.OdaNo;
                    

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
