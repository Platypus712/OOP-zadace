using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesite broj: ");
                int unos = int.Parse(Console.ReadLine());
                brojevi[i] = unos;
            }

            duzinaStringa(brojevi);
            zadnjaZnamenka7(brojevi);
            ispis(brojevi);
        }

        private static int duzinaStringa(int[] brojevi)
        {
            int brojac = 0;

            foreach (int broj in brojevi)
            {
                string stringBroj = broj.ToString();

                if (stringBroj.Length == 2 || stringBroj.Length == 3)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        private static int zadnjaZnamenka7(int[] brojevi)
        {
            int brojac = 0;
            int zadnjaZnamenka;

            foreach (int broj in brojevi)
            {
                zadnjaZnamenka = broj % 10;
                if (zadnjaZnamenka == 7)
                {
                    brojac++;
                }
            }
            return brojac;
        }

        private static void ispis(int[] brojevi)
        {
            Console.WriteLine("Broj dvoznamenkastih i troznamenkastih brojeva je: {0}", duzinaStringa(brojevi));
            Console.WriteLine("U strukturi postoji {0} brojeva koji imaju zadnju znamenku 7", zadnjaZnamenka7(brojevi));
        }
    }
}
