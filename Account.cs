using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    using System;

    public class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in the base Account class.");
        }
    }

    public class SavingsAccount : Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest in the SavingsAccount class.");
        }
    }


}
