using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int unos;
            Console.WriteLine("Izračunajte drugi korijen: ");

            try
            {
                unos = int.Parse(Console.ReadLine());
                double korijen = Math.Sqrt(unos);

                if (unos <= 0)
                {
                    Console.WriteLine("\nPogrešan unos1!!");
                }
                else
                {
                    Console.WriteLine("\nDrugi korijen broja {0} iznosi: {1}", unos, korijen);
                }
            }
            //} catch (ArithmeticException ex1)
            //{
            //    Console.WriteLine("\nPogrešan unos1!!");
            //}
            catch (FormatException ex2)
            {
                Console.WriteLine("\nPogrešan unos!!");
            }
            finally
            {
                Console.WriteLine("\nKraj programa!!");
            }
        }
    }
}
