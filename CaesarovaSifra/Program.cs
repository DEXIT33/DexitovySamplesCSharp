using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarovaSifra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte text:");
            string input = Console.ReadLine();
            Console.WriteLine("Zadejte posunuti:");
            int increment = Convert.ToInt32(Console.ReadLine());

            input = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                int character = input[i] + increment;

                if (character > 'Z')
                    Console.Write((char)(character - 'Z' + 64));
                else
                    Console.Write(character);
            }

            Console.ReadKey(true);
        }
    }
}
