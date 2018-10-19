using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //True nebo false
            bool boolean = true;

            if (boolean)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            if (40 > 50 && 8 < 10)
                Console.WriteLine("true");
            else
                Console.WriteLine("false"); 

            if (40 > 50 || 8 < 10)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

            Console.ReadKey();
        }
    }
}
