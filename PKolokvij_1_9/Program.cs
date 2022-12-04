using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> popisBrojeva = new List<int>();

            while (true)
            {
                int uneseniBroj;
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out uneseniBroj);
                if (uneseniBroj == 0) break;

                if (uneseniBroj < 1 || uneseniBroj > 100)
                {
                    Console.WriteLine("Krivi unos!");
                }
                else
                {
                    popisBrojeva.Add(uneseniBroj);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < popisBrojeva.Count; i+=2)
            {
                Console.WriteLine(popisBrojeva[i]);
            }

        }
    }
}
