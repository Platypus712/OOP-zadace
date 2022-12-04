using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;

            while (true)
            {
                Console.WriteLine("Unesite prvi broj između 1 i 100: ");
                int.TryParse(Console.ReadLine(), out prviBroj);
                Console.WriteLine("Unesite drugi broj između 1 i 100: ");
                int.TryParse(Console.ReadLine(), out drugiBroj);

                if (prviBroj < 1 || prviBroj > 100)
                {
                    Console.WriteLine("Krivi unos");
                }
                else if (drugiBroj < 1 || drugiBroj > 100)
                {
                    Console.WriteLine("Krivi unos");
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine();

            if (prviBroj % 2 == 0 || drugiBroj % 2 == 0)
            {
                Console.WriteLine("Parni brojevi su: {0}, {1}", prviBroj, drugiBroj);
            }
            else
            {
                Console.WriteLine("Neparni brojevi su: {0}, {1}", prviBroj, drugiBroj);
            }

            //pitati profesora
        }
    }
}
