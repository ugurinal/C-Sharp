using System;

namespace Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;

            RefMethod(ref a, ref b);

            Console.WriteLine("A = {0} - B = {1}",a ,b);

            /*
            int total = 0;
            int product = 0;

            Calculate(10, 20, out total, out product);

            Console.WriteLine("Sum {0} - Product {1}", total, product);
            */

            /**

            int[] numbers = { 1, 2, 3 };

            ParamsMethod(numbers);
            //  ParamsMethod(); // this will not be compiled if we don't use params keyword in ParamsMethod
            // ParamsMethod(params int[])

            ParamsMethod();     // this will work since we used params keyword
            ParamsMethod(10, 20, 30, 40, 50, 60, 70, 80, 90);

            /*
             * params keyword must be used at last
             * we can use only one params keyword in a method
             * but we can use params like (int x, int y, params int[] array)
             */
            

        }

        public static void RefMethod(ref int x, ref int y)
        {
            // swap numbers
            x = x + y;
            y = x - y;
            x = x - y;
        }

        public static void Calculate(int first, int second, out int sum, out int product)
        {
            sum = first + second;
            product = first * second;
        }

        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);

            foreach(int x in numbers)
            {
                Console.Write("{0}\t", x);
            }
            Console.WriteLine();
        }

    }
}
