using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj = 10;
            int drugiBroj = 3;
            double rezultat;

            rezultat = prviBroj / drugiBroj;
            Console.WriteLine("{0} podijeljeno s {1} iznosi: {2}", prviBroj, drugiBroj, rezultat);
        }
    }
}
