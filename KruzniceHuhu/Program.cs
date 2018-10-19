using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KruzniceHuhu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte poloměr:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte dx:");
            double dx = Convert.ToDouble(Console.ReadLine());

            double S = 0;

            for (double x = 0; x < r; x += dx)
            {
                double y = Math.Sqrt(r * r - x * x);
                S += y * dx;
            }

            Console.WriteLine(S * 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.PI * (r * r));

            Console.ReadKey(true);
        }

        //Dú 2, 3, 2 - vykacet, 5, 3 - vykacet, 4 - vykacet
    }
}
