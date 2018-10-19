using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "3XamPle";

            //example.ToLower(); na malá písmena

            //example.ToUpper(); na velká písmena

            //example.Trim(' '); vyřízne z řetězce od začátku a konce

            //example.Remove(2, 3);

            //example.Insert(7, "Hello");

            //example.Substring(0, 7); vytáhne část řetězce

            //example.IndexOf("mP"); -1 když neexistuje

            //example.Replace('a', 'b');

            //example.Split(';');

            //String.Compare(str1, str2); 

            //example = String.Format("{0} {1} {2} {3}", "Ahoj", "jak", "se", "mas");



            Console.WriteLine(example);

            Console.ReadKey(true);
        }
    }
}
