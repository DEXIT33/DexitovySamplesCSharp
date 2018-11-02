using System;

namespace AutomobilPisemka
{
    public class Automobil
    {
        private string _barva;
        private double _velikostNadrze;
        private double _stavPaliva;
        private int _zarazeno;

        public string Barva
        {
            get => _barva;
            set
            {
                if (value.Equals("černá") || value.Equals("bílá") || value.Equals("červená") || value.Equals("stříbrná"))
                    _barva = value;
                else
                    Console.WriteLine("Neplatná barva");
            }
        }
        
        /*
        public double VelikostNadrze
        {
            get
            {
                return _velikostNadrze;
            }
        }
        */

        public double VelikostNadrze => _velikostNadrze;

        public double StavPaliva => _stavPaliva;

        public int Zarazeno => _zarazeno;

        public Automobil(string barva, double velikostNadrze)
        {
            Barva = barva;

            _velikostNadrze = velikostNadrze;
            _stavPaliva = 5;
        }

        private bool JeStupenPripustny(int rychlostniStupen)
        {
            return rychlostniStupen <= 5 && rychlostniStupen >= -1;
        }

        public void Zarad()
        {
            if (JeStupenPripustny(_zarazeno + 1))
                _zarazeno++;
            else
                Console.WriteLine("Stupeň není přípustný");
        }
        
        public void Podrad()
        {
            if (JeStupenPripustny(_zarazeno - 1))
                _zarazeno--;
            else
                Console.WriteLine("Stupeň není přípustný");
        }

        public void Neutral()
        {
            _zarazeno = 0;
        }

        public void Natankuj(double kolik)
        {
            _stavPaliva += kolik;
        }

        public override string ToString()
        {
            return String.Format("Automobil, barva {0}, stav paliva {1}/{2} litrů", _barva, _stavPaliva, _velikostNadrze);
        }

        public void Ujed(double kilometry)
        {
            if (kilometry > Dojezd())
            {
                Console.WriteLine("Auto nemá dostatek paliva");
                return;
            }
            
            switch (_zarazeno)
            {
                case -1: _stavPaliva -= 8.5 * kilometry / 100.0; break;
                case 1:  _stavPaliva -= 9.6 * kilometry / 100.0; break;
                case 2:  _stavPaliva -= 7.7 * kilometry / 100.0; break;
                case 3:  _stavPaliva -= 6.8 * kilometry / 100.0; break;
                case 4:  _stavPaliva -= 6.2 * kilometry / 100.0; break;
                case 5:  _stavPaliva -= 6.5 * kilometry / 100.0; break;
            }
        }
        
        public double Dojezd()
        {
            switch (_zarazeno)
            {
                case -1: return _stavPaliva / 8.5 * 100.0;
                case 1:  return _stavPaliva / 9.6 * 100.0;
                case 2:  return _stavPaliva / 7.7 * 100.0;
                case 3:  return _stavPaliva / 6.8 * 100.0;
                case 4:  return _stavPaliva / 6.2 * 100.0;
                case 5:  return _stavPaliva / 6.5 * 100.0;
            }

            return 0;
        }

        public bool DojedeDalNez(Automobil jinyAutomobil)
        {
            return Dojezd() > jinyAutomobil.Dojezd();
        }
    }
}