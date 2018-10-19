using System;
using System.Collections.Generic;

namespace Prumerovani
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> data = new List<double>(100);

            const double prumer = 3;
            
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                data.Add(random.Next(1, 50 + 1));
                Console.Write(data[i] + ", ");
            }

            Console.WriteLine();

            for (int i = 0; i < data.Count; i++)
            {
                if(i > data.Count - prumer)
                    data.RemoveAt(i);
                else
                {
                    double soucet = 0;

                    for (int j = 0; j < prumer; j++)
                    {
                        soucet += data[i + j];
                    }

                    data[i] = soucet / prumer;
                }               
            }

            foreach (var dat in data)
                Console.Write(dat + ", ");

            Console.ReadKey(true);
        }
    }
}
