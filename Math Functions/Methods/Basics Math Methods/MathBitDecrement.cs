using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathBitDecrement
    {
        public static void MethodMathBitDecrement()
        {
            Program.Space();
            Console.WriteLine("--- BitDecrement ---");
            Console.WriteLine("Returns the next smallest value that compares less than the argument");
            Program.Space();
            Console.WriteLine("Math.BitDecrement(2) = " + Math.BitDecrement(2));
            Console.WriteLine("Math.BitDecrement(10.1) = " + Math.BitDecrement(10.1));
            Console.WriteLine("Math.BitDecrement(32.23) = " + Math.BitDecrement(32.23));
            Console.WriteLine("Math.BitDecrement(0) = " + Math.BitDecrement(0));
            Console.WriteLine("Math.BitDecrement(-10.1) = " + Math.BitDecrement(-10.1));
            Console.WriteLine("Math.BitDecrement(Double.NaN) = " + Math.BitDecrement(Double.NaN));
            Console.WriteLine("Math.BitDecrement(Double.NegativeInfinity) = " + Math.BitDecrement(Double.NegativeInfinity));
            Console.WriteLine("Math.BitDecrement(Double.PositiveInfinity) = " + Math.BitDecrement(Double.PositiveInfinity));
        }
    }
}
