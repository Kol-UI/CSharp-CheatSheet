using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.TrigonometricMathMethods
{
    public class SinMethod
    {
        public static void SinMethodMain()
        {
            Console.WriteLine("--- Sin ---");
            Console.WriteLine("Returns the trigonometric sine of an angle\n");

            double val1 = 30.0;
            Console.WriteLine("Sin of 30.0:");
            Console.WriteLine(Math.Sin(val1 * Math.PI / 180));

            Console.WriteLine("Other Examples:");
            double pi = Math.PI;
            Console.WriteLine("Math.Sin(pi/6) = " + Math.Sin(pi / 6));
            Console.WriteLine("Math.Sin(pi/4) = " + Math.Sin(pi / 4));
            Console.WriteLine("Math.Sin(pi/3) = " + Math.Sin(pi / 3));
            Console.WriteLine("Math.Sin(Double.NaN) = " + Math.Sin(Double.NaN));
            Console.WriteLine("Math.Sin(Double.NegativeInfinity) = " + Math.Sin(Double.NegativeInfinity));
            Console.WriteLine("Math.Sin(Double.PositiveInfinity) = " + Math.Sin(Double.PositiveInfinity));
        }

        public static void ASinMethodMain()
        {
            Console.WriteLine("--- Asin ---");
            Console.WriteLine("Returns the arc sine of a value\n");

            double[] numbers = { -1, 0, 0.09, .105, 0.3584, .5, .798, 1, 4, Double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN };

            foreach (double number in numbers)
            {
                Console.WriteLine("Arc sine of {0} is {1}.", number, Math.Asin(number));
            }
        }
    }
}
