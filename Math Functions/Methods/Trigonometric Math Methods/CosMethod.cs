using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.TrigonometricMathMethods
{
    public class CosMethod
    {
        public static void CosMethodMain()
        {
            Console.WriteLine("--- Cos ---");
            Console.WriteLine("Returns the trigonometric cosine of an angle\n");

            double pi = Math.PI;
            Console.WriteLine("Math.Cos(pi/6) = " + Math.Cos(pi / 6));
            Console.WriteLine("Math.Cos(pi/4) = " + Math.Cos(pi / 4));
            Console.WriteLine("Math.Cos(pi/3) = " + Math.Cos(pi / 3));
            Console.WriteLine("Math.Cos(Double.NaN) = " + Math.Cos(Double.NaN));
            Console.WriteLine("Math.Cos(Double.NegativeInfinity) = " + Math.Cos(Double.NegativeInfinity));
            Console.WriteLine("Math.Cos(Double.PositiveInfinity) = " + Math.Cos(Double.PositiveInfinity));
        }

        public static void ACosMethodMain()
        {
            Console.WriteLine("--- Acos ---");
            Console.WriteLine("Returns the arc cosine of a value\n");

            double[] numbers = { -1, 0, 0.09, .105, 0.3584, .5, .798, 1, 4, Double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN };

            foreach (double number in numbers)
            {
                Console.WriteLine("Arc cosine of {0} is {1}.", number, Math.Acos(number));
            }
        }
    }
}
