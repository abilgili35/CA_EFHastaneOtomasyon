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
    public class HastaBilgileriConcrete : IHastaBilgileri
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateHastaBilgileri(HastaBilgileri hastaBilgisi)
        {
            try
            {
                context.HastaBilgileris.Add(hastaBilgisi);

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

        public bool DeleteHastaBilgileri(int hastaBilgileriId)
        {
            try
            {
                HastaBilgileri deleted = context.HastaBilgileris.Find(hastaBilgileriId);

                if (deleted != null)
                {
                    context.HastaBilgileris.Remove(deleted);
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

        public List<HastaBilgileri> GetAllHastaBilgileris()
        {
            return context.HastaBilgileris.ToList();
        }

        public bool UpdateHastaBilgileri(HastaBilgileri updated)
        {
            try
            {
                HastaBilgileri hastaBilgileri = context.HastaBilgileris.FirstOrDefault(x => x.ID == updated.ID);

                if (hastaBilgileri != null)
                {
                    hastaBilgileri.DogumTarihi = updated.DogumTarihi;
                    hastaBilgileri.Boy = updated.Boy;
                    hastaBilgileri.Kilo = updated.Kilo;
                    hastaBilgileri.Email = updated.Email;
                    hastaBilgileri.Adres = updated.Adres;
                    hastaBilgileri.TelefonNo = updated.TelefonNo;

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
