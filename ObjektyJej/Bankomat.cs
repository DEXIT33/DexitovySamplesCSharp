using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektyJej
{
    class Bankomat
    {
        private int konto;
        private readonly int pin;

        public int Konto => konto;

        public Bankomat(int konto, int pin)
        {
            this.konto = konto;
            this.pin = pin;
        }

        public void Uloz(int pocet)
        {
            konto += pocet;
        }

        public void Vyber(int pin, int pocet)
        {
            if (this.pin != pin || pocet > konto)
            {
                Console.WriteLine("Nelze provést transakci");
                return;
            }

            konto -= pocet;
        }
    }
}
