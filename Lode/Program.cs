using System;

namespace Lode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konstanty
            const int voda = 0;
            const int lod = 1;
            const int trefVoda = 2;
            const int trefLod = 3;
            
            //Uživatelské proměnné
            int pocetLodi = 0;
            int velikostHraciPlochy = 0;
            int pocetPokusu = 0;

            //Vyhra
            bool vyhra = false;

            //Random
            Random random = new Random();

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
            Console.WriteLine("Zadejte počet lodí:");
            spravneZadano = false;
            while (!spravneZadano)
                try
                {
                    pocetLodi = Convert.ToInt32(Console.ReadLine());
                    if(pocetLodi < velikostHraciPlochy * velikostHraciPlochy)
                        spravneZadano = true;
                }
                catch { Console.WriteLine("Špatně zadaný vstup!"); }
            Console.WriteLine("Zadejte počet pokusů:");
            spravneZadano = false;
            while (!spravneZadano)
                try
                {
                    pocetPokusu = Convert.ToInt32(Console.ReadLine());
                    spravneZadano = true;
                }
                catch { Console.WriteLine("Špatně zadaný vstup!"); }

            //Hrací pole
            int[,] pole = new int[velikostHraciPlochy, velikostHraciPlochy];

            //Vygenerování mapy
            int indexX;
            int indexY;

            for (int i = 0; i < pocetLodi; i++)
            {
                indexX = random.Next(0, pole.GetLength(0));
                indexY = random.Next(0, pole.GetLength(1));

                while (pole[indexX, indexY] == 1)
                {
                    indexX = random.Next(0, pole.GetLength(0));
                    indexY = random.Next(0, pole.GetLength(1));
                }

                pole[indexX, indexY] = lod;
            }

            //Hra

            int momentalniPokus = 1;

            while (momentalniPokus <= pocetPokusu)
            {
                if (vyhra)
                    break;

                Console.Clear();

                for (int i = 0; i < pole.GetLength(1); i++)
                {
                    for (int j = 0; j < pole.GetLength(0); j++)
                    {
                        switch (pole[i, j])
                        {
                            case trefLod:
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            default:
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                        }
                      
                        Console.Write(" ");

                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("Pokus cislo {0}", momentalniPokus);
                Console.WriteLine("Zadejte souradnice ve formátu x,y , kde x nebo y muze byt od 1 do {0}",
                    pole.GetLength(0));

                int inputX = 0;
                int inputY = 0;

                spravneZadano = false;

                while (!spravneZadano)
                    try
                    {
                        string input = Console.ReadLine();

                        string[] coords = input.Split(',');

                        inputX = Convert.ToInt32(coords[0]) - 1;
                        inputY = Convert.ToInt32(coords[1]) - 1;

                        if (inputX < pole.GetLength(0) && inputY < pole.GetLength(1) && inputX > -1 && inputY > -1)
                            spravneZadano = true;
                        else
                            Console.WriteLine("Špatně zadaný vstup!");
                    }
                    catch { Console.WriteLine("Špatně zadaný vstup!"); }
                

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
                }

                momentalniPokus++;

                Console.ReadKey(true);
            }

            if(!vyhra)
                Console.WriteLine("Došel ti počet pokusů, prohrál jsi!");

            Console.ReadKey(true);
        }
    }
}
