using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pole = new int[5, 5];

            //pole[4, 4] = 1;
            //pole[2, 4] = 2;

            int soucet = 0;
            
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                soucet = 0;

                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    pole[i, j] = j + 1;
     
                    Console.Write(" {0}", pole[i, j]);

                    soucet += pole[i, j];
                }

                Console.WriteLine(" - Soucet: {0}", soucet);
            }

            Console.ReadKey();
        }
    }
}
