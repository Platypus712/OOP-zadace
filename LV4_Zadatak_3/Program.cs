using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_3
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
                if (unos == 0) break;
                if (unos > 0) mojaLista.Add(unos);
            }

            int zbroj = mojaLista.Count();
            mojaLista.Sort();
            Console.Write("Unijeli ste {0} brojeva: ", zbroj);
            foreach (int broj in mojaLista)
            {
                Console.Write(broj);
            }

            Console.ReadKey();
        }
    }
}
