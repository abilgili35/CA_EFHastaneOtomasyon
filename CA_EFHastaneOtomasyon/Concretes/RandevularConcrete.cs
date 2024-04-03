using CA_HastaneOtomasyon.Interfaces;
using CA_EFHastaneOtomasyon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_EFHastaneOtomasyon.Models.Context;

namespace CA_HastaneOtomasyon.Concretes
{
    public class RandevularConcrete : IRandevular
    {
        EFHastaneOtomasyonContext context = new EFHastaneOtomasyonContext();

        public bool CreateRandevu(Randevu randevu)
        {
            try
            {
                context.Randevus.Add(randevu);

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

        public bool DeleteRandevu(int randevuId)
        {
            try
            {
                Randevu deleted = context.Randevus.Find(randevuId);

                if (deleted != null)
                {
                    context.Randevus.Remove(deleted);
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

        public bool DeleteRandevularByDoktorId(int doktorId)
        {
            try
            {
                List<Randevu> deletedList = context.Randevus.Where(x => x.DoktorId == doktorId).ToList();

                if (deletedList.Count != 0)
                {

                    foreach (Randevu randevu in deletedList)
                    {
                        context.Randevus.Remove(randevu);
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

        public bool DeleteRandevularByHastaId(int hastaId)
        {
            try
            {
                List<Randevu> deletedList = context.Randevus.Where(x => x.HastaId == hastaId).ToList();

                if (deletedList.Count != 0)
                {

                    foreach(Randevu randevu in deletedList)
                    {
                        context.Randevus.Remove(randevu);
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

        public List<Randevu> GetAllRandevulars()
        {
            return context.Randevus.ToList();
        }

        public bool UpdateRandevu(Randevu updated)
        {
            try
            {
                Randevu randevu = context.Randevus.FirstOrDefault(x => x.ID == updated.ID);

                if (randevu != null)
                {
                    randevu.DoktorId = updated.DoktorId;
                    randevu.HastaId = updated.HastaId;
                    randevu.RandevuZamani = updated.RandevuZamani;

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
