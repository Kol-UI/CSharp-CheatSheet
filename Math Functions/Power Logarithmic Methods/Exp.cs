using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.PowerLogarithmicMethods
{
    public class Exp
    {
        public static void ExpMain()
        {
            Console.WriteLine("--- Exp ---");
            Console.WriteLine("Returns e raised to the power of specified number");
            Console.WriteLine("(Reverse of Log)\n");

            

            Console.WriteLine("Math.Exp(-2) = " + Math.Exp(-2));
            Console.WriteLine("Math.Exp(-1) = " + Math.Exp(-1));
            Console.WriteLine("Math.Exp(0) = " + Math.Exp(0));
            Console.WriteLine("Math.Exp(1) = " + Math.Exp(1));
            Console.WriteLine("Math.Exp(2) = " + Math.Exp(2));
            Console.WriteLine("Math.Exp(10.0) = " + Math.Exp(10.0));
            Console.WriteLine("Math.Exp(15.57) = " + Math.Exp(15.57));
            Console.WriteLine("Math.Exp(529.548) = " + Math.Exp(529.548));
            Console.WriteLine("Math.Exp(Double.NaN) = " + Math.Exp(Double.NaN));
            Console.WriteLine("Math.Exp(Double.NegativeInfinity) = " + Math.Exp(Double.NegativeInfinity));
            Console.WriteLine("Math.Exp(Double.PositiveInfinity) = " + Math.Exp(Double.PositiveInfinity));
        }
    }
}
