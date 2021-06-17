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
        }
    }
}
