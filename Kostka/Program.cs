using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kostka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int pcHod;
            int uzivatelHod;

            while (true)
            {
                pcHod = random.Next(1, 7);

                Console.WriteLine("Hoď si!");

                Console.ReadKey(true);

                uzivatelHod = random.Next(1, 7);

                if (pcHod != uzivatelHod)
                    Console.WriteLine(pcHod + " : " + uzivatelHod + " " + (pcHod > uzivatelHod ? "Vyhrál jsem\n" : "Vyhrál jsi\n"));
                else
                    Console.WriteLine(pcHod + " : " + uzivatelHod + ""  + "Remíza\n");           
            }           
        }
    }
}
