using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NejvetsiNejmensiCislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
            }

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];

                if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine("Max: {0}, Min: {1}", max, min);
            Console.ReadKey(true);
        }
    }
}
