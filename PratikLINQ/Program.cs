using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { -3, -2, -1, 1, 2, 3, 4, 16, 17, 18, 19 };

        // Pozitif sayıları yazdırma
        Console.WriteLine("Pozitif Sayılar:");
        var pozyNumbers = numbers.Where(n => n > 0);
        foreach (var pozy in pozyNumbers)
        {
            Console.WriteLine(pozy);
        }

        Console.WriteLine("*******************");

        // Negatif sayıları yazdırma
        Console.WriteLine("Negatif Sayılar:");
        var negaNumbers = numbers.Where(n => n < 0);
        foreach (var nega in negaNumbers)
        {
            Console.WriteLine(nega);
        }

        Console.WriteLine("*******************");

        // Tek sayıları yazdırma
        Console.WriteLine("Tek Sayılar:");
        var tekNumbers = numbers.Where(n => n % 2 != 0);
        foreach (var tek in tekNumbers)
        {
            Console.WriteLine(tek);
        }

        Console.WriteLine("*******************");

        // Çift sayıları yazdırma
        Console.WriteLine("Çift Sayılar:");
        var ciftNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var cift in ciftNumbers)
        {
            Console.WriteLine(cift);
        }

        Console.WriteLine("*******************");

        // 15-22 arasındaki sayıları yazdırma
        Console.WriteLine("15-22 Arasındaki Sayılar:");
        var rangeNumbers = numbers.Where(n => n >= 15 && n <= 22);
        foreach (var num in rangeNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("*******************");
        //Listedeki her bir sayının karesi
        numbers.Select(n => n * n).ToList().ForEach(n => Console.WriteLine(n));

    }
}
