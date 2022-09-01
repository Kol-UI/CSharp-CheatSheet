using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.PowerLogarithmicMethods
{
    public class Log
    {
        public static void LogMain()
        {
            Console.WriteLine("--- Log ---");
            Console.WriteLine("Returns the natural logarithm\n"); 

            Console.WriteLine("Math.Log(0) = " + Math.Log(0));
            Console.WriteLine("Math.Log(10) = " + Math.Log(10));
            Console.WriteLine("Math.Log(20) = " + Math.Log(20));
            Console.WriteLine("Math.Log(50) = " + Math.Log(50));
            Console.WriteLine("Math.Log(Double.NaN) = " + Math.Log(Double.NaN));
            Console.WriteLine("Math.Log(Double.NegativeInfinity) = " + Math.Log(Double.NegativeInfinity));
            Console.WriteLine("Math.Log(Double.PositiveInfinity) = " + Math.Log(Double.PositiveInfinity));

            Program.Space();
            LogSpecifiedBase();
            Program.Space();
            LogTen();
            Program.Space();
            LogTwo();
            Program.Space();
            ILogB();
        }

        private static void LogSpecifiedBase()
        {
            Console.WriteLine("--- Log Specified Base ---");
            Console.WriteLine("Returns logarithm to the specified base of a given number\n");


            Console.WriteLine("Math.Log(10, 10) = " + Math.Log(10, 10));
            Console.WriteLine("Math.Log(32, 2) = " + Math.Log(32, 2));
            Console.WriteLine("Math.Log(9, 3) = " + Math.Log(9, 3));
        }

        private static void LogTen()
        {
            Console.WriteLine("--- Log10 ---");
            Console.WriteLine("Returns the base-10 logarithm of a given number\n");


            Console.WriteLine("Math.Log10(0) = " + Math.Log10(0));
            Console.WriteLine("Math.Log10(10) = " + Math.Log10(10));
            Console.WriteLine("Math.Log10(50) = " + Math.Log10(25));
            Console.WriteLine("Math.Log10(50) = " + Math.Log10(50));
            Console.WriteLine("Math.Log10(100) = " + Math.Log10(100));
            Console.WriteLine("Math.Log10(Double.NaN) = " + Math.Log10(Double.NaN));
            Console.WriteLine("Math.Log10(Double.NegativeInfinity) = " + Math.Log10(Double.NegativeInfinity));
            Console.WriteLine("Math.Log10(Double.PositiveInfinity) = " + Math.Log10(Double.PositiveInfinity));

            double[] numbers = {-10, -1, 0, .105, .5, .798, 1, 4, 6.9, 10, 25, 50, 75,
                          100, 250, 500, 750, 1000, Double.MaxValue};

            foreach (double number in numbers)
            {
                Console.WriteLine("The base 10 log of {0} is {1}.", number, Math.Log10(number));
            }
        }

        private static void LogTwo()
        {
            Console.WriteLine("--- Log2 ---");
            Console.WriteLine("Returns the base-2 logarithm of a given number\n");


            double[] numbers = {-10, -1, 0, .105, .5, .798, 1, 4, 6.9, 10, 25, 50, 75,
                          100, 250, 500, 750, 1000, Double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN};
            
            foreach (double number in numbers)
            {
                Console.WriteLine("The base 2 log of {0} is {1}.", number, Math.Log2(number));
            }
        }

        private static void ILogB()
        {
            Console.WriteLine("--- ILogB ---");
            Console.WriteLine("Returns the base-2 integer logarithm of a given number\n");


            double[] numbers = {-10, -1, 0, .105, .5, .798, 1, 4, 6.9, 10, 25, 50, 75,
                          100, 250, 500, 750, 1000, Double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN};

            foreach (double number in numbers)
            {
                Console.WriteLine("The IbaseB log of {0} is {1}.", number, Math.ILogB(number));
            }
        }
    }
}
