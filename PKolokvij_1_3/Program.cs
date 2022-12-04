using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_3
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

            if (prviBroj % 2 == 0 && drugiBroj % 2 == 0 && treciBroj % 2 == 0 && treciBroj != 12)
            {
                Console.WriteLine("Sva tri broja su parna!");
            }
            else if (prviBroj > 0 && drugiBroj > 0 && treciBroj == 12)
            {
                int produkt;
                produkt = prviBroj * drugiBroj * treciBroj;
                Console.WriteLine("Produkt brojeva je: {0}", produkt);
            }
            else if (prviBroj == 1 && drugiBroj == prviBroj && treciBroj == prviBroj)
            {
                Console.WriteLine("Svi brojevi su jednaki broju jedan.");
            }
            else
            {
                Console.WriteLine("Kraj.");
            }
        }
    }
}
