using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvaOcjena;
            int drugaOcjena;
            int trecaOcjena;

            Console.WriteLine("Unesite prvu ocjenu: ");
            int.TryParse(Console.ReadLine(), out prvaOcjena);
            Console.WriteLine("Unesite drugu ocjenu: ");
            int.TryParse(Console.ReadLine(), out drugaOcjena);
            Console.WriteLine("Unesite trecu ocjenu: ");
            int.TryParse(Console.ReadLine(), out trecaOcjena);

            int prosjecnaOcjena = (prvaOcjena + drugaOcjena + trecaOcjena) / 3;

            if (prosjecnaOcjena > 5 || prosjecnaOcjena <= 0)
            {
                Console.WriteLine("Krivi unos ocjena!");
            }
            else if (prosjecnaOcjena == 5)
            {
                Console.WriteLine("Izvrstan");
            }
            else if (prosjecnaOcjena == 4)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (prosjecnaOcjena == 3)
            {
                Console.WriteLine("Dobar");
            }
            else if (prosjecnaOcjena == 2)
            {
                Console.WriteLine("Dovoljan");
            }
            else
            {
                Console.WriteLine("Nedovoljan");
            }


        }
    }
}
