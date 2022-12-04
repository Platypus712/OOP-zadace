using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviZnak;

            Console.WriteLine("Unesite neki znak: ");
            int.TryParse(Console.ReadLine(), out prviZnak);

            int znakPrije = prviZnak - 1;
            int znakPoslije = prviZnak + 1;

            Console.WriteLine("Uneseni znak je: " + prviZnak + ", a znakovi prije i poslije su: {0},{1}", znakPrije, znakPoslije);
        }
    }
}
