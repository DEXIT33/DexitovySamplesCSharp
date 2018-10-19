using System;

namespace StringOpak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte textový řetězec:");
            string input = Console.ReadLine();

            int wordCount = 1;
            int differentCharsCount = 0; //HomeWork

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    wordCount++;
            }

            Console.WriteLine("Počet slov je {0}", wordCount);
            Console.WriteLine("Průměrně znaků v slově je {0}", (input.Length - wordCount + 1) / wordCount);
            Console.WriteLine("Počet různých znaků je {0}", wordCount);

            Console.ReadKey(true);
        }
    }
}
