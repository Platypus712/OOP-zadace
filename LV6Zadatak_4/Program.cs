using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> mojaLista = unosBrojeva();
            Console.WriteLine("Aritmetička sredina unesenih brojeva je: {0}", aritmetickaSredina(mojaLista));
        }

        private static List<decimal> unosBrojeva()
        {
            List<decimal> mojaLista = new List<decimal>();
            while (true)
            {
                decimal broj;
                Console.WriteLine("Unesite decimalni broj: ");
                broj = decimal.Parse(Console.ReadLine());
                if (broj != 0)
                {
                    mojaLista.Add(broj);
                }
                else
                {
                    break;
                }

                
            }
            return mojaLista;
        }

        private static decimal aritmetickaSredina(List<decimal> mojaLista)
        {
            return mojaLista.Average();
        }
    }
}
