using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena;

            Console.WriteLine("Unesite ocjenu: ");
            int.TryParse(Console.ReadLine(), out ocjena);

            if (ocjena > 5 || ocjena <= 0)
            {
                Console.WriteLine("Krivi unos!");
            }
            else if (ocjena == 5)
            {
                Console.WriteLine("Izvrstan");
            }
            else if (ocjena == 4)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (ocjena == 3)
            {
                Console.WriteLine("Dobar");
            }
            else if (ocjena == 2)
            {
                Console.WriteLine("Dovoljan");
            }
            else
            {
                Console.WriteLine("Nedovoljan");
            }


        }
    }
}
