using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;

            Console.WriteLine("Unesite vrijednost za a: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Unesite vrijednost za b: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Unesite vrijednost za c: ");
            int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Unesite vrijednost za d: ");
            int.TryParse(Console.ReadLine(), out d);
            Console.WriteLine("Unesite vrijednost za e: ");
            int.TryParse(Console.ReadLine(), out e);

            double asredina = (double)(a + b + c + d + e) / 5;

            Console.WriteLine("Aritmetička sredina unesenih brojeva iznosi: {0}", asredina);

        }
    }
}
