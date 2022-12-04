using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 1. - dijeljenje 10 s 3\n");

            int zad1_dijeljenje = 10 / 3;
            Console.WriteLine(zad1_dijeljenje);
            
            Console.WriteLine("\nZadatak 2. - pretvorba formule u zapis\n");

            float zad2_x = ((float)(4 + 5) / 6);
            Console.WriteLine(zad2_x);
            
            Console.WriteLine("\nZadatak 3. - ispis jedinica, desetica i stotica\n");

            int zad3_zadaniBroj = 184;
            int zad3_zadaniBrojJedinice = zad3_zadaniBroj % 10;
            int zad3_zadaniBrojDesetice = (zad3_zadaniBroj / 10) % 10;
            int zad3_zadaniBrojStotice = zad3_zadaniBroj / 100;
            Console.WriteLine("Za broj: {0} ovo vrijedi\nJedinica: {1}, desetica: {2}, stotica: {3}", zad3_zadaniBroj, zad3_zadaniBrojJedinice, zad3_zadaniBrojDesetice, zad3_zadaniBrojStotice);

            Console.WriteLine("\nZadatak 4. - pretvorba formule u zapis\n");

            float zad4_x = ((float) 22 + (17 / 2) - (5 % 2));
            Console.WriteLine(zad4_x);

            Console.WriteLine("\nZadatak 5. - ispis minuta, sekundi i stotinka\n");

            double zad5_zadaniBroj = 154.5;
            int zad5_zadaniBrojminute = ((int)(zad5_zadaniBroj / 60));
            int zad5_zadaniBrojsekunde = ((int)(zad5_zadaniBroj % 60));
            Console.WriteLine("Za broj: {0} ovo vrijedi\nMinute: {1}, sekunde: {2}", zad5_zadaniBroj, zad5_zadaniBrojminute, zad5_zadaniBrojsekunde);

            Console.WriteLine("\nZadatak 6. - pretvorba formule u zapis\n");

            float zad6_O = 3 * 1.5F;
            Console.WriteLine(zad6_O);

            Console.WriteLine("\nZadatak 7. - pretvorba formule u zapis\n");

            float zad7_x = ((float)4 + (5 / 10) - 6 + (7 * (4 % 2)));
            Console.WriteLine(zad7_x);

            Console.WriteLine("\nZadatak 8. - pretvorba formule u zapis\n");

            float zad8_x = ((float)4 + (5 / (10 - 6)) + (7 * (4 % 2)));
            Console.WriteLine(zad8_x);

            Console.ReadKey();
        }
    }
}
