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
        }
    }
}
