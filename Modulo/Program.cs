using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(cislo % 2 == 0 ? "Číslo je sudé" : "Číslo je liché");

            Console.ReadKey();
        }
    }
}
