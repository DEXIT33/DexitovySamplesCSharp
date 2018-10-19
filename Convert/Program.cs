using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int cislo = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] >= '0' && input[i] <= '9')
                    cislo = cislo * 10 + (input[i] - 48);
            }

            Console.WriteLine(cislo);

            Console.ReadKey(true);
        }
    }
}
