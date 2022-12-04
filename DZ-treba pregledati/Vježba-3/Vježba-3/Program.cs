using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1. - zbroj unesenih brojeva\n");

            int zad1_prviBroj, zad1_drugiBroj, zad1_treciBroj;

            Console.WriteLine("\nUnesite prvi broj: ");
            zad1_prviBroj = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nUnesite drugi broj: ");
            zad1_drugiBroj = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nUnesite treći broj: ");
            zad1_treciBroj = int.Parse(Console.ReadLine());

            int zad1_rezultat = zad1_prviBroj + zad1_drugiBroj + zad1_treciBroj;

            Console.WriteLine("\nOvo je zbroj svih unesenih brojeva: " + zad1_rezultat);

            Console.WriteLine("\nZadatak 2. - ispis jednog znaka\n");

            int zad2_Znak;

            Console.WriteLine("\nUpišite znak iz Unicode tablice: ");
            zad2_Znak = Console.Read();

            int zad2_znakPoslije = zad2_Znak + 1;
            int zad2_znakPrije = zad2_Znak - 1;

            Console.WriteLine("\nOvo je upisani znak: " + ((char)zad2_Znak) + ", a ovo je znak prije: " + ((char)zad2_znakPrije) + ", a ovo poslije: " + ((char)zad2_znakPoslije));
            
            Console.WriteLine("\nZadatak 3. - zbroj unesenih brojeva\n");


            Console.WriteLine("\nZadatak 4. - ispis imena i prezimena\n");

            string ime, prezime;

            Console.Write("Upišite svoje ime: ");
            ime = Console.ReadLine();

            Console.Write("Upišite svoje prezime: ");
            prezime = Console.ReadLine();

            Console.WriteLine("Bok, {0} {1}!", ime, prezime);


            Console.ReadKey();
        }
    }
}
