using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float broj;
            Console.WriteLine("Unesite neki broj: ");
            float.TryParse(Console.ReadLine(), out broj);

            if (broj < 0)
            {
                Console.WriteLine("Krivi unos");
            }
            else if (broj == 0)
            {
                Console.WriteLine("Unijeli ste nulu!");
            }
            else
            {
                int cjelobrojniDio = (int)(Math.Truncate(broj));
                decimal decimalniDio = (decimal)(broj - cjelobrojniDio);
                Console.WriteLine("Cjelobrojni dio broja {0} je: {1}", broj, cjelobrojniDio);
                Console.WriteLine("Decimalni dio broja {0} je: {1}", broj, decimalniDio);
            }

        }
    }
}
