using System;

namespace CviceniObjektyBanka
{
    class Banka
    {
        private int _pin;
        private int _ucet;

        public Banka(int pin, int ucet)
        {
            _pin = pin > 0 ? pin : throw new ArgumentException("PIN musí být větší než 0");
            _ucet = ucet > 0 ? ucet : throw new ArgumentException("Počáteční částka musí být větší než 0");
        }

        public void Vyber(int castka, int pin)
        {
            if (pin == _pin)
            {
                if(castka < _ucet)
                    _ucet -= castka > 0 ? castka : throw new ArgumentException("Částka musí být větší než 0");
                else
                    Console.WriteLine("Moc velká částka na vybrání.");
            }
            else
                Console.WriteLine("Špatný PIN");
        }
        
        public void Vypis(int pin)
        {            
            if (pin == _pin)
                Console.WriteLine(_ucet);
            else
                Console.WriteLine("Špatný PIN");
        }
        
        public void Uloz(int castka)
        {
            _ucet += castka > 0 ? castka : throw new ArgumentException("Částka musí být větší než 0");
        }
        
        public void ZmenPin(int staryPin, int novyPin)
        {
            if (staryPin == _pin)
                _pin = novyPin > 0 ? novyPin : throw new ArgumentException("PIN musí být větší než 0");
            else
                Console.WriteLine("Špatný PIN");            
        }
    }
}