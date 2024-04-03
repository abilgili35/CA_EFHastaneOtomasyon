using CA_HastaneOtomasyon.Concretes;
using CA_EFHastaneOtomasyon.Models.Entities;

namespace CA_HastaneOtomasyon
{
    public class Program
    {
        public static void Main(string[] args)
        {





            #region DoktorlarConcrete TEST
            //DoktorlarConcrete TEST

            //DoktorlarConcrete doktorlarConcrete = new DoktorlarConcrete();

            //Doktor d = new Doktor();

            //d.DoktorAd = "Ahmet";
            //d.DoktorSoyad = "Guven";
            //d.UzmanlikAlani = "Dahiliye";
            //d.DiplomaTarihi = new DateTime(1954, 6, 6);

            //doktorlarConcrete.CreateDoktor(d);

            //foreach (Doktor doktor in doktorlarConcrete.GetAllDoktorlars())
            //{
            //    Console.WriteLine($"{doktor.ID} {doktor.DoktorAd} {doktor.DoktorSoyad} {doktor.UzmanlikAlani} {doktor.DiplomaTarihi}");
            //}

            //Doktor d2 = new Doktor();
            //d2.ID = 3;
            //d2.DoktorAd = "Ahmet2";
            //d2.DoktorSoyad = "Guven2";
            //d2.UzmanlikAlani = "Cerrahi";
            //d2.DiplomaTarihi = new DateTime(1960, 8, 8);

            //if (doktorlarConcrete.UpdateDoktor(d2))
            //{
            //    Console.WriteLine("\nGuncelleme islemi basarili.");
            //}
            //else
            //{
            //    Console.WriteLine("\nGuncelleme islemi basarisiz.");
            //}

            //foreach (Doktor doktor in doktorlarConcrete.GetAllDoktorlars())
            //{
            //    Console.WriteLine($"{doktor.DoktorAd} {doktor.DoktorSoyad} {doktor.UzmanlikAlani} {doktor.DiplomaTarihi}");
            //}


            //if (doktorlarConcrete.DeleteDoktor(2))
            //{
            //    Console.WriteLine("\nSilme islemi basarili.");
            //}
            //else
            //{
            //    Console.WriteLine("\nSilme islemi basarisiz.");
            //}

            //foreach (Doktorlar doktor in doktorlarConcrete.GetAllDoktorlars())
            //{
            //    Console.WriteLine($"{doktor.DoktorAd} {doktor.DoktorSoyad} {doktor.UzmanlikAlani} {doktor.DiplomaTarihi}");
            //}

            //Doktorlar d2 = new Doktorlar();
            //d2.Id = 13;
            //d2.DoktorAd = "Ahmet2";
            //d2.DoktorSoyad = "Guven2";
            //d2.UzmanlikAlani = "Cerrahi";
            //d2.DiplomaTarihi = new DateTime(1960, 8, 8);

            //if (doktorlarConcrete.UpdateDoktor(d2))
            //{
            //    Console.WriteLine("\nGuncelleme islemi basarili.");
            //}
            //else
            //{
            //    Console.WriteLine("\nGuncelleme islemi basarisiz.");
            //}

            //foreach (Doktorlar doktor in doktorlarConcrete.GetAllDoktorlars())
            //{
            //    Console.WriteLine($"{doktor.DoktorAd} {doktor.DoktorSoyad} {doktor.UzmanlikAlani} {doktor.DiplomaTarihi}");
            //} 
            #endregion

            #region HastalarConcrete TEST
            //HastalarConcrete hastalarConcrete = new HastalarConcrete();

            //Hastalar h1 = new Hastalar();
            //h1.HastaAd = "Ali";
            //h1.HastaSoyad = "Sahiner";
            //h1.Tckn = "11122233344";

            //foreach(Hastalar hasta in hastalarConcrete.GetAllHastalars()) 
            //{
            //    Console.WriteLine($"{hasta.Id} {hasta.HastaAd} {hasta.HastaSoyad} {hasta.Tckn}");
            //}

            //if (hastalarConcrete.CreateHasta(h1))
            //{
            //    Console.WriteLine("\nHasta ekleme islemi basarili.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nHasta ekleme islemi basarisiz.\n");
            //}

            //foreach (Hastalar hasta in hastalarConcrete.GetAllHastalars())
            //{
            //    Console.WriteLine($"{hasta.Id} {hasta.HastaAd} {hasta.HastaSoyad} {hasta.Tckn}");
            //}

            //if (hastalarConcrete.DeleteHasta(1))
            //{
            //    Console.WriteLine("\nHasta silme islemi basarili.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nHasta silme islemi basarisiz.\n");
            //}

            //foreach (Hastalar hasta in hastalarConcrete.GetAllHastalars())
            //{
            //    Console.WriteLine($"{hasta.Id} {hasta.HastaAd} {hasta.HastaSoyad} {hasta.Tckn}");
            //}

            //Hastalar h2 = new Hastalar();
            //h2.Id = 7;
            //h2.HastaAd = "Sema";
            //h2.HastaSoyad = "Bilgin";
            //h2.Tckn = "11111111111";

            //if (hastalarConcrete.UpdateHasta(h2))
            //{
            //    Console.WriteLine("\nHasta guncelleme islemi basarili.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nHasta guncellme islemi basarisiz.\n");
            //}

            //foreach (Hastalar hasta in hastalarConcrete.GetAllHastalars())
            //{
            //    Console.WriteLine($"{hasta.Id} {hasta.HastaAd} {hasta.HastaSoyad} {hasta.Tckn}");
            //} 
            #endregion

            #region HastaBilgileriConcrete TEST
            //HastaBilgileriConcrete hastaBilgileriConcrete = new HastaBilgileriConcrete();

            //HastaBilgileri h1 = new HastaBilgileri();
            //h1.Id = 3;
            //h1.DogumTarihi = new DateTime(1961, 9, 9);
            //h1.Boy = 1.76;
            //h1.Kilo = 70.5;
            //h1.Email = "abilgili@hotmail.com";
            //h1.Adres = "Bayrakli IZMIR";
            //h1.TelefonNo = "3367024";

            //foreach(HastaBilgileri hastaBilgileri in hastaBilgileriConcrete.GetAllHastaBilgileris())
            //{
            //    Console.WriteLine($"{hastaBilgileri.DogumTarihi} {hastaBilgileri.Boy} {hastaBilgileri.Kilo} {hastaBilgileri.Email} {hastaBilgileri.Adres} {hastaBilgileri.TelefonNo}");
            //}

            //if (hastaBilgileriConcrete.CreateHastaBilgileri(h1))
            //{
            //    Console.WriteLine("\nHasta Bilgileri eklendi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nHasta Bilgileri eklenemedi.\n");
            //}

            //foreach (HastaBilgileri hastaBilgileri in hastaBilgileriConcrete.GetAllHastaBilgileris())
            //{
            //    Console.WriteLine($"{hastaBilgileri.DogumTarihi} {hastaBilgileri.Boy} {hastaBilgileri.Kilo} {hastaBilgileri.Email} {hastaBilgileri.Adres} {hastaBilgileri.TelefonNo}");
            //}

            //if (hastaBilgileriConcrete.DeleteHastaBilgileri(3))
            //{
            //    Console.WriteLine("\nHasta Bilgileri silindi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nHasta Bilgileri silinemedi.\n");
            //}

            //foreach (HastaBilgileri hastaBilgileri in hastaBilgileriConcrete.GetAllHastaBilgileris())
            //{
            //    Console.WriteLine($"{hastaBilgileri.DogumTarihi} {hastaBilgileri.Boy} {hastaBilgileri.Kilo} {hastaBilgileri.Email} {hastaBilgileri.Adres} {hastaBilgileri.TelefonNo}");
            //}

            //HastaBilgileri h2 = new HastaBilgileri();
            //h2.Id = 20;
            //h2.DogumTarihi = new DateTime(1961, 9, 9);
            //h2.Boy = 1.76;
            //h2.Kilo = 70.5;
            //h2.Email = "abilgili@hotmail.com";
            //h2.Adres = "Bayrakli IZMIR";
            //h2.TelefonNo = "3367024";

            //if (hastaBilgileriConcrete.UpdateHastaBilgileri(h2))
            //{
            //    Console.WriteLine("\nHasta Bilgileri guncellendi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nHasta Bilgileri guncellenemedi.\n");
            //}

            //foreach (HastaBilgileri hastaBilgileri in hastaBilgileriConcrete.GetAllHastaBilgileris())
            //{
            //    Console.WriteLine($"{hastaBilgileri.DogumTarihi} {hastaBilgileri.Boy} {hastaBilgileri.Kilo} {hastaBilgileri.Email} {hastaBilgileri.Adres} {hastaBilgileri.TelefonNo}");
            //} 
            #endregion

            #region RandevularConcrete TEST

            //RandevularConcrete randevularConcrete = new RandevularConcrete();

            //foreach (Randevular randevu in randevularConcrete.GetAllRandevulars())
            //{
            //    Console.WriteLine($"{randevu.Id} {randevu.DoktorId} {randevu.HastaId} {randevu.RandevuZamani}");
            //}



            //if (randevularConcrete.DeleteRandevularByHastaId(4))
            //{
            //    Console.WriteLine("\nRandevular hasta id sine gore silindi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nRandevular hasta id sine gore silinemedi.\n");
            //}

            //foreach (Randevular randevu in randevularConcrete.GetAllRandevulars())
            //{
            //    Console.WriteLine($"{randevu.Id} {randevu.DoktorId} {randevu.HastaId} {randevu.RandevuZamani}");
            //}

            //if (randevularConcrete.DeleteRandevu(4))
            //{
            //    Console.WriteLine("\nRandevu id sine gore silindi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nRandevu id sine gore silinemedi.\n");
            //}

            //foreach (Randevular randevu in randevularConcrete.GetAllRandevulars())
            //{
            //    Console.WriteLine($"{randevu.Id} {randevu.DoktorId} {randevu.HastaId} {randevu.RandevuZamani}");
            //}

            //Randevular rnd = new Randevular();
            //rnd.DoktorId = 4;
            //rnd.HastaId = 8;
            //rnd.RandevuZamani = new DateTime(2022, 2, 2);

            //foreach (Randevular randevu in randevularConcrete.GetAllRandevulars())
            //{
            //    Console.WriteLine($"{randevu.Id} {randevu.DoktorId} {randevu.HastaId} {randevu.RandevuZamani}");
            //}

            //if (randevularConcrete.CreateRandevu(rnd))
            //{
            //    Console.WriteLine("\nRandevu eklendi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nRandevu eklenemedi.\n");
            //}

            //foreach (Randevular randevu in randevularConcrete.GetAllRandevulars())
            //{
            //    Console.WriteLine($"{randevu.Id} {randevu.DoktorId} {randevu.HastaId} {randevu.RandevuZamani}");
            //}

            //Randevular rnd2 = new Randevular();
            //rnd2.Id = 1;
            //rnd2.DoktorId = 3;
            //rnd2.HastaId = 9;
            //rnd2.RandevuZamani = new DateTime(2022, 2, 2);

            //if (randevularConcrete.UpdateRandevu(rnd2))
            //{
            //    Console.WriteLine("\nRandevu guncellendi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nRandevu guncellenemedi.\n");
            //}

            //foreach (Randevular randevu in randevularConcrete.GetAllRandevulars())
            //{
            //    Console.WriteLine($"{randevu.Id} {randevu.DoktorId} {randevu.HastaId} {randevu.RandevuZamani}");
            //}

            #endregion

            #region TahlilSonuclariConcrete TEST
            //TahlilSonuclariConcrete tahlilSonuclariConcrete = new TahlilSonuclariConcrete();

            //TahlilSonuclari t1 = new TahlilSonuclari();
            //t1.TahlilZamani = new DateTime(2012, 2, 2);
            //t1.TahlilDosyaLinki = "Link1";
            //t1.HastaId = 1;

            //foreach (TahlilSonuclari tahlilSonucu in tahlilSonuclariConcrete.GetAllTahlilSonuclaris())
            //{
            //    Console.WriteLine($"{tahlilSonucu.Id} {tahlilSonucu.TahlilZamani} {tahlilSonucu.TahlilDosyaLinki} {tahlilSonucu.HastaId}");
            //}


            //if (tahlilSonuclariConcrete.CreateTahlilSonucu(t1))
            //{
            //    Console.WriteLine("\nTahlil Sonucu eklendi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nTahlil Sonucu eklenemedi.\n");
            //}


            //foreach (TahlilSonuclari tahlilSonucu in tahlilSonuclariConcrete.GetAllTahlilSonuclaris())
            //{
            //    Console.WriteLine($"{tahlilSonucu.Id} {tahlilSonucu.TahlilZamani} {tahlilSonucu.TahlilDosyaLinki} {tahlilSonucu.HastaId}");
            //}

            //if (tahlilSonuclariConcrete.DeleteTahlilSonuclariByHastaId(1))
            //{
            //    Console.WriteLine("\nTahlil Sonuclari hasta id ye gore silindi.\n");
            //}
            //else
            //{
            //    Console.WriteLine("\nTahlil Sonuclari hasta id ye gore silinemedi .\n");
            //}

            //foreach (TahlilSonuclari tahlilSonucu in tahlilSonuclariConcrete.GetAllTahlilSonuclaris())
            //{
            //    Console.WriteLine($"{tahlilSonucu.Id} {tahlilSonucu.TahlilZamani} {tahlilSonucu.TahlilDosyaLinki} {tahlilSonucu.HastaId}");
            //} 
            #endregion



            Console.Read();
        }
    }
}
