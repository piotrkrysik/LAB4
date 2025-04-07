using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Kula : Bryła, IWyświetl
    {
        public double Promień { get; }

        public Kula(double promień, double gęstość, double cenaZaKG):base("Kula", gęstość, cenaZaKG)
        {
            Promień = promień;
        }

        public override double Objętość
        {
            get
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(Promień, 3);
            }
        }
        public override double Masa
        {
            get
            {
                return Objętość * Gęstość;
            }
        }
        public string PobierzIdentyfikator()
        {
            return $"Nazwa: {Nazwa}, promień: {Promień}";
        }
    }
}
