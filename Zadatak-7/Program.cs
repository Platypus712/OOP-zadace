using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            
            Console.WriteLine("Provjerite parnost ili neparnost unesenog broja: ");
            int.TryParse(Console.ReadLine(), out broj);

            if (broj % 2 == 0)
            {
                Console.WriteLine("Uneseni broj je: {0} i to je paran broj", broj);
            }
            else
            {
                Console.WriteLine("Uneseni broj je: {0} i to je neparan broj", broj);
            }
        }
    }
}
