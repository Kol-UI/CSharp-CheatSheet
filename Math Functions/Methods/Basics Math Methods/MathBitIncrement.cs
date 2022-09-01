using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathBitIncrement
    {
        public static void MethodMathBitIncrement()
        {
            Program.Space();
            Console.WriteLine("--- BitIncrement---");
            Console.WriteLine("Returns the next largest value that compares greater than the argument");
            Program.Space();
            Console.WriteLine("Math.BitIncrement(2) = " + Math.BitIncrement(2));
            Console.WriteLine("Math.BitIncrement(10.1) = " + Math.BitIncrement(10.1));
            Console.WriteLine("Math.BitIncrement(32.23) = " + Math.BitIncrement(32.23));
            Console.WriteLine("Math.BitIncrement(0) = " + Math.BitIncrement(0));
            Console.WriteLine("Math.BitIncrement(-10.1) = " + Math.BitIncrement(-10.1));
            Console.WriteLine("Math.BitIncrement(Double.NaN) = " + Math.BitIncrement(Double.NaN));
            Console.WriteLine("Math.BitIncrement(Double.NegativeInfinity) = " + Math.BitIncrement(Double.NegativeInfinity));
            Console.WriteLine("Math.BitIncrement(Double.PositiveInfinity) = " + Math.BitIncrement(Double.PositiveInfinity));
        }
    }
}
