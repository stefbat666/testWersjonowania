using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWersjonowania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program ddemonstruje działanie wersjonowania w GITHUB-ie");
            Console.WriteLine("wersja wczytana do GITHUBa");
            Console.WriteLine("Kolejnosc 1");

            Console.WriteLine("Dodaj    (1+2)=" + funcDodaj(1, 2));
            Console.WriteLine("Odejmij  (3-1)=" + funcOdejmij(3, 1));
            Console.WriteLine("Mn123ozenie (3*2)=" + funcMnozenie(3, 2));

            Console.WriteLine("Napisal: Irek");
            Console.ReadLine();

        }


        static int funcDodaj(int a, int b)
        {
            return a + b;
        }

        static int funcOdejmij(int a, int b)
        {
            return a - b;
        }

        static int funcMnozenie(int a, int b)
        {
            return a * b;
        }

    }
}
