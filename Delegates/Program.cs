using System;

namespace Delegates
{
    internal class Program
    {
        private delegate void HelloDelegate(string message);

        private static void Main(string[] args)
        {
            HelloDelegate del = new HelloDelegate(Hello);

            del += Test;
            del += Test;
            del += Test;
            del += Test;
            del -= Hello;

            del("Hello from delegate");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        public static void Test(string message)
        {
            Console.WriteLine(message);
        }
    }
}