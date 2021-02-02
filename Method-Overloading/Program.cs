using System;

namespace Method_Overloading
{
    public static class Operations
    {
        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static int Add(int first, int second, int third)
        {
            return first + second + third;
        }

        public static int Add(int first, int second, out int third)
        {
            third = first + second;
            return first + second;
        }

        public static float Add(float first, float second)
        {
            Console.WriteLine("Not params");

            return first + second;
        }

        public static float Add(float first, params float[] arr)
        {
            Console.WriteLine("Params");

            return first;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Operations.Add(5f, 6f));
        }
    }
}