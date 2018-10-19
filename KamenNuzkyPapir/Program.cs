using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNuzkyPapir
{
    partial class Program
    {
        private static Random random = new Random();

        private static void Main(string[] args)
        {
            Console.WriteLine("Kamen Nuzky Papir");

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Kamen - k\nNuzky - n\nPapir - p\n");
                Console.WriteLine("Zadejte svoji figuru:");

                char userInput = Console.ReadKey().KeyChar;
                char pcInput = GenerateRandomFigure();
                Console.WriteLine();
                Console.WriteLine();

                if (userInput != pcInput)
                {
                    if (userInput == 'k' && pcInput == 'n')
                        Console.WriteLine("Kámen ztupí nůžky, vyhrál jsi");
                    else if (userInput == 'n' && pcInput == 'k')
                        Console.WriteLine("Kámen ztupí nůžky, prohrál jsi");               
                    else if (userInput == 'p' && pcInput == 'k')
                        Console.WriteLine("Papír zabalí kámen, vyhrál jsi");
                    else if (userInput == 'k' && pcInput == 'p')
                        Console.WriteLine("Papír zabalí kámen, prohrál jsi");
                    else if (userInput == 'n' && pcInput == 'p')
                        Console.WriteLine("Nůžky přestřihnou papír, vyhrál jsi");
                    else if (userInput == 'p' && pcInput == 'n')
                        Console.WriteLine("Nůžky přestřihnou papír, prohrál jsi");
                }
                else
                    Console.WriteLine("Remíza");

                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static char GenerateRandomFigure()
        {
            switch (random.Next(0, 3))
            {
                case 0:
                    return 'k';
                case 1:
                    return 'n';
                default:
                    return 'k';
            }            
        }
    }
}
