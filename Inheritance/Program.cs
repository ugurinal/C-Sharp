using System;

namespace Inheritance
{
    public class Employee
    {
        public string fullName;

        public Employee()
        {
            fullName = "Unknown";
            Console.WriteLine("Parameterless Employee constructor called!");
        }

        public Employee(string fullName)
        {
            this.fullName = fullName;
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;

        public FullTimeEmployee()
        {
            Console.WriteLine("Parameterless FullTimeEmployee constructor called!");
        }

        public FullTimeEmployee(float yearlySalary, string test) : base(test)
        {
            this.yearlySalary = yearlySalary;
        }
    }

    public class PartTimeEmployee : Employee
    {
        public double hourlyRate;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee(120000f, "james");

            FullTimeEmployee fte1 = new FullTimeEmployee();
        }
    }
}