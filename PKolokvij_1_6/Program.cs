using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            string stringBroj = "";
            string obrnutiIspis = "";

            Console.WriteLine("Unesite broj: ");
            stringBroj = Console.ReadLine();

            broj = int.Parse(stringBroj);

            if (broj > 0 && stringBroj.Length == 3)
            {
                for (int i = stringBroj.Length - 1; i >= 0; i--)
                {
                    obrnutiIspis += stringBroj[i];
                }

                Console.WriteLine("Za uneseni broj {0}, obrnuti redoslijed glasi: {1}", broj, obrnutiIspis);
            }
            else
            {
                Console.WriteLine("Krivi unos.");
            }
            
        }
    }
}
