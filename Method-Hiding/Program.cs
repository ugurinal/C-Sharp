using System;

namespace Method_Hiding
{
    public class Employee
    {
        private string fullName;

        public void PrintMethod()
        {
            Console.WriteLine("Employee - Print method");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public new void PrintMethod()
        {
            base.PrintMethod(); // this will call Employee.PrintMethod()
            Console.WriteLine("FullTimeEmployee - Print method");
        }
    }

    public class PartTimeEmployee : Employee
    {
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.PrintMethod();  // this will call FullTimeEmployee.PrintMethod()
            ((Employee)fte).PrintMethod();  // this will call Employee.PrintMethod();

            Employee emp = new FullTimeEmployee();
            emp.PrintMethod();  // Employee.PrintMethod() will be called
        }
    }
}