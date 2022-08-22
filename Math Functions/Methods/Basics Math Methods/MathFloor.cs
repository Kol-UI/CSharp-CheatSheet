using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathFloor
    {
        public static void MethodMathFloor()
        {
            Program.Space();
            Console.WriteLine("--- Floor ---");
            Console.WriteLine("Rounds the given number down to the nearest integer.");
            Program.Space();
            Console.WriteLine("Math.Floor(10.5) = " + Math.Floor(10.5));
            Console.WriteLine("Math.Floor(-10.5) = " + Math.Floor(-10.5));
            Console.WriteLine("Math.Floor(0.5) = " + Math.Floor(0.5));
            Console.WriteLine("Math.Floor(-0.5) = " + Math.Floor(-0.5));
            Console.WriteLine("Math.Floor(Double.NaN) = " + Math.Floor(Double.NaN));
            Console.WriteLine("Math.Floor(Double.NegativeInfinity) = " + Math.Floor(Double.NegativeInfinity));
            Console.WriteLine("Math.Floor(Double.PositiveInfinity) = " + Math.Floor(Double.PositiveInfinity));
            Program.Space();
            decimal[] values = { 10.4m, 7.64m, 7.03m, 7.4m, 3.7m, 0.12m, -0.12m, -1.3m, -3.1m, -7.1m, -7.6m, -10.5m };
            Console.WriteLine("  Value          Ceiling          Floor\n");
            foreach (decimal value in values)
            {
                Console.WriteLine("{0,7} {1,16} {2,14}", value, Math.Ceiling(value), Math.Floor(value));
            }
        }
    }
}
