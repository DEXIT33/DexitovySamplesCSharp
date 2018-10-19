using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak = 'A';

            Console.WriteLine((int)znak);

            for(int i = 0; i < 256; i++)
                Console.WriteLine("Číslo: " + i + " ; Znak: " + (char)i);

            Console.ReadKey(true);
        }
    }
}
