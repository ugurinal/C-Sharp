using System;

namespace MultipleClassInheritance
{
    public interface IA
    {
        void AMethod();
    }

    public class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A Method");
        }
    }

    public interface IB
    {
        void BMethod();
    }

    public class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B Method");
        }
    }

    public class AB : IA, IB
    {
        private A a;
        private B b;

        public AB()
        {
            a = new A();
            b = new B();
        }

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            AB ab = new AB();

            ab.AMethod();
            ab.BMethod();
        }
    }
}