using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcentZnaku
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            Console.WriteLine("Zadejte text:");
            text = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < 255; i++)
            {
                if (Array.Exists(text.ToCharArray(), element => element == i))
                {
                    int pocet = 0;

                    for(int j = 0; j < text.Length; j++)
                        if (text[j] == i)
                            pocet++;

                    Console.WriteLine((char)i + " {0} %", (double)pocet / text.Length * 100);
                }
            }

            Console.ReadKey(true);
        }
    }
}
