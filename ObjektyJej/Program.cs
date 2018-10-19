using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektyJej
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankomat bankomat = new Bankomat(100000, 1234);

            Console.WriteLine(bankomat.Konto);
            bankomat.Uloz(50);
            Console.WriteLine(bankomat.Konto);
            bankomat.Vyber(1234, 200000);

            Console.ReadKey();
        }
    }
}
