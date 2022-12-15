using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double polumjer;
            Console.WriteLine("Unesite polumjer: ");
            polumjer = int.Parse(Console.ReadLine());
            Console.WriteLine("Površina kruga za zadani polumjer iznosi: {0}", povKru(polumjer));
        }

        private static double povKru(double r)
        {
            double povrsinaKruga;
            if (r <= 0)
            {
                povrsinaKruga = -1;
            }
            else
            {
                povrsinaKruga = Math.Pow(r, 2.0) * Math.PI;
            }

            return povrsinaKruga;
        }
    }
}
