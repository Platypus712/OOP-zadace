using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_9
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
                Console.WriteLine();
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
