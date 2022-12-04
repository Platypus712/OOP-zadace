using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int uneseniBroj;

            Console.WriteLine("Unesite broj veći od 1: ");
            int.TryParse(Console.ReadLine(), out uneseniBroj);

            for (int i = 1; i <= uneseniBroj; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.WriteLine();
                    Console.Write(i);
                }
                
            }
            Console.WriteLine();
        }
    }
}
