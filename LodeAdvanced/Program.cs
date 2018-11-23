using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace LodeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lod> lode = new List<Lod>();

            Random rnd = new Random();

            Console.WriteLine("Zadej počet lodí!");
            
            // TODO ošetřit vstup
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

                // TODO ošetřit vstup
                string[] souradnice = Console.ReadLine().Split(',');

                int x = Convert.ToInt32(souradnice[0]);
                int y = Convert.ToInt32(souradnice[1]);

                bool lodTrefena = false;

                var lodicka = lode.Find(lod => lod.X == x && lod.Y == y);

                if (lodicka != null)
                {
                    Console.WriteLine("HAHA SUNDALS LOĎ");
                    lode.Remove(lodicka);
                }
                else
                {
                    Console.WriteLine("NETREFIL JSI SE!");
                }
                
                Console.WriteLine(lode.Count);
            }
            
            Console.WriteLine("VYHRÁL JSI!");
        }
    }
}
