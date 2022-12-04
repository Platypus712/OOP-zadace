using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;

            Console.WriteLine("Unesite duljinu jedne katete: ");
            int.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite duljinu druge katete: ");
            int.TryParse(Console.ReadLine(), out drugiBroj);

            int povrsina = (prviBroj + drugiBroj) / 2;

            if (prviBroj <= 0 || drugiBroj <= 0)
            {
                Console.WriteLine("Krivi unos vrijednosti!");
            }
            else
            {
                Console.WriteLine("Površina pravokutnog trokuta iznosi: {0}", povrsina);
            }


        }
    }
}
