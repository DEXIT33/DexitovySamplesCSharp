using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTFPole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] pole = new int[10];

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(1, 21);
            }

            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = i; j < pole.Length; j++)
                {
                    if (pole[j] < pole[i])
                    {
                        int temp = pole[i];
                        pole[i] = pole[j];
                        pole[j] = temp;
                    }
                }
            }

            foreach (int num in pole)
                Console.WriteLine(num);

            Console.ReadKey(true);
        }
    }
}
