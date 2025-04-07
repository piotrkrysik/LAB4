namespace Geometria
{
    public abstract class Bryła
    {
        public string Nazwa { get; }
        public double Gęstość { get; }
        public double CenaZaKG { get; }
        public Bryła(string nazwa, double gęstość, double cenaZaKG)
        {
            Nazwa = nazwa;
            Gęstość = gęstość;
            CenaZaKG = cenaZaKG;
        }

        public abstract double Objętość { get; }
        public abstract double Masa { get; }
        public double Cena
        {
            get
            {
                return Masa * CenaZaKG;
            }
        }
        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Gęstość: {Gęstość} g/cm^3, Cena za kg: {CenaZaKG} zł" +
                $" Objętość: {Objętość} cm^3, Masa: {Masa} kg, Cena {Cena}";
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            Bryła? otherBryła = obj as Bryła;
            if (otherBryła != null)
            {
                return otherBryła.Objętość.CompareTo(this.Objętość);
            }
            return 0;
        }
    }
}
