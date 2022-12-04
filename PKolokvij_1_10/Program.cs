using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> popisParnihBrojeva = new List<int>();
            List<int> popisNeparnihBrojeva = new List<int>();

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
                else if (uneseniBroj % 2 == 0)
                {
                    popisParnihBrojeva.Add(uneseniBroj);
                }
                else
                {
                    popisNeparnihBrojeva.Add(uneseniBroj);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Parni brojevi su: ");
            foreach (int broj in popisParnihBrojeva)
            {
                Console.WriteLine(broj);
            }

            Console.WriteLine("\nNeparni brojevi su: ");
            foreach (int broj in popisNeparnihBrojeva)
            {
                Console.WriteLine(broj);
            }

        }
    }
}
