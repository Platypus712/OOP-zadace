using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string uneseniString;
            int uneseniBroj;
            int brojBrojeva = 0;

            do
            {
                Console.WriteLine("Unesite broj: ");
                uneseniString = Console.ReadLine();
                uneseniBroj = int.Parse(uneseniString);

                if (uneseniBroj % 7 == 0)
                {
                    break;
                }
                else if (uneseniString.Length == 2)
                {
                    brojBrojeva++;
                }
            } while (true);

            Console.WriteLine("Unijeli ste {0} dvoznamenkastih brojeva!", brojBrojeva);
        }
    }
}
