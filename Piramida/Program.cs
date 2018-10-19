using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramida
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Zadejte počet trubek pro základnu:");
            n = Convert.ToInt32(Console.ReadLine()) / 2;

            int pocetTrubek = DrawPyramid(n);
            
            Console.WriteLine("\nPocet trubek je: {0}", pocetTrubek);
            Console.ReadKey(true);
        }

        private static int DrawPyramid(int n)
        {
            StringBuilder builder = new StringBuilder();
            int pocet = 0;

            for (int i = 0; i < n; i++)
            {
                pocet += i;

                for (int j = 0; j < n - i; j++)
                    builder.Append(" ");

                for (int j = 0; j < i; j++)
                    builder.Append("#");

                for (int j = 0; j < i; j++)
                    builder.Append("#");

                for (int j = 0; j < n - i; j++)
                    builder.Append(" ");

                Console.WriteLine(builder);

                builder.Clear();
            }

            return pocet;
        }
    }
}
