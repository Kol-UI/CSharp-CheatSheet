using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.HyperbolicMathMethods
{
    public class Atanh
    {
        public static void AtanhMain()
        {
            Console.WriteLine("--- Atanh ---");
            Console.WriteLine("Returns the inverse hyperbolic tangent of a value\n");


            double[] numbers = {-500, -10, -1, 0, 0.09, .105, .5, .798, 1, 4, 6.9, 8, 10, 25, 27.8967, 46, 50, 64, 75, 81,
                          100, 125.2534, 250, 500, 750, 1000, double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN};

            foreach (double number in numbers)
            {
                Console.WriteLine("Inverse hyperbolic tangent of {0} is {1}.", number, Math.Atanh(number));
            }
        }
    }
}
