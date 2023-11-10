using System;


namespace Inheritance
{
    class MainClass
    {
        class DaneTechniczne // klasa bazowa
        {
            public string KategoriaPojazdu { get; set; }
            public double WagaPojazazdu { get; set; }
            public int PojemnoscSilnika { get; set; }
            public double MocSilnika { get; set; }
            public string KolorNadwozia { get; set; }
            public int IloscOsi { get; set; }

            public DaneTechniczne(string kategoria, double waga, int pojemnosc, double moc, string kolor, int osie)
            {
                KategoriaPojazdu = kategoria;
                WagaPojazazdu = waga;
                PojemnoscSilnika = pojemnosc;
                MocSilnika = moc;
                KolorNadwozia = kolor;
                IloscOsi = osie;
            }

            public void PrintBase() // wyświetlanie danych technicznych samochodu
            {
                Console.WriteLine("Kategoria:" + KategoriaPojazdu);
                Console.WriteLine("Waga: " + WagaPojazazdu + " t");
                Console.WriteLine("Pojemność silnika: " + PojemnoscSilnika + " cm3");
                Console.WriteLine("Moc silnika: " + MocSilnika + " kW");
                Console.WriteLine("Kolor nadwozia: " + KolorNadwozia);
                Console.WriteLine("Ilość osi: " + IloscOsi);
            }

        }
        class Samochod : DaneTechniczne //klasa pochodna
        {
            public Samochod() : base(" ", 0.0, 0, 0.0, "", 0)
            {
            }

            public Samochod(string kategoria, double waga, int pojemnosc, double moc, string kolor, int osie, string marka) : base(kategoria, waga, pojemnosc, moc, kolor, osie)
            {
                Marka = marka;
            }
            public string Marka { get; set; }
            public void PrintMarka()
            {
                Console.WriteLine("Marka: " + Marka);
            }
        }
        public static void Main(string[] args)
        {
            Samochod Specyfikacja = new Samochod();
            Specyfikacja.KategoriaPojazdu = "Ciężarowy";
            Specyfikacja.WagaPojazazdu = 10;
            Specyfikacja.PojemnoscSilnika = 10000;
            Specyfikacja.MocSilnika = 300;
            Specyfikacja.KolorNadwozia = "Żółty";
            Specyfikacja.IloscOsi = 2;
            Specyfikacja.Marka = "MAN";
            Specyfikacja.PrintBase();

            Console.ReadKey();

        }
    }
}