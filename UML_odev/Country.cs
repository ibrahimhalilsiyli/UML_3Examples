using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_odev
{
    internal class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public double Area { get; set; } // in square kilometers

        public Country(string name, string capital, int population, double area)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Area = area;
        }

        public void DisplayCountryInfo()
        {
            Console.WriteLine($"Country: {Name}");
            Console.WriteLine($"Capital: {Capital}");
            Console.WriteLine($"Population: {Population}");
            Console.WriteLine($"Area: {Area} km²");
        }

        public double PopulationDensity()
        {
            return Population / Area;
        }
    }
}
