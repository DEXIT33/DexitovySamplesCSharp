using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace LodeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lod> lode = new List<Lod>();

            Random rnd = new Random();

            Console.WriteLine("Zadej počet lodí!");
            int pocetLodi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < pocetLodi; i++)
            {
                int x = rnd.Next(1, 11);
                int y = rnd.Next(1, 11);

                while (lode.Exists(lod => lod.X == x && lod.Y == y))
                {
                    x = rnd.Next(1, 11);
                    y = rnd.Next(1, 11);
                }

                lode.Add(new Lod(x, y));
            }

            foreach (var lod in lode)
            {
                Console.WriteLine(lod);
            }

            while (lode.Count != 0)
            {
                Console.WriteLine("Vystřel - zadej souřadnice ve formátu x,y!");

                string souradniceString = Console.ReadLine();

                string[] souradnice = souradniceString.Split(',');

                int x = Convert.ToInt32(souradnice[0]);
                int y = Convert.ToInt32(souradnice[1]);

                bool lodTrefena = false;
                
                foreach (var lod in lode)
                {
                    if (lod.X == x && lod.Y == y)
                    {
                        lodTrefena = true;
                        lode.Remove(lod);
                        break;
                    }            
                }

                if (lodTrefena)
                {
                    Console.WriteLine("HAHA SUNDALS LOĎ");
                }
                else
                {
                    Console.WriteLine("MRDÁKU!");
                }
            }
            
            Console.WriteLine("VYHRÁL JSI!");
        }
    }
}
