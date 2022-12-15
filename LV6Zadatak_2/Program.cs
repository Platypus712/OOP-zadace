using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mojaLista = new List<int>();

            while (true)
            {
                int broj;
                Console.WriteLine("Unesite cijeli broj: ");
                broj = int.Parse(Console.ReadLine());
                if (broj != 0)
                {
                    mojaLista.Add(broj);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Najveci upisani broj je: {0}", najveci(mojaLista));
            Console.WriteLine("Najmanji upisani broj je: {0}", najmanji(mojaLista));
            Console.WriteLine("Aritmetička sredina upisanih brojeva je: {0}", aritmetickaSredina(mojaLista));
        }

        private static int najveci(List<int> mojaLista)
        {
            return mojaLista.Max();
        }

        private static int najmanji(List<int> mojaLista)
        {
            return mojaLista.Min();
        }

        private static double aritmetickaSredina(List<int> mojaLista)
        {
            double aritmetickaSredina = mojaLista.Average();
            return aritmetickaSredina;
        }
    }
}
