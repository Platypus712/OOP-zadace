using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_3_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string recenica;
            Console.WriteLine("Unesite rečenicu koju želite podijeliti: ");
            recenica = Console.ReadLine();

            string[] brojRijeci = recenica.Split(' ');
            Console.WriteLine("Upisana recenica se sastoji od {0} rijeci.", brojRijeci.Length);

            foreach (var rijec in brojRijeci)
            {
                Console.WriteLine(rijec);
            }

            Console.ReadKey();
        }
    }
}
