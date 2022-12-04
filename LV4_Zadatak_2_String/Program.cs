using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_2_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string poruka;
            Console.WriteLine("Unesite poruku: ");
            poruka = Console.ReadLine();

            string malaSlova = poruka.ToLower();
            Console.WriteLine("Upisani string malim slovima: {0}", malaSlova);

            Console.ReadKey();
        }
    }
}
