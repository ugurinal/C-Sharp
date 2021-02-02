using System;

namespace Interfaces
{
    #region Customer

    internal interface ICustomer
    {
        void Print();

        int Add(int x1, int x2);
    }

    public class Customer : ICustomer
    {
        public int Add(int x1, int x2)
        {
            return x1 + x2;
        }

        public void Print()
        {
            Console.WriteLine("Print method");
        }

        public void Print(string x1)
        {
            Console.WriteLine(x1);
        }
    }

    #endregion Customer

    public interface Interface1
    {
        void Print();
    }

    public interface Interface2
    {
        void Print();
    }

    public class TestClass : Interface1, Interface2
    {
        void Interface1.Print()
        {
            Console.WriteLine("Interface 1");
        }

        void Interface2.Print()
        {
            Console.WriteLine("Interface 2");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.Print("test");

            ICustomer c2 = new Customer();

            c2.Print();
            ((Customer)c2).Print("asd");

            Console.WriteLine(c2 is Customer ? "Yes" : "No");
            Console.WriteLine(c1.GetType() == typeof(Customer) ? "Yes" : "No");

            TestClass t1 = new TestClass();

            ((Interface1)t1).Print();
            ((Interface2)t1).Print();

            Console.WriteLine();

            (t1 as Interface1).Print();
            (t1 as Interface2).Print();
        }
    }
}