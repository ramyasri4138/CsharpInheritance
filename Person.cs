using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    using System;

    public class Person
    {
        public string Name { get; set; }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
    }
}
