using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathSign
    {
        public static void MethodMathSign()
        {
            string str = "{0}: {1,3} is {2} zero.";
            string nl = Environment.NewLine;
            byte xByte1 = 0;
            short xShort1 = -2;
            int xInt1 = -3;
            long xLong1 = -4;
            float xSingle1 = 0.0f;
            double xDouble1 = 6.0;
            decimal xDecimal1 = -7m;
            sbyte xSbyte1 = -101;

            Program.Space();
            Console.WriteLine("--- Sign ---");
            Console.WriteLine("Returns an integer that indicates the sign of the argument.");
            Program.Space();

            Console.WriteLine("Sign(48.45) = " + Math.Sign(48.45));
            Console.WriteLine("Sign(-48.667) = " + Math.Sign(-48.667));
            Console.WriteLine("Sign(0) = " + Math.Sign(0));
            Console.WriteLine("Sign(Double.NegativeInfinity) = " + Math.Sign(double.NegativeInfinity));
            Console.WriteLine("Sign(Double.PositiveInfinity) = " + Math.Sign(double.PositiveInfinity));

            Console.WriteLine($"{nl}Test the sign of the following types of values:");
            Console.WriteLine(str, "Byte   ", xByte1, TestSign(Math.Sign(xByte1)));
            Console.WriteLine(str, "Int16  ", xShort1, TestSign(Math.Sign(xShort1)));
            Console.WriteLine(str, "Int32  ", xInt1, TestSign(Math.Sign(xInt1)));
            Console.WriteLine(str, "Int64  ", xLong1, TestSign(Math.Sign(xLong1)));
            Console.WriteLine(str, "Single ", xSingle1, TestSign(Math.Sign(xSingle1)));
            Console.WriteLine(str, "Double ", xDouble1, TestSign(Math.Sign(xDouble1)));
            Console.WriteLine(str, "Decimal", xDecimal1, TestSign(Math.Sign(xDecimal1)));
            Console.WriteLine(str, "SByte  ", xSbyte1, TestSign(Math.Sign(xSbyte1)));
        }

        private static string TestSign(int compare)
        {
            if (compare == 0)
            {
                return "equal to";
            }
            else
            {
                return compare < 0 ? "less than" : "greater than";
            }
        }
    }
}
