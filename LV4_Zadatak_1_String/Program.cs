using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4_Zadatak_1_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string poruka1;
            string poruka2;
            Console.WriteLine("Unesite prvu poruku: ");
            poruka1 = Console.ReadLine();
            Console.WriteLine("Unesite drugu poruku: ");
            poruka2 = Console.ReadLine();

            if (poruka1 == poruka2)
            {
                Console.WriteLine("Unesene poruke su iste!");
            }
            else
            {
                Console.WriteLine("Poruke su različite!");
            }

            Console.ReadKey();
        }
    }
}
