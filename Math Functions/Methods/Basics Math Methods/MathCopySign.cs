using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathCopySign
    {
        public static void MethodMathCopySign()
        {
            Program.Space();
            Console.WriteLine("--- CopySign ---");
            Console.WriteLine("Returns a number with magnitude of first argument and sign of second argument.");
            Program.Space();
            CopySignResult(2, -8);
            CopySignResult(2, 8);
            CopySignResult(-2, 8);
            Console.WriteLine("CopySign(48.45, 3) = " + Math.CopySign(48.45, 3));
            Console.WriteLine("CopySign(48.45, -3) = " + Math.CopySign(48.45, -3));
            Console.WriteLine("CopySign(-48.45, 3) = " + Math.CopySign(-48.45, 3));
            Console.WriteLine("CopySign(-48.45, -3) = " + Math.CopySign(-48.45, -3));
            Console.WriteLine("CopySign(Double.NegativeInfinity, 2) = " + Math.CopySign(Double.NegativeInfinity, 2));
            Console.WriteLine("CopySign(Double.PositiveInfinity, -3) = " + Math.CopySign(Double.PositiveInfinity, -3));
        }

        private static void CopySignResult(int x, int y)
        {
            double result;
            result = Math.CopySign(x, y);
            Console.WriteLine($"CopySign({x}, {y}) = {result}");
        }
    }
}
