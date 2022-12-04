using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mojaLista = new List<int>();

            while (true)
            {
                int unos;
                Console.WriteLine("Unesite element strukture: ");
                int.TryParse(Console.ReadLine(), out unos);
                if (unos == 0) break;
                mojaLista.Add(unos);
            }

            int najmanjiClan = mojaLista.Min();
            Console.WriteLine("Najmanji član je: {0}", najmanjiClan);

            mojaLista.Remove(najmanjiClan);
            foreach  (int broj in mojaLista)
            {
                Console.Write(broj);
            }

            Console.ReadKey();
        }
    }
}
