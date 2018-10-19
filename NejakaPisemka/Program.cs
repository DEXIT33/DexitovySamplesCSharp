using System;

namespace NejakaPisemka
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string input = "Ahoj";

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }*/

            /*
            int[] pole = {1, 2, 3, 4, 5};

            int count = 0;

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > 3)
                    count += pole[i];
            }

            Console.ReadKey(true);*/

            /*
            Console.WriteLine("Zadej vetu:");

            string input = Console.ReadLine();

            Console.WriteLine("Zadej znak:");

            char character = Convert.ToChar(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == character)
                    count++;

            }

            Console.WriteLine(count);*/

            double[] array = { 0, 1.5, 4.5 };

            double min = Double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }


            Console.ReadKey();
        }
    }
}
