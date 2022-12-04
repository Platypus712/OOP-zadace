using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljinaNiza;
            Console.WriteLine("Koliko brojeva želite unijeti:");
            int.TryParse(Console.ReadLine(), out duljinaNiza);

            decimal[] niz = new decimal[duljinaNiza];
            int[] cjelobrojniniz = new int[duljinaNiza];
            float[] decimalniniz = new float[duljinaNiza];

            for (int i = 0; i < duljinaNiza; i++)
            {
                decimal unos;
                Console.WriteLine("Unesite broj:");
                decimal.TryParse(Console.ReadLine(), out unos);
                if (unos <= 0) break;
                niz[i] = unos;
            }

            for (int i = 0; i < duljinaNiza; i++)
            {
                float number = (float)niz[i];
                if (number % 2 == 0)
                {
                    cjelobrojniniz[i] = (int)number;
                }
                else
                {
                    double result = number - (double)Math.Truncate(number);
                    decimalniniz[i] = (float)Math.Round(result, 2);
                    cjelobrojniniz[i] = (int)Math.Truncate(number);
                }
            }

            foreach (var broj in cjelobrojniniz)
            {
                if(broj != 0) Console.WriteLine(broj);
            }
            foreach (var broj in decimalniniz)
            {
                if(broj != 0) Console.WriteLine(broj);
            }

            Console.ReadKey();
        }
    }
}
