using System;
using System.Collections.Generic;
using System.Linq;

namespace Patikafy_Müzik_Platformu
{
    public class Sarkıcılar
    {
        public static void Main()
        {
            List<Sarkıcı> Sarkıcılar = new List<Sarkıcı>()
            {
                new Sarkıcı { SingerName = "Ajda", SingerSurname = "Pekkan", musicType = "Pop", year = new DateTime(1968), albumSales = 11000000 },
                new Sarkıcı{ SingerName = "Sezen", SingerSurname = "Aksu", musicType = "Pop", year = new DateTime(1975), albumSales = 20000000},
                new Sarkıcı { SingerName = "Funda", SingerSurname = "Arar", musicType = "Pop", year = new DateTime(1999), albumSales = 3000000 },
                new Sarkıcı { SingerName = "Sertab", SingerSurname = "Erener", musicType = "Pop", year = new DateTime(1992), albumSales = 5000000 },
                new Sarkıcı { SingerName = "Sıla", SingerSurname = "Gençoğlu", musicType = "Pop", year = new DateTime(2000), albumSales = 4000000 },
                new Sarkıcı { SingerName = "Serdar", SingerSurname = "Ortaç", musicType = "Pop", year = new DateTime(1994), albumSales = 10000000 },
                new Sarkıcı{ SingerName = "Tarkan", SingerSurname = "Tevetoglu", musicType = "Pop", year = new DateTime(1992), albumSales = 29000000},
                new Sarkıcı { SingerName = "Hande", SingerSurname = "Yener", musicType = "Pop", year = new DateTime(2000), albumSales = 7000000 },
                new Sarkıcı { SingerName = "Hadise", SingerSurname = "Açıkgöz", musicType = "Pop", year = new DateTime(2004), albumSales = 5000000 },
                new Sarkıcı { SingerName = "Gülben" , SingerSurname = "Ergen", musicType = "Pop", year = new DateTime(1992), albumSales = 10000000 },
                new Sarkıcı { SingerName = "Neşet", SingerSurname = "Ertaş", musicType = "Türk Halk Müziği", year = new DateTime(1970), albumSales = 2000000 },
            };

            //Adı S ile başlayan şarkıcıları listeleyiniz.

            var SileBaslayanSarkıcılar = Sarkıcılar.Where(s => s.SingerName.StartsWith("S")).ToList();
            foreach (var sarkıcı in SileBaslayanSarkıcılar)
            {
                Console.WriteLine("Adı S ile başlayan şarkıcılar:" +sarkıcı.SingerName+" "+sarkıcı.SingerSurname);
            }
            Console.WriteLine("-----------------SORU2--------------------------------");
            //Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
            var Albumsatısı = Sarkıcılar.Where(s => s.albumSales > 10000000).ToList();
            foreach (var sarkıcı in Albumsatısı)
            {
                Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:" + sarkıcı.SingerName + " " + sarkıcı.SingerSurname);
            }
            Console.WriteLine("-----------------SORU3--------------------------------");
           // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
           var oldschool = Sarkıcılar.Where(s => s.year.Year < 2000 && s.musicType == "Pop")
                                     .GroupBy(s=>s.year.Year)
                                     .OrderBy(g => g.Key)
                                     .ToList();
            foreach (var group in oldschool)
            {
                Console.WriteLine($"2000 yılı öncesi pop sanatçılar listesi");
                foreach (var sarkici in group.OrderBy(s => s.SingerName)) // Grup içi alfabetik sıralama
                {
                    Console.WriteLine($"  Şarkıcı: {sarkici.SingerName} {sarkici.SingerSurname} \n\t\t{sarkici.year:yyyy}");
                }
            }
           
            Console.WriteLine("-----------------SORU4--------------------------------");

            //En fazla albüm satışı yapan şarkıcıyı bulunuz.
            var max = Sarkıcılar.Max(s => s.albumSales);
            var enFazla = Sarkıcılar.Where(s => s.albumSales == max).ToList();
            foreach (var sarkıcı in enFazla)
            {
                Console.WriteLine("En fazla albüm satışı yapan şarkıcı:" + sarkıcı.SingerName + " " + sarkıcı.SingerSurname);
            }

            Console.WriteLine("-----------------SORU5--------------------------------");

            //En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
            var enYeni = Sarkıcılar.OrderByDescending(s => s.year).First();
            var enEski = Sarkıcılar.OrderBy(s => s.year).First();
            foreach (var sarkıcı in Sarkıcılar)
            {
                Console.WriteLine("En yeni çıkış yapan şarkıcı:" + enYeni.SingerName + " " + enYeni.SingerSurname);
                Console.WriteLine("En eski çıkış yapan şarkıcı:" + enEski.SingerName + " " + enEski.SingerSurname);
                break;
            }


















        }

    }
}
            
        
   
