using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;

            Console.WriteLine("Unesite broj: ");
            int.TryParse(Console.ReadLine(), out broj);

            Console.WriteLine("Uneseni broj u heksadekadskom sustavu iznosi: {0:X}", broj);
        }
    }
}
