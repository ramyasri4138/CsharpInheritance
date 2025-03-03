using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    using System;

    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        // Base class constructor
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary:C}");
        }
    }

    public class Manager : Employee
    {
        public decimal Bonus { get; set; }
        public Manager(string name, decimal salary, decimal bonus)
            : base(name, salary)
        {
            Bonus = bonus;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus:C}");
        }
    }

}
