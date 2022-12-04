using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKolokvij_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> popisStanovnika = new List<string>();
            popisStanovnika.Add("Ana Anic");
            popisStanovnika.Add("Marko Markic");
            popisStanovnika.Add("Iva Ivic");
            popisStanovnika.Add("Tomo Tomic");

            while (true)
            {
                string uneseniStanovnik;
                Console.WriteLine("Unesite ime stanovnika koji se iselio: ");
                uneseniStanovnik = Console.ReadLine();

                if (uneseniStanovnik == "kraj") break;

                int indexStanovnika = popisStanovnika.IndexOf(uneseniStanovnik);

                if (indexStanovnika == -1)
                {
                    Console.WriteLine("Ne postoji stanovnik sa unesenim imenom.");
                }
                else
                {
                    popisStanovnika.Remove(uneseniStanovnik);
                }
            }

            Console.WriteLine("");
            int brojStanovnika;
            brojStanovnika = popisStanovnika.Count();
            Console.WriteLine("U selu je ostalo {0} stanovnika", brojStanovnika);

            foreach (string stanovnik in popisStanovnika)
            {
                Console.WriteLine(stanovnik);
            }

        }
    }
}
