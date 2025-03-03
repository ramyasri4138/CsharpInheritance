using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    using System;
    public sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("Authenticating user...");
        }
    }

    //this will get an error, because it is inheriting an sealed class
    //public class AdvancedSecuritySystem : SecuritySystem
    //{
    //    // Additional methods and properties can be added here
    //}

}
