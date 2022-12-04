using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime;
            string prezime;

            Console.WriteLine("Unesite svoje ime: ");
            ime = Console.ReadLine();
            Console.WriteLine("Unesite svoje prezime: ");
            prezime = Console.ReadLine();

            Console.WriteLine("Vaše puno ime i prezime iznosi: {0} {1}", ime, prezime);
        }
    }
}
