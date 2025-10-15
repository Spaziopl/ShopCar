using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp
{
    internal class Car
    {
        public string Brand { get; set; }
        public int YearProduction { get; set; }
        public Car(string brand, int yearProduction) 
        {
            Brand = brand;
            YearProduction = yearProduction;
        }

        public void Introduce()
        {
            Console.WriteLine($"This car is brand: {Brand}, and it create in {YearProduction}y.");
        }
    }
}
