using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathTruncate
    {
        public static void MethodMathTruncate()
        {
            Program.Space();
            Console.WriteLine("--- Truncate ---");
            Console.WriteLine("Rounds the given number towards zero.");
            Program.Space();

            Console.WriteLine("Double:");
            Console.WriteLine("Truncate(2.5) = " + Math.Truncate(2.5));
            Console.WriteLine("Truncate(5.78) = " + Math.Truncate(5.78));
            Console.WriteLine("Truncate(-3.5) = " + Math.Truncate(-3.5));
            Console.WriteLine("Truncate(-10.33) = " + Math.Truncate(-10.33));
            Console.WriteLine("Truncate(Double.NaN) = " + Math.Truncate(double.NaN));
            Console.WriteLine("Truncate(Double.NegativeInfinity) = " + Math.Truncate(double.NegativeInfinity));
            Console.WriteLine("Truncate(Double.PositiveInfinity) = " + Math.Truncate(double.PositiveInfinity));
            ResultDoubleTruncate(7.5785);
            ResultDoubleTruncate(-7.5785);
            Program.Space();

            Console.WriteLine("Decimal:");
            ResultDecimalTruncate(7.5785M);
            ResultDecimalTruncate(-7.5785M);
            ResultDecimalTruncate(0.17525M);
            Program.Space();
        }

        private static void ResultDoubleTruncate(double d)
        {
            double result;
            result = Math.Truncate(d);
            Console.WriteLine($"Truncate of {d} is {result}.");
        }

        private static void ResultDecimalTruncate(decimal d)
        {
            decimal result;
            result = Math.Truncate(d);
            Console.WriteLine($"Truncate of {d} is {result}.");
        }
    }
}
