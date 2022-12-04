using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;

            Console.WriteLine("Unesite ocjenu: ");
            int.TryParse(Console.ReadLine(), out ocjena);

            if (ocjena > 5)
            {
                Console.WriteLine("Pogrešan unos!");
            }
            else if (ocjena == 5)
            {
                Console.WriteLine("Ocjena 5 je izvrstan!");
            }
            else if (ocjena == 4)
            {
                Console.WriteLine("Ocjena 4 je vrlo dobar");
            }
            else if (ocjena == 3)
            {
                Console.WriteLine("Ocjena 3 je dobar");
            }
            else if (ocjena == 2)
            {
                Console.WriteLine("Ocjena 2 je dovoljan!");
            }
            else if (ocjena == 1)
            {
                Console.WriteLine("Ocjena 1 je nedovoljan!");
            }
            else
            {
                Console.WriteLine("Unijeli ste 0!");
            }
        }
    }
}
