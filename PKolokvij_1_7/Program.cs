using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            string stringBroj;

            Console.WriteLine("Unesite broj:");
            stringBroj = Console.ReadLine();
            broj = int.Parse(stringBroj);

            if (broj > 0 && stringBroj.Length == 2)
            {
                int desnaZnamenka = broj % 10;
                int lijevaZnamenka = (int)(Math.Truncate((decimal)broj / 10));
                if (lijevaZnamenka % desnaZnamenka == 0)
                {
                    Console.WriteLine("{0} je djeljivo s {1}!", lijevaZnamenka, desnaZnamenka);
                }
                else
                {
                    Console.WriteLine("{0} nije djeljivo s {1}!", lijevaZnamenka, desnaZnamenka);
                }
            }
            else
            {
                Console.WriteLine("Krivi unos.");
            }
        }
    }
}
