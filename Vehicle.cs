using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed:{Speed}");
        }
    }
    class Car : Vehicle
    {
        public void DisplayCarInfo()
        {
            Console.WriteLine("Car info");
            DisplayInfo();
        }
    }
    class Bike : Vehicle
    {
        public void DisplayBikeInfo()
        {
            Console.WriteLine("Bike info");
            DisplayInfo();
        }
    }
}
