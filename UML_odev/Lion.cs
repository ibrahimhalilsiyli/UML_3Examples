using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_odev
{
    internal class Lion
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }

        public void Roar()
        {
            Console.WriteLine($"{Name} roars loudly!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting in the savannah...");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping under a tree.");
        }
    }
}
