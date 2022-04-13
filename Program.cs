using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // dotnet run
            // Exercise 5
            Space();
            BasicMaths();

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }

        public static void Space()
        {
            System.Console.WriteLine();
        }

        public static void BasicMaths()
        {
            Sum();
            Divide();
            MoreMaths();
        }

        public static void Sum()
        {
            System.Console.WriteLine("Sum:");
            System.Console.WriteLine(15+17);
            Space();
        }

        public static void Divide()
        {
            System.Console.WriteLine("Divide:");
            System.Console.WriteLine(36/6);
            Space();
        }

        public static void MoreMaths()
        {
            int num1 = -1 + 4 * 6;
            int num2 = (35 + 5) % 7;
            double num3 = 14 + -4 * 6 / 11;
            double num4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}");
            Space();
        }
    }
}
