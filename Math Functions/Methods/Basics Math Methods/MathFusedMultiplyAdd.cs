using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathFusedMultiplyAdd
    {
        public static void MethodMathFusedMultiplyAdd()
        {
            Console.WriteLine("--- FusedMultiplyAdd ---");
            Console.WriteLine("Method returns (x*y) + z.");
            Program.Space();
            Console.WriteLine("Math.FusedMultiplyAdd(2, 3, 10) = " + Math.FusedMultiplyAdd(2, 3, 10));
            Console.WriteLine("Math.FusedMultiplyAdd(-2, 5, 10) = " + Math.FusedMultiplyAdd(-2, 5, 10));
            Console.WriteLine("Math.FusedMultiplyAdd(2.1, 3.3, 55) = " + Math.FusedMultiplyAdd(2.1, 3.3, 55));
            Console.WriteLine("Math.FusedMultiplyAdd(Double.NaN, 3.3, 55) = " + Math.FusedMultiplyAdd(Double.NaN, 3.3, 55));
        }
    }
}
