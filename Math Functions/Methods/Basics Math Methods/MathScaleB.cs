using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathScaleB
    {
        public static void MethodMathScaleB()
        {
            Program.Space();
            Console.WriteLine("--- ScaleB ---");
            Console.WriteLine("ScaleB(a, b) returns a x 2b.");
            Program.Space();
            ScaleBResult(1, 2);
            ScaleBResult(3, 2);
            ScaleBResult(7, 8);
            ScaleBResult(3, 3);
            ScaleBResult(4, 2);
            ScaleBResult(5, 4);
            Console.WriteLine("ScaleB(2.55, 4) = " + Math.ScaleB(2.55, 4));
            Console.WriteLine("ScaleB(10, 3) = " + Math.ScaleB(10, 3));
            Console.WriteLine("ScaleB(Double.NaN, 3) = " + Math.ScaleB(Double.NaN, 3));
            Console.WriteLine("ScaleB(Double.PositiveInfinity, 3) = " + Math.ScaleB(Double.PositiveInfinity, 3));
        }

        private static void ScaleBResult(double x, int n)
        {
            double result;
            result = Math.ScaleB(x, n);
            Console.WriteLine($"ScaleB({x}, {n}) = {result}");
        }
    }
}
