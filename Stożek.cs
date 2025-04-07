using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Stożek : Bryła, IWyświetl
    {
        public double Wysokość { get; }
        public double Promień { get; }

        public Stożek(double wysokość, double promień,double gęstość, double cenaZaKG):base("Stożek",gęstość,cenaZaKG)
        {
            Wysokość = wysokość;
            Promień = promień;
        }
        public override double Objętość
        {
            get
            {
                return (1.0 / 3.0) * Wysokość * Math.PI * Math.Pow(Promień, 2);
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
            return $"Nazwa: {Nazwa}, promień: {Promień}, wysokość: {Wysokość}";
        }
    }
}
