using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int prvaOcjena;
            int drugaOcjena;
            int trecaOcjena;
            int prosjecnaOcjena;

            Console.WriteLine("Unesite prvu ocjenu: ");
            int.TryParse(Console.ReadLine(), out prvaOcjena);

            Console.WriteLine("Unesite drugu ocjenu: ");
            int.TryParse(Console.ReadLine(), out drugaOcjena);

            Console.WriteLine("Unesite trecu ocjenu: ");
            int.TryParse(Console.ReadLine(), out trecaOcjena);

            prosjecnaOcjena = (prvaOcjena + drugaOcjena + trecaOcjena) / 3;

            if (prvaOcjena == 0 || drugaOcjena == 0 || trecaOcjena == 0)
            {
                Console.WriteLine("Unijeli ste 0 za neku od ocjena!!!");
            }
            else if (prvaOcjena > 5 || drugaOcjena > 5 || trecaOcjena > 5)
            {
                Console.WriteLine("Unijeli ste pogrešnu vrijednost za neku od ocjena!!");
            }
            else if (prosjecnaOcjena == 5)
            {
                Console.WriteLine("Prosječna ocjena je: izvrstan {0}", prosjecnaOcjena);
            }
            else if (prosjecnaOcjena == 4)
            {
                Console.WriteLine("Prosječna ocjena je: vrlo dobar {0}", prosjecnaOcjena);
            }
            else if (prosjecnaOcjena == 3)
            {
                Console.WriteLine("Prosječna ocjena je: dobar {0}", prosjecnaOcjena);
            }
            else if (prosjecnaOcjena == 2)
            {
                Console.WriteLine("Prosječna ocjena je: dovoljan {0}", prosjecnaOcjena);
            }
            else if (prosjecnaOcjena == 1)
            {
                Console.WriteLine("Prosječna ocjena je: nedovoljan {0}", prosjecnaOcjena);
            }
        }
    }
}
