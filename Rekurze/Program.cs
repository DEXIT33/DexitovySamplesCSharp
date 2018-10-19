using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5, 4));
            Console.ReadKey();
        }

        static ulong Factorial(ulong n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static double Multiply(double a, double b)
        {
            if (a == 0) return 0;           
            return b + Multiply(a - 1, b);
        }
    }
}
