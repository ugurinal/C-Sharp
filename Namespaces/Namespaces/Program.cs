using System;
using ProjectA.TeamA;

using PATA = ProjectA.TeamA;

using PATB = ProjectA.TeamB;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassA.Print();     // since we are using ProjectA.TeamA this will call ProjectA.TeamA.ClassA.Print()
        // if we use using ProjectA.TeamB with TeamA this will not compile because of the  ambiguous

        ProjectA.TeamB.ClassA.Print();

        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }
}

/*
namespace ProjectA
{
    namespace TeamA
    {
        internal class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Project A - Class A - Print");
            }
        }
    }
}
*/

/*
namespace ProjectA
{
    namespace TeamB
    {
        internal class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Project A - Class B - Print");
            }
        }
    }
}
*/