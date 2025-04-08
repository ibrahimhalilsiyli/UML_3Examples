using System;

namespace UML_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba
            {
                Marka = "Toyota",
                Model = "Corolla",
                Plaka = "34ABC123",
                Yil = 2020,
                YakitTuru = "Benzin"
            };

            araba1.Calistir();
            araba1.Hizlan(30);
            araba1.Hizlan(20);
            araba1.Durdur();

            Console.WriteLine("\n\n\n--------------------------------------\n\n");

            Lion lion1 = new Lion
            {
                Name = "Simba",
                Age = 5,
                Gender = "Male",
                Weight = 190.5
            };

            lion1.Roar();
            lion1.Hunt();
            lion1.Sleep();



            Console.WriteLine("\n\n\n--------------------------------------\n\n");

            // Create a new instance of the Country class
            Country country = new Country("France", "Paris", 67372000, 643801);

            // Display country information
            country.DisplayCountryInfo();

            // Display population density
            double density = country.PopulationDensity();
            Console.WriteLine($"Population Density: {density} people per km²");
            Console.ReadLine(); // Konsol kapanmasın diye
        }
    }

    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Plaka { get; set; }
        public int Yil { get; set; }
        public string YakitTuru { get; set; }
        public int Hiz { get; private set; } = 0;
        public bool CalisiyorMu { get; private set; } = false;

        public void Calistir()
        {
            CalisiyorMu = true;
            Console.WriteLine($"{Marka} {Model} çalıştırıldı.");
        }

        public void Durdur()
        {
            CalisiyorMu = false;
            Hiz = 0;
            Console.WriteLine($"{Marka} {Model} durduruldu.");
        }

        public void Hizlan(int artis)
        {
            if (CalisiyorMu)
            {
                Hiz += artis;
                Console.WriteLine($"{Marka} {Model} {artis} km/h hızlandı. Şu anki hız: {Hiz} km/h");
            }
            else
            {
                Console.WriteLine("Araba çalışmıyor. Hızlanamaz.");
            }

        }
    }
}
