using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak-2
            Console.WriteLine("Zadatak 2.");
            int prviBroj;
            int drugiBroj;
            int rezultat;

            Console.WriteLine("Unesite prvi broj");
            int.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite drugi broj");
            int.TryParse(Console.ReadLine(), out drugiBroj);

            rezultat = prviBroj + drugiBroj;

            if (prviBroj == 5 && drugiBroj == 5 || rezultat == 10)
            {
                Console.WriteLine("Zbroj iznosi 10!");
            }
            else if (prviBroj == 5 || drugiBroj == 5)
            {
                Console.WriteLine("Jedan od brojeva iznosi 5!");
            }
            else
            {
                Console.WriteLine("Zbroj iznosi: {0}", rezultat);
            }
        }
    }
}
