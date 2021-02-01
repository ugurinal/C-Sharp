using System;

namespace Polymorphism
{
    public class Employee
    {
        public virtual void PrintMethod()
        {
            Console.WriteLine("Employee Print method called");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintMethod()
        {
            Console.WriteLine("FullTimeEmployee Print method called");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintMethod()
        {
            Console.WriteLine("PartTimeEmployee Print method called");
        }
    }

    public class TemproryEmployee : Employee
    {
        public override void PrintMethod()
        {
            Console.WriteLine("TemproryEmployee Print method called");
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Polymorphism allows us to invoke derived class method through a base class reference
             * during runtime
             */

            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemproryEmployee();

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintMethod();
            }
        }
    }
}