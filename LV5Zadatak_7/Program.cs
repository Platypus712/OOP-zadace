using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int uneseniBroj;
            int brojac = 0;

            while (true)
            {
                Console.WriteLine("Unesite brojeve unutar intervala od -200 do 200: ");
                int.TryParse(Console.ReadLine(), out uneseniBroj);

                if (uneseniBroj < -200 || uneseniBroj > 200)
                {
                    break;
                }
                else
                {
                    brojac++;
                }
            }

            Console.WriteLine("Unijeli ste {0} broja/eva", brojac);
        }
    }
}
