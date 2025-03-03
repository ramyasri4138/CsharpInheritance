using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    using System;

    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
    }
}
