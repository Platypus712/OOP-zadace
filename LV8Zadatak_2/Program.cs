//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int unos;
                Console.WriteLine("Unesite broj:");
                unos = int.Parse(Console.ReadLine());
                ParNepar provjeraParnosti = new ParNepar(unos);

                Console.WriteLine("\nProvjera parnosti: {0}", provjeraParnosti.parnost());
            }
        }
    }
}
