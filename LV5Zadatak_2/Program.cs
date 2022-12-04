using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            int zbroj = 0;
            int brojBrojeva = 0;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out broj);

                if (broj == 0)
                {
                    break;
                }
                else
                {
                    zbroj += broj;
                    brojBrojeva++;
                }
            }

            double aritmetickaSredina = (double)zbroj / brojBrojeva;

            Console.WriteLine("Aritmetička sredina unesenih brojeva iznosi: {0}", aritmetickaSredina);
        }
    }
}
