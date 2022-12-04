using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double prviBroj;
            double drugiBroj;
            double zbrajanje;
            double oduzimanje;
            double mnozenje;

            Console.WriteLine("Unesite prvi broj: ");
            double.TryParse(Console.ReadLine(), out prviBroj);
            
            Console.WriteLine("Unesite drugi broj: ");
            double.TryParse(Console.ReadLine(), out drugiBroj);

            zbrajanje = prviBroj + drugiBroj;
            oduzimanje = prviBroj - drugiBroj;
            mnozenje = prviBroj * drugiBroj;

            if (prviBroj < drugiBroj)
            {
                Console.WriteLine("Zbroj unesenih brojeva iznosi: {0}", zbrajanje);
            }
            else if (prviBroj > drugiBroj)
            {
                Console.WriteLine("Razlika unesenih brojeva iznosi: {0}", oduzimanje);
            }
            else
            {
                Console.WriteLine("Umnožak unesenih brojeva iznosi: {0}", mnozenje);
            }
        }
    }
}
