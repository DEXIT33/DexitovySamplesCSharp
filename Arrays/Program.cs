using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[10];

            int soucet = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);

                soucet += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(soucet);

            Console.ReadKey(true);
        }
    }
}
