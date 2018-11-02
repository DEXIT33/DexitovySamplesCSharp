namespace Pisemka
{
    public class Firma
    {
        private double _pocetZamestnancu;
        private double _penizeNaMzdy;
    
        public Firma(double pocetZamestnancu, double penizeNaMzdy)
        {
            _pocetZamestnancu = pocetZamestnancu;
            _penizeNaMzdy = penizeNaMzdy;
        }

        public void PrijmiZamestnance()
        {
            _pocetZamestnancu++;
        }

        public void PropustZamestnance()
        {
            _pocetZamestnancu--;
        }

        public double VlozPenizeNaMzdy(double penizeNaMzdy)
        {
            return _penizeNaMzdy += penizeNaMzdy;
        }

        public double PrumerNaZamestnance()
        {
            return _penizeNaMzdy / _pocetZamestnancu;
        }
    }
}