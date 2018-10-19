using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistka
{
    class Program
    {
        static void Main(string[] args)
        {
            const int U = 230;

            double P;
            double Ip;

            double Io;

            Console.WriteLine("Zadejte příkon žárovky");
            P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte proud, na který je dělaná pojistka");
            Ip = Convert.ToDouble(Console.ReadLine());

            Io = P / U;

            Console.WriteLine(Io >= Ip ? "Pojistka praskne" : "Pojistka zůstane v pořádku");

            Console.ReadKey();
        }
    }
}
