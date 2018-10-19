using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Miny
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konstanty
            const int neviditelnePole = 0;
            const int mina = 9;
            const int viditelnePole = 10;
            const int border = 11;

            //Uživatelské proměnné
            int pocetMin = 0;
            int velikostHraciPlochy = 0;

            //Random
            Random random = new Random();

            //Vyhra
            bool vyhra = false;

            bool spravneZadano = false;

            //Vstup
            Console.WriteLine("Zadejte velikost pole:");
            while (!spravneZadano)
                try
                {
                    velikostHraciPlochy = Convert.ToInt32(Console.ReadLine());
                    spravneZadano = true;
                }
                catch { Console.WriteLine("Špatně zadaný vstup!"); }
            Console.WriteLine("Zadejte počet min:");
            spravneZadano = false;
            while (!spravneZadano)
                try
                {
                    pocetMin = Convert.ToInt32(Console.ReadLine());
                    if (pocetMin < velikostHraciPlochy * velikostHraciPlochy)
                        spravneZadano = true;
                }
                catch { Console.WriteLine("Špatně zadaný vstup!"); }

            //Hrací pole
            int[,] pole = new int[velikostHraciPlochy + 2, velikostHraciPlochy + 2];

            //Vygenerování mapy
            int indexX;
            int indexY;

            for (int i = 0; i < pocetMin; i++)
            {
                indexX = random.Next(1, pole.GetLength(0) - 1);
                indexY = random.Next(1, pole.GetLength(1) - 1);

                while (pole[indexX, indexY] == 1)
                {
                    indexX = random.Next(1, pole.GetLength(0) - 1);
                    indexY = random.Next(1, pole.GetLength(1) - 1);
                }

                pole[indexX, indexY] = mina;
            }

            //Border

            for (int i = 0; i < pole.GetLength(0); i++)
            {
                pole[i, 0] = border;
                pole[0, i] = border;
                pole[i, velikostHraciPlochy + 1] = border;
                pole[velikostHraciPlochy + 1, i] = border;
            }

            //Hra

            while (!vyhra)
            {
                Console.Clear();

                for (int i = 1; i < pole.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < pole.GetLength(1) - 1; j++)
                    {
                        Console.Write(pole[i, j] + ", ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Zadejte souradnice ve formátu x, y , kde x nebo y muze byt od 1 do {0}", pole.GetLength(0) - 2);

                int inputX = 0;
                int inputY = 0;

                spravneZadano = false;

                while (!spravneZadano)
                    try
                    {
                        string input = Console.ReadLine();

                        string[] coords = input.Split(',');

                        inputY = Convert.ToInt32(coords[0]);
                        inputX = Convert.ToInt32(coords[1]);

                        if (inputX < pole.GetLength(0) - 1 && inputY < pole.GetLength(1) - 1 && inputX > 0 && inputY > 0)
                            spravneZadano = true;
                        else
                            Console.WriteLine("Špatně zadaný vstup!");
                    }
                    catch { Console.WriteLine("Špatně zadaný vstup!"); }

                if(pole[inputX, inputY] == mina)
                    Console.WriteLine("MINA BUM");
                else
                {
                    int minaCounter = 0;

                    for (int i = inputX - 1; i <= inputX + 1; i++)
                    {
                        for (int j = inputY - 1; j <= inputY + 1; j++)
                        {
                            if (pole[i, j] == mina)
                                minaCounter++;
                            else
                            {
                                pole[i, j] = viditelnePole;
                            }
                        }
                    }

                    pole[inputX, inputY] = minaCounter;

                    Console.WriteLine("POČET MIN ZAPSÁN");
                }

                for (int i = 1; i < pole.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < pole.GetLength(1) - 1; j++)
                    {
                        Console.Write(pole[i, j]);
                    }
                    Console.WriteLine();
                }

                /*
                switch (pole[inputX, inputY])
                {
                    case voda:
                        Console.WriteLine("Trefil jsi vodu.");
                        pole[inputX, inputY] = trefVoda;
                        break;
                    case lod:
                        Console.WriteLine("Trefil jsi loď.");
                        pocetLodi -= 1;
                        if (pocetLodi == 0)
                        {
                            Console.WriteLine("Trefil jsi všechny lodě, vyhrál jsi!");
                            vyhra = true;
                        }
                        pole[inputX, inputY] = trefLod;
                        break;
                    case trefVoda:
                        Console.WriteLine("Sem už jsi střílel, jsi hloupý kluk.");
                        break;
                    case trefLod:
                        Console.WriteLine("Tahle loď je již sestřelená, jsi hloupý kluk.");
                        break;
                }*/

                Console.ReadKey(true);
            }

            Console.WriteLine("Objevil jsi všechny miny");

            Console.ReadKey(true);
        }
    }
}
