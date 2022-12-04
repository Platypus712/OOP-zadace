using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_1
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

            //int duljinuListe = mojaLista.Count - 1;
            //for (int i = duljinuListe; i >= 0 ; i--)
            //{
            //    Console.WriteLine(mojaLista[i]);
            //}

            mojaLista.Reverse();
            foreach (int broj in mojaLista)
            {
                Console.WriteLine(broj);
            }

            Console.ReadKey();
        }
    }
}
