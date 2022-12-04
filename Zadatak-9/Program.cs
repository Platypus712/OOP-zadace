using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double prviBroj;
            double drugiBroj;
            double treciBroj;

            Console.WriteLine("Unesite prvi broj: ");
            double.TryParse(Console.ReadLine(), out prviBroj);

            Console.WriteLine("Unesite drugi broj: ");
            double.TryParse(Console.ReadLine(), out drugiBroj);
            
            Console.WriteLine("Unesite treci broj: ");
            double.TryParse(Console.ReadLine(), out treciBroj);

            if (prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine("Prvi broj je najveći");
            }
            else if (prviBroj < drugiBroj && drugiBroj > treciBroj)
            {
                Console.WriteLine("Drugi broj je najveći");
            }
            else
            {
                Console.WriteLine("Treći broj je najveći");
            }
        }
    }
}
