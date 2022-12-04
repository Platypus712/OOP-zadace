using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_8
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
                
                if (uneseniBroj % 10 != 0)
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

            foreach (int broj in popisBrojeva)
            {
                Console.Write(broj + ", ");
            }

        }
    }
}
