using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringZnak;
            int brojRedova;

            Console.WriteLine("Unesite znak koji želite ispisati u shemu trokuta:");
            stringZnak = Console.ReadLine();
            Console.WriteLine("Unesite broj redova koji želite ispisati:");
            int.TryParse(Console.ReadLine(), out brojRedova);

            for (int i = brojRedova; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(stringZnak); ;
                }
                Console.WriteLine();
            }
        }
    }
}
