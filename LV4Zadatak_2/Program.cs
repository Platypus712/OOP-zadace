using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;

            Console.WriteLine("Unesite prvi broj: ");
            int.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite drugi broj: ");
            int.TryParse(Console.ReadLine(), out drugiBroj);

            int zbroj = prviBroj + drugiBroj;

            if (prviBroj == 5 && drugiBroj == 5 || zbroj == 10)
            {
                Console.WriteLine("Zbroj iznosi 10!");
            }
            else if (prviBroj == 5 || drugiBroj == 5)
            {
                Console.WriteLine("Jedan broj iznosi 5!");
            }
            else
            {
                Console.WriteLine("Zbroj iznosi: {0}", zbroj);
            }


        }
    }
}
