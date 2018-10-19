using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kralici
{
    class Program
    {
        static void Main(string[] args)
        {
            const int samecek = 1;
            const int samicka = 2;

            const int pocet = 10;

            Random random = new Random();

            int[,] pole = new int[6, 6];

            bool bylaToSamicka = false;

            //Generator
            for (int i = 0; i < pocet; i++)
            {
                int index_X = random.Next(0, pole.GetLength(1));
                int index_Y = random.Next(0, pole.GetLength(0));

                while (pole[index_Y, index_X] != 0)
                {
                    index_X = random.Next(0, pole.GetLength(1));
                    index_Y = random.Next(0, pole.GetLength(0));
                }

                pole[index_Y, index_X] = random.Next(0, 2) == 1 ? samicka : samecek;
            }

            //Game
            while (true)
            {
                //Logic
                for (int i = 0; i < pole.GetLength(0); i++)
                {
                    for (int j = 0; j < pole.GetLength(1); j++)
                    {
                        for (int x = i - 1; x < i + 2; x++)
                        {
                            if (x < 0 || x >= pole.GetLength(0)) continue;

                            for (int y = j - 1; y < j + 2; y++)
                            {
                                if (y < 0 || y >= pole.GetLength(1) || (x == i && y == j)) continue;

                                if ((pole[x, y] == samecek && pole[i, j] == samecek) || (pole[x, y] == samicka && pole[i, j] == samicka))
                                {
                                    pole[i, j] = 0;
                                    break;
                                }
                                else if ((pole[x, y] == samecek && pole[i, j] == samicka) ||
                                         (pole[x, y] == samicka && pole[i, j] == samecek))
                                {
                                    int index_X = random.Next(0, pole.GetLength(1));
                                    int index_Y = random.Next(0, pole.GetLength(0));

                                    while (pole[index_Y, index_X] != 0)
                                    {
                                        index_X = random.Next(0, pole.GetLength(1));
                                        index_Y = random.Next(0, pole.GetLength(0));
                                    }

                                    pole[index_Y, index_X] = bylaToSamicka ? samecek : samicka;

                                    bylaToSamicka = !bylaToSamicka;
                                }

                            }

                            if (pole[i, j] == 0)
                                break;
                        }
                    }
                }

                //Render
                for (int i = 0; i < pole.GetLength(0); i++)
                {
                    for (int j = 0; j < pole.GetLength(1); j++)
                    {
                        Console.Write(pole[i, j]);
                    }

                    Console.WriteLine();
                }

                Console.ReadKey(true);
            }        
        }
    }
}
