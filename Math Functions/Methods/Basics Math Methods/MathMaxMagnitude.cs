using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathMaxMagnitude
    {
        public static void MethodMathMaxMagnitude()
        {
            Program.Space();
            Console.WriteLine("--- MaxMagnitude ---");
            Console.WriteLine("Returns the number with larger magnitude.");
            Program.Space();
            ResultMaxMagnitude(3, 4);
            ResultMaxMagnitude(4, 3);
            ResultMaxMagnitude(4, 4);
            ResultMaxMagnitude(-4, 4);
            ResultMaxMagnitude(-3, -3);
            ResultMaxMagnitude(-3, 3);
            ResultMaxMagnitude(-1, 2);
            ResultMaxMagnitude(0, -2);
            ResultMaxMagnitude(10, 4);
            ResultMaxMagnitude(79, -853);
            ResultMaxMagnitude(10, 10);
            Console.WriteLine("MaxMagnitude(50, -100) = " + Math.MaxMagnitude(50, -100));
            Console.WriteLine("MaxMagnitude(-5.5, 10.5) = "+ Math.MaxMagnitude(-5.5, 10.5));
            Console.WriteLine("MaxMagnitude(5, -10.5) = "+ Math.MaxMagnitude(5, -10.5));
            Console.WriteLine("MaxMagnitude(10, Double.NaN) = " + Math.MaxMagnitude(10, Double.NaN));
            Console.WriteLine("MaxMagnitude(10, Double.NegativeInfinity) = " + Math.MaxMagnitude(10, Double.NegativeInfinity));
            Console.WriteLine("MaxMagnitude(10, Double.PositiveInfinity) = " + Math.MaxMagnitude(10, Double.PositiveInfinity));
        }

        private static void ResultMaxMagnitude(double x, double y)
        {
            double result;
            result = Math.MaxMagnitude(x, y);
            Console.WriteLine($"MaxMagnitude({x}, {y}) = {result}");
        }
    }
}
