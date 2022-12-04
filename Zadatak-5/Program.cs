using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double katetaA;
            double katetaB;
            double povrsinaPTrokuta;

            Console.WriteLine("Unesite vrijednost za katetu a: ");
            double.TryParse(Console.ReadLine(), out katetaA);
            
            Console.WriteLine("Unesite vrijednost za katetu b: ");
            double.TryParse(Console.ReadLine(), out katetaB);

            povrsinaPTrokuta = (katetaA * katetaB) / 2;

            if (katetaA <= 0 || katetaB <= 0)
            {
                Console.WriteLine("Unesene vrijednosti moraju biti pozitivne i različite od nule!!!");
            }
            else
            {
                Console.WriteLine("Površina pravokutnog trokuta iznosi: {0}", povrsinaPTrokuta);
            }
        }
    }
}
