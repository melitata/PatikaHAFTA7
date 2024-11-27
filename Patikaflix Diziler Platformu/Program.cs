using Patikaflix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Patikaflix
{
    public class ComedyShow
    {
        public string ShowName { get; set; }
        public string ShowType { get; set; }
        public string Director { get; set; }
    }
    public class Program
    {
        private static int? showYear;
        private static int? showBeginningYear;

        public static void Main()
        {
            List<Shows> patikaflix = new List<Shows>();

            Console.WriteLine($"Patikaflix'e hoşgeldiniz!\t\nArtık en sevdiğiniz dizileri kolayca listeyebilirsiniz :)");
            while (true)
            {
                Console.WriteLine("Lütfen eklemek istediğiniz dizinin bilgilerini giriniz.");

                Shows show = new Shows();


                Console.Write("Şov Adı: ");
                show.ShowName = Console.ReadLine();

                Console.Write("Şov Türü: ");
                show.ShowType = Console.ReadLine();

                Console.Write("Yılı: ");
                while (!int.TryParse(Console.ReadLine(), out int showYear))
                {
                    Console.WriteLine("Geçerli bir yıl giriniz: ");
                }

                show.ShowYear = showYear;

                Console.Write("Başlangıç Yılı: ");
                while (!int.TryParse(Console.ReadLine(), out int showBeginningYear))
                {
                    Console.WriteLine("Geçerli bir başlangıç yılı giriniz: ");
                }
                show.ShowBeginningYear = showBeginningYear;
                Console.Write("Yönetmen: ");
                show.Director = Console.ReadLine();

                Console.Write("Platform: ");
                show.ShowPlatform = Console.ReadLine();

                patikaflix.Add(show); // Listeye ekle
                Console.WriteLine("Şov başarıyla eklendi.\n");
                Console.Write("Başka bir şov eklemek ister misiniz? (E/H): ");
                string choice = Console.ReadLine().Trim().ToUpper();
                if (choice == "H")
                {
                    break;
                }

            }
            Console.WriteLine("\nEklenen şovlar:");
            foreach (var s in patikaflix)
            {
                Console.WriteLine($"Ad: {s.ShowName}, Tür: {s.ShowType}, Yıl: {s.ShowYear}, Başlangıç Yılı: {s.ShowBeginningYear}, Yönetmen: {s.Director}, Platform: {s.ShowPlatform}");
            }
            //KOMEDİ TÜRLERİ
            var comedyShows = patikaflix
                .Where(s => s.ShowType == "Komedi").ToList()
                .Select(s => new ComedyShow
                {
                    ShowName = s.ShowName,
                    ShowType = s.ShowType,
                    Director = s.Director
                })
                .OrderBy(s => s.ShowName)
                .ThenBy(s => s.Director).ToList()
                .ToList();
            Console.WriteLine("\nKomedi türündeki şovlar:");
            foreach (var comedy in comedyShows)
            {
                Console.WriteLine($"Dizi Adı: {comedy.ShowName}, Tür: {comedy.ShowType}, Yönetmen: {comedy.Director}");

            }

        }
    }
}