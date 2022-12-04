using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double prviBroj;
            double drugiBroj;

            Console.WriteLine("Unesite prvi broj: ");
            double.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite drugi broj: ");
            double.TryParse(Console.ReadLine(), out drugiBroj);

            int zbroj = (int)prviBroj + (int)drugiBroj;
            Console.WriteLine("Zbroj cjelobrojnih dijelova učitanih brojeva iznosi: {0}", zbroj);
        }
    }
}
