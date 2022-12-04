using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak-1. Deklariranje i incijaliziranje varijabli\n");

            ushort zad1_prviBroj = 52130;
            sbyte zad1_drugiBroj = -115;
            uint zad1_treciBroj = 4825932u;
            byte zad1_cevrtiBroj = 97;
            short zad1_petiBroj = -10000;
            ushort zad1_sestiBroj = 20000;
            byte zad1_sedmiBroj = 224;
            uint zad1_osmiBroj = 970700000u;
            byte zad1_devetiBroj = 112;
            sbyte zad1_desetiBroj = -44;
            int zad1_jedanaestiBroj = -1000000;
            ushort zad1_dvanaestiBroj = 1990;
            ulong zad1_trinaestiBroj = 123456789123456789ul;

            Console.WriteLine(zad1_prviBroj);
            Console.WriteLine(zad1_drugiBroj);
            Console.WriteLine(zad1_treciBroj);
            Console.WriteLine(zad1_cevrtiBroj);
            Console.WriteLine(zad1_petiBroj);
            Console.WriteLine(zad1_sestiBroj);
            Console.WriteLine(zad1_sedmiBroj);
            Console.WriteLine(zad1_osmiBroj);
            Console.WriteLine(zad1_devetiBroj);
            Console.WriteLine(zad1_desetiBroj);
            Console.WriteLine(zad1_jedanaestiBroj);
            Console.WriteLine(zad1_dvanaestiBroj);
            Console.WriteLine(zad1_trinaestiBroj);
           
            Console.WriteLine("\nZadatak-2. Deklariranje i incijaliziranje varijabli\n");

            int zad2_prviBroj = 5;
            float zad2_drugiBroj = -5.01F;
            double zad2_treciBroj = 34.567839023D;
            float zad2_cevrtiBroj = 12.345F;
            double zad2_petiBroj = 8923.1234857D;
            decimal zad2_sestiBroj = 3456.091124875956542151256683467M;

            Console.WriteLine(zad2_prviBroj);
            Console.WriteLine(zad2_drugiBroj);
            Console.WriteLine(zad2_treciBroj);
            Console.WriteLine(zad2_cevrtiBroj);
            Console.WriteLine(zad2_petiBroj);
            Console.WriteLine(zad2_sestiBroj);

            Console.WriteLine("\nZadatak-3. Deklariranje i incijaliziranje varijable char\n");

            char zad3_prviBroj = '\u0048';

            Console.WriteLine(zad3_prviBroj);

            Console.WriteLine("\nZadatak-4. Deklariranje i incijaliziranje varijable bool\n");

            bool spolMusko;

            string spol = "Muško";
            spolMusko = (spol == "Muško");

            Console.WriteLine(spolMusko);

            Console.WriteLine("\nZadatak-5. Deklariranje i incijaliziranje varijable string\n");

            string zad5_varijabla = "Laku noć!";

            Console.WriteLine(zad5_varijabla);

            Console.WriteLine("\nZadatak-6. Deklariranje i incijaliziranje dvije cjelobrojne varijable\n");

            int zad6_prviBroj = 5;
            int zad6_drugiBroj = 10;

            Console.WriteLine(zad6_prviBroj);
            Console.WriteLine(zad6_drugiBroj);

            Console.ReadKey();
        }
    }
}
