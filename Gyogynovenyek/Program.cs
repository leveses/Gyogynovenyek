using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Noveny> lista = new List<Noveny>();
        static Dictionary<string, int> konyvtar = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            Beolvas();
            NovenyekSzama();
            Gyujtheto();
            Ido();
            Atlag();
            Console.ReadLine();
        }

        private static void Atlag()
        {
            double sum = 0;
            foreach (var i in lista)
            {
                sum += i.Idotartam;
            }
            Console.WriteLine($"Átlagosan gyűjthető időtartam: {sum/lista.Count}");
        }

        static void NovenyekSzama()
        {
            Console.WriteLine($"1. feladat: Növények száma: {lista.Count()}");
        }
        static void Beolvas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                lista.Add(new Noveny(file.ReadLine()));
            }
            file.Close();
        }
        static void Gyujtheto()
        {
            
            foreach (var i in lista)
            {
                if (!konyvtar.ContainsKey(i.Resz))
                {
                    konyvtar.Add(i.Resz, 0);
                    
                }
                
            }
            foreach (var i in lista)
            {
                konyvtar[i.Resz]++;
            }
            foreach (var d in konyvtar)
            {
                Console.WriteLine($"{d.Key}: {d.Value}");
            }
        }
        static void Ido()
        {
            int max = 0;
            foreach (var i in lista)
            {
                if (max< i.Idotartam)
                {
                    max = i.Idotartam;
                }
                
            }
            Console.WriteLine($"A legtöbb ideig szedhető: {max}");
            Console.WriteLine("Növények: ");
            foreach (var i in lista)
            {
                if (i.Idotartam==max)
                {
                    Console.WriteLine(i.Nev);
                }
            }
            


        }


    }
}
