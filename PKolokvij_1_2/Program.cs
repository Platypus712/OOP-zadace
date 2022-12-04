using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_2
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

            if (prviBroj == drugiBroj && prviBroj == treciBroj)
            {
                Console.WriteLine("Sva tri broja su jednaka!");
            }
            else if (prviBroj % 2 == 0 && drugiBroj % 2 != 0 && treciBroj % 2 != 0)
            {
                int suma;
                suma = prviBroj + drugiBroj + treciBroj;
                Console.WriteLine("Suma brojeva je: {0}", suma);
            }
            else if (prviBroj < 10 && drugiBroj < 10 && treciBroj < 10)
            {
                int produkt;
                produkt = prviBroj * drugiBroj * treciBroj;
                Console.WriteLine("Produkt brojeva je: {0}", produkt);
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
