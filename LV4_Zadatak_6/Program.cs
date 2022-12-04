using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mojaLista = new List<int>();

            while (true)
            {
                int unos;
                Console.WriteLine("Unesite broj: ");
                int.TryParse(Console.ReadLine(), out unos);
                if (unos > -10 && unos < 10 ) break;
                mojaLista.Add(unos);
            }

            int brojac = 0;
            foreach (int broj in mojaLista)
            {
                if (broj % 5 == 0)
                {
                    brojac++;
                }
                Console.Write(" " + broj);
            }

            Console.WriteLine("\nDijeljivih s pet je {0}", brojac);

            Console.ReadKey();
        }
    }
}
