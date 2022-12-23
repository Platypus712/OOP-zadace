using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;
            int treciBroj;
            int zbroj;

            try
            {
                Console.WriteLine("Unesite prvi broj: ");
                prviBroj = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                drugiBroj = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite treci broj: ");
                treciBroj = int.Parse(Console.ReadLine());
                zbroj = prviBroj + drugiBroj + treciBroj;

                Console.WriteLine("\nZbroj unesenih brojeva iznosi: {0}", zbroj);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("\nNiste unijeli brojeve!!");
            }
            finally
            {
                Console.WriteLine("\nKraj programa!!");
            }
        }
    }
}
