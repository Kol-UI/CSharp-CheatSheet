using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathMax
    {
        public static void MethodMathMax()
        {
            Program.Space();
            Console.WriteLine("--- Max ---");
            Console.WriteLine("Returns the number with maximum value.");
            Program.Space();
            ResultMax(7, 25);
            ResultMax(3, 10);
            ResultMax(7, 7);
            ResultMax(7, 2);
            Console.WriteLine("Math.Max(50, 100) returns: " + Math.Max(50, 100));
            Console.WriteLine("Math.Max(5.5f, 10.5f) returns: " + Math.Max(5.5f, 10.5f));
            Console.WriteLine("Math.Max(5, 10.5f) returns: " + Math.Max(5, 10.5f));
            Console.WriteLine("Math.Max(10, Double.NaN) returns: " + Math.Max(10, Double.NaN));
            Console.WriteLine("Math.Max(10, Double.NegativeInfinity) returns: " + Math.Max(10, Double.NegativeInfinity));
            Console.WriteLine("Math.Max(10, Double.PositiveInfinity) returns: " + Math.Max(10, Double.PositiveInfinity));
            TypesMax();
        }

        private static void ResultMax(byte val1, byte val2)
        {
            byte result = Math.Max(val1, val2);
            Console.WriteLine($"Maximum of {val1} and {val2} is {result}.");
        }

        private static void TypesMax()
        {
            Program.Space();
            Console.WriteLine("-- Depending of Types --");
            string str = "{0}: The greater of {1,3} and {2,3} is {3}.";

            byte xByte1 = 1, xByte2 = 51;
            short xShort1 = -2, xShort2 = 52;
            int xInt1 = -3, xInt2 = 53;
            long xLong1 = -4, xLong2 = 54;
            float xSingle1 = 5.0f, xSingle2 = 55.0f;
            double xDouble1 = 6.0, xDouble2 = 56.0;
            decimal xDecimal1 = 7m, xDecimal2 = 57m;
            sbyte xSbyte1 = 101, xSbyte2 = 111;
            ushort xUshort1 = 102, xUshort2 = 112;
            uint xUint1 = 103, xUint2 = 113;
            ulong xUlong1 = 104, xUlong2 = 114;

            Console.WriteLine("Display the greater of two values:\n");
            Console.WriteLine(str, "Byte   ", xByte1, xByte2, Math.Max(xByte1, xByte2));
            Console.WriteLine(str, "Int16  ", xShort1, xShort2, Math.Max(xShort1, xShort2));
            Console.WriteLine(str, "Int32  ", xInt1, xInt2, Math.Max(xInt1, xInt2));
            Console.WriteLine(str, "Int64  ", xLong1, xLong2, Math.Max(xLong1, xLong2));
            Console.WriteLine(str, "Single ", xSingle1, xSingle2, Math.Max(xSingle1, xSingle2));
            Console.WriteLine(str, "Double ", xDouble1, xDouble2, Math.Max(xDouble1, xDouble2));
            Console.WriteLine(str, "Decimal", xDecimal1, xDecimal2, Math.Max(xDecimal1, xDecimal2));
            Console.WriteLine(str, "SByte  ", xSbyte1, xSbyte2, Math.Max(xSbyte1, xSbyte2));
            Console.WriteLine(str, "UInt16 ", xUshort1, xUshort2, Math.Max(xUshort1, xUshort2));
            Console.WriteLine(str, "UInt32 ", xUint1, xUint2, Math.Max(xUint1, xUint2));
            Console.WriteLine(str, "UInt64 ", xUlong1, xUlong2, Math.Max(xUlong1, xUlong2));

        }
    }
}
