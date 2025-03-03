using CsharpInheritance;
using System.Globalization;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car
//        {
//            Brand = "Toyota",
//            Speed = 120
//        };

//        Bike bike = new Bike
//        {
//            Brand = "Yamaha",
//            Speed = 80
//        };

//        car.DisplayCarInfo();
//        bike.DisplayBikeInfo();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Employee emp = new Employee("Alice", 50000);
//        Manager mgr = new Manager("Bob", 80000, 10000);

//        emp.DisplayInfo();
//        mgr.DisplayInfo();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Animal myDog = new Dog();
//        Animal myCat = new Cat();

//        myDog.MakeSound();
//        myCat.MakeSound();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Robot myRobot = new Robot();
//        myRobot.Start();
//        myRobot.Move();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Account myAccount = new Account();
//        SavingsAccount mySavingsAccount = new SavingsAccount();

//        myAccount.CalculateInterest();
//        mySavingsAccount.CalculateInterest();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Duck myDuck = new Duck();
//        myDuck.Fly();
//        myDuck.Swim();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Student student = new Student { Name = "John", StudentId = 12345 };
//        Person person = student;
//        Console.WriteLine($"Person Name: {person.Name}");
//        if (person is Student)
//        {
//            Student downcastedStudent = (Student)person;
//            Console.WriteLine($"Student Name: {downcastedStudent.Name}, Student ID: {downcastedStudent.StudentId}");
//        }
//        else
//        {
//            Console.WriteLine("Downcasting failed.");
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Product laptop = new ElectronicProduct { Name = "Laptop", Price = 1000m };
//        Product tshirt = new ClothingProduct { Name = "T-Shirt", Price = 50m };

//        Console.WriteLine($"Product: {laptop.Name}, Original Price: {laptop.Price:C}, Discounted Price: {laptop.GetDiscountedPrice():C}");
//        Console.WriteLine($"Product: {tshirt.Name}, Original Price: {tshirt.Price:C}, Discounted Price: {tshirt.GetDiscountedPrice():C}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Product laptop = new ElectronicProduct { Name = "Laptop", Price = 1000m };
//        Product tshirt = new ClothingProduct { Name = "T-Shirt", Price = 50m };

//        CultureInfo culture = new CultureInfo("en-US");

//        Console.WriteLine($"Product: {laptop.Name}, Original Price: {laptop.Price.ToString("C", culture)}, Discounted Price: {laptop.GetDiscountedPrice().ToString("C", culture)}");
//        Console.WriteLine($"Product: {tshirt.Name}, Original Price: {tshirt.Price.ToString("C", culture)}, Discounted Price: {tshirt.GetDiscountedPrice().ToString("C", culture)}");
//    }
//}

public class Program
{
    public static void Main()
    {
        SecuritySystem security = new SecuritySystem();
        security.AuthenticateUser();
    }
}