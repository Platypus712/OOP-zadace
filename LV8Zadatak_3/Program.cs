//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            NovaOsoba novaOsoba = new NovaOsoba("Nikola", "Pustišek",7,12,2000);
            Console.WriteLine("Unesena osoba ima {0} godina/e", novaOsoba.starost());
        }
    }
}
