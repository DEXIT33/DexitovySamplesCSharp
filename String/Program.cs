using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Ahoj jak se mas, mam se dobře";

            int pocet = 0;

            for(int i = 0; i < str.Length; i++)
                if (str[i] == 'a')
                    pocet++;
                ;
            Console.WriteLine(pocet);
            Console.ReadKey(true);
        }
    }
}
