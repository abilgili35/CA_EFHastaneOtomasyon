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
    public class OdemelerConcrete : IOdemeler
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateOdeme(Odeme odeme)
        {
            try
            {
                context.Odemes.Add(odeme);

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

        public bool DeleteOdeme(int odemeId)
        {
            try
            {
                Odeme deleted = context.Odemes.Find(odemeId);

                if (deleted != null)
                {
                    context.Odemes.Remove(deleted);
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

        public bool DeleteOdemelerByHastaId(int hastaId)
        {
            try
            {
                List<Odeme> deletedList = context.Odemes.Where(x => x.HastaId == hastaId).ToList();

                if (deletedList.Count != 0)
                {

                    foreach (Odeme odeme in deletedList)
                    {
                        context.Odemes.Remove(odeme);
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

        public List<Odeme> GetAllOdemelers()
        {
            return context.Odemes.ToList();
        }

        public bool UpdateOdeme(Odeme updated)
        {
            try
            {
                Odeme odeme = context.Odemes.FirstOrDefault(x => x.ID == updated.ID);

                if (odeme != null)
                {
                    odeme.HastaId = updated.HastaId;
                    odeme.OdemeTarihi = updated.OdemeTarihi;
                    odeme.Miktar = updated.Miktar;

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
