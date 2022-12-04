using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;
            int treciBroj;

            Console.WriteLine("Unesite prvi broj: ");
            int.TryParse(Console.ReadLine(), out prviBroj);

            Console.WriteLine("Unesite drugi broj: ");
            int.TryParse(Console.ReadLine(), out drugiBroj);

            Console.WriteLine("Unesite treci broj: ");
            int.TryParse(Console.ReadLine(), out treciBroj);

            if (prviBroj < 0 && drugiBroj < 0 && treciBroj < 0)
            {
                Console.WriteLine("Svi brojevi su manji od nule.");
            }
            else if (prviBroj == 0 && drugiBroj > 0 && treciBroj > 0)
            {
                int suma;
                suma = drugiBroj + treciBroj;
                Console.WriteLine("Suma zadnja dva broja je: {0}", suma);
            }
            else if (prviBroj > 0 && drugiBroj > 0 && treciBroj > 0)
            {
                int produkt;
                produkt = prviBroj * drugiBroj * treciBroj;
                Console.WriteLine("Produkt je: {0}", produkt);
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
