using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_11
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

                if (uneseniBroj <= 0)
                {
                    Console.WriteLine("Krivi unos!");
                }
                else
                {
                    popisBrojeva.Add(uneseniBroj);
                }
            }

            Console.WriteLine();

            foreach (int broj in popisBrojeva)
            {
                Console.WriteLine(broj);
            }

            int umnozak = 1;

            foreach (int broj in popisBrojeva)
            {
                umnozak *= broj;
            }

            Console.Write("\nProdukt unesenih brojeva iznosi: {0}\n", umnozak);

        }
    }
}
