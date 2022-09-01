using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathMinMagnitude
    {
        public static void MethodMathMinMagnitude()
        {
            Program.Space();
            Console.WriteLine("--- MinMagnitude ---");
            Console.WriteLine("Returns the number with smaller magnitude.");
            Program.Space();
            ResultMinMagnitude(3, 4);
            ResultMinMagnitude(4, 3);
            ResultMinMagnitude(4, 4);
            ResultMinMagnitude(-4, 4);
            ResultMinMagnitude(-3, -3);
            ResultMinMagnitude(-3, 3);
            ResultMinMagnitude(-1, 2);
            ResultMinMagnitude(0, -2);
            ResultMinMagnitude(10, 4);
            ResultMinMagnitude(79, -853);
            ResultMinMagnitude(10, 10);
            Console.WriteLine("MinMagnitude(50, -100) = " + Math.MinMagnitude(50, -100));
            Console.WriteLine("MinMagnitude(-5.5, 10.5) = " + Math.MinMagnitude(-5.5, 10.5));
            Console.WriteLine("MinMagnitude(5, -10.5) = " + Math.MinMagnitude(5, -10.5));
            Console.WriteLine("MinMagnitude(10, Double.NaN) = " + Math.MinMagnitude(10, Double.NaN));
            Console.WriteLine("MinMagnitude(10, Double.NegativeInfinity) = " + Math.MinMagnitude(10, Double.NegativeInfinity));
            Console.WriteLine("MinMagnitude(10, Double.PositiveInfinity) = " + Math.MinMagnitude(10, Double.PositiveInfinity));
        }

        private static void ResultMinMagnitude(double x, double y)
        {
            double result;
            result = Math.MinMagnitude(x, y);
            Console.WriteLine($"MinMagnitude({x}, {y}) = {result}");
        }
    }
}
