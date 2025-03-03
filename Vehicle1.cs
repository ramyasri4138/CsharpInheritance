using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    public class Vehicle1
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
        }
    }

    public class Car1 : Vehicle1
    {
        public int NumberOfDoors { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    public class Bike1 : Vehicle1
    {
        public bool HasCarrier { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }

}
