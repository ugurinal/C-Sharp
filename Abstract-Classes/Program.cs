using System;

namespace Abstract_Classes
{
    public abstract class Customer
    {
        /// <summary>
        /// an abstract class can not be sealed since it can only be used as base class
        /// </summary>
        public abstract void Print();
    }

    public class VIPCustomer : Customer
    {
        private int counter;

        public VIPCustomer()
        {
            counter = 0;
        }

        /// <summary>
        /// we must implement print method to compile
        /// </summary>
        public override void Print()    // we have to use override keyword
        {
            counter++;
            Console.WriteLine("VIP Customer print method " + counter);
        }
    }

    public abstract class NormalCustomer : Customer
    {
        /// <summary>
        /// We don't need to implement Print method here
        /// since this class also an abstract class
        /// </summary>
    }

    public abstract class Student
    {
        public void Print()
        {
            Console.WriteLine("Student print method");
        }
    }

    public class HighSchool : Student
    {
        public new void Print()
        {
            Console.WriteLine("High School student print method");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Customer c1 = new Customer(); we can not create an instance of abstract class

            Customer c1 = new VIPCustomer();
            VIPCustomer c2 = new VIPCustomer();
            // VIPCustomer c2 = new Customer(); wrong

            c1.Print();
            c2.Print();

            c1.Print();

            HighSchool s1 = new HighSchool();
            Student s2 = new HighSchool();
            // Student s3 = new Student(); wrong

            s1.Print();
            s2.Print();
        }
    }
}