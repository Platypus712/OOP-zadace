using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak-1
            Console.WriteLine("Zadatak 1.");
            int prviBroj;
            int drugiBroj;
            int rezultat;

            Console.WriteLine("Unesite prvi broj");
            int.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite drugi broj");
            int.TryParse(Console.ReadLine(), out drugiBroj);

            rezultat = prviBroj + drugiBroj;

            if (rezultat%2==0)
            {
                Console.WriteLine("Ukupan zbroj iznosi: {0} i to je pozitivan broj", rezultat);
            }
            else
            {
                Console.WriteLine("Ukupan zbroj iznosi: {0} i to je negativan broj", rezultat);
            }
        }
    }
}
