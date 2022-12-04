using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;
            int treciBroj;

            Console.WriteLine("Unesite prvi broj: ");
            int.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite drugi broj: ");
            int.TryParse(Console.ReadLine(), out drugiBroj);
            Console.WriteLine("Unesite treci broj: ");
            int.TryParse(Console.ReadLine(), out treciBroj);

            int suma = prviBroj + drugiBroj + treciBroj;
            Console.WriteLine("\nSuma unesenih brojeva iznosi: {0}", suma);
        }
    }
}
