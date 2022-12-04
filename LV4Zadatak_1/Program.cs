using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_1
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

            if (zbroj > 0)
            {
                Console.WriteLine("Zbroj je pozitivan broj");
            }
            else if (zbroj < 0)
            {
                Console.WriteLine("Zbroj je negativan broj");
            }
            else
            {
                Console.WriteLine("Zbroj je jednak nuli!");
            }


        }
    }
}
