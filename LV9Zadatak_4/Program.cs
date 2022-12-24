//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pice pice = new Pice("Cedevita", 1, "narančasto", "15kn");
            AlkoholnoPice alkoholnoPice = new AlkoholnoPice("Pivo", 1, "žuto-narančasto", "25kn", "5%");
            Console.WriteLine("Podaci o picu:");
            Console.WriteLine("Ime: {0}", pice.nazivPica);
            Console.WriteLine("Velicina pakiranja (u litrama): {0}", pice.velicinaPakiranja);
            Console.WriteLine("Boja tekućine: {0}", pice.boja);
            Console.WriteLine("Cijena: {0}", pice.cijena);
            Console.WriteLine();
            Console.WriteLine("Podaci o alkoholnom picu:");
            Console.WriteLine("Ime: {0}", alkoholnoPice.nazivPica);
            Console.WriteLine("Velicina pakiranja (u litrama): {0}", alkoholnoPice.velicinaPakiranja);
            Console.WriteLine("Boja tekucine: {0}", alkoholnoPice.boja);
            Console.WriteLine("Cijena: {0}", alkoholnoPice.cijena);
            Console.WriteLine("Postotak alkohola: {0}", alkoholnoPice.postotakAlkohola);
        }
    }
}
