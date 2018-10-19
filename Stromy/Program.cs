using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stromy
{
    class Program
    {
        static void Main(string[] args)
        {
            const int treeCount = 20;
            const int maxTreeHeight = 20;

            Random random = new Random();

            int[] stromy = new int[treeCount];

            for (int i = 0; i < stromy.Length; i++)
            {
                stromy[i] = random.Next(0, maxTreeHeight + 1);
                Console.Write(stromy[i] + " ");
            }

            int currentHighest = 0;

            string output = "Bude potřeba vykácet ";

            for (int i = 0; i < stromy.Length; i++)
            {
                if (stromy[i] < stromy[currentHighest])
                    output += (i + 1 + "., ");
                else
                    currentHighest = i;
            }

            Console.WriteLine(output.TrimEnd(',', ' ') + " stromek.");
            Console.ReadKey(true);
        }
    }
}
