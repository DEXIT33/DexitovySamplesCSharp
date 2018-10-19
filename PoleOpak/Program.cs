using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoleOpak
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[10];

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int nahoda = random.Next(0, pole.Length);

                if(pole[nahoda] == 1)
                    i--;
                else
                    pole[nahoda] = 1;
            }
                

            foreach (int cislo in pole)
            {
                Console.WriteLine(cislo);
            }

            Console.ReadKey(true);
        }
    }
}
