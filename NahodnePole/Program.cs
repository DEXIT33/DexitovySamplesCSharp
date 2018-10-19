using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NahodnePole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[10];

            Random random = new Random();

            int pocetSkoku = 0;

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(1, 7);

                if (i == pole.Length - 1)
                    Console.WriteLine(pole[i]);
                else
                    Console.Write(pole[i] + ", ");              
            }

            for (int i = 0; i < pole.Length; i++)
            {
                i += pole[i] - 1;    
                pocetSkoku++;
            }

            Console.WriteLine(pocetSkoku);            

            Console.ReadKey(true);
        }
    }
}
