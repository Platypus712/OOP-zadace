using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj = 0;

            for (int i = 0; i <= 100; i++)
            {
                zbroj += i;
            }

            Console.WriteLine("Zbroj prvih 100 prirodnih brojeva iznosi: {0}", zbroj);
        }
    }
}
