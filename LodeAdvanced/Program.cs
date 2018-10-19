using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lod> lode = new List<Lod>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                lode.Add(new Lod(rnd.Next(0, 10), rnd.Next(0, 10)));
            }

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("Zadej kam míříš X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadej kam míříš Y");
                int y = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < lode.Count; j++)
                {
                    if (lode[j].X == x && lode[j].Y == y && !lode[j].Potopena)
                    {
                        lode[j].Potopena = true;
                        Console.WriteLine("Trefa!!");
                    }                      
                }
            }
        }
    }
}
