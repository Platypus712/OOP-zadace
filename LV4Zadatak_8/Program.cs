using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_8
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

            if (prviBroj < drugiBroj)
            {
                int zbroj = prviBroj + drugiBroj;
                Console.WriteLine("Zbroj unesenih brojeva iznosi: {0}", zbroj);
            }
            else if (prviBroj > drugiBroj)
            {
                int razlika = prviBroj - drugiBroj;
                Console.WriteLine("Razlika unesenih brojeva iznosi: {0}", razlika);
            }
            else
            {
                int umnozak = prviBroj * drugiBroj;
                Console.WriteLine("Umnožak unesenih brojeva iznosi: {0}",umnozak);
            }


        }
    }
}
