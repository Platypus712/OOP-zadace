using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mojaLista = new List<string>();

            while (true)
            {
                string unosImena;
                Console.WriteLine("Unesite ime gosta: ");
                unosImena = Console.ReadLine();
                if (unosImena == "kraj") break;
                mojaLista.Add(unosImena);
            }

            mojaLista.Sort();
            Console.WriteLine("Prisutni gosti su:");
            foreach (string ime in mojaLista)
            {
                Console.WriteLine(ime);
            }

            Console.ReadKey();
        }
    }
}
