using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Bérek2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Dolgozó> dolgozok = new List<Dolgozó>();
            foreach (var sor in File.ReadAllLines("bérek2020.txt").Skip(1))
                dolgozok.Add(new Dolgozó(sor));
            
            //3.
            Console.WriteLine($"3. feladat: Dolgozók száma: {dolgozok.Count} fő");

            //4.
            Console.WriteLine($"4. feladat: Bérek átlaga: {(dolgozok.Average(x => x.Bér) / 1000):0.0} eFt");

            //5.
            Console.Write("5. feladat: Kérem egy részleg nevét: ");
            string részleg = Console.ReadLine();

            //6.
            if (dolgozok.Any(x => x.Részleg == részleg))
            {
                Dolgozó d = dolgozok.Where(x => x.Részleg == részleg).OrderBy(x => x.Bér).Last();
                Console.WriteLine("6. feladat: A legtöbbet kereső dolgozó a megadott részlegen");
                Console.WriteLine($"\t Név: {d.Név}");
                Console.WriteLine($"\t Neme: {d.Nem}");
                Console.WriteLine($"\t Belépés: {d.BelépésÉve}");
                Console.WriteLine($"\t Bér: {d.Bér.ToString("# ##0")} Forint");
            }
            else
            {
                Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél");
            }

            //7.
            Console.WriteLine("7. feladat: Statisztika");
            dolgozok
                .GroupBy(x => x.Részleg)
                .Select(gr => new { Név = gr.Key, Létszám = gr.Count() })
                .ToList()
                .ForEach(x => Console.WriteLine($"\t {x.Név} - {x.Létszám} fő"));

        }
    }
}
