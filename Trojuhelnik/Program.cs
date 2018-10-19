using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTriangle(80, 5, 5));
            Console.ReadKey(true);
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            return  a + b > c && a + c > b && b + c > a;
        }
    }
}
