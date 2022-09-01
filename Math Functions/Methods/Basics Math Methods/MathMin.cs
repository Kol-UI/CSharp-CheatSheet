using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathMin
    {
        public static void MethodMathMin()
        {
            Program.Space();
            Console.WriteLine("--- Min ---");
            Console.WriteLine("Returns the number with Minimum value.");
            Program.Space();
            ResultMin(7, 25);
            ResultMin(3, 10);
            ResultMin(7, 7);
            ResultMin(7, 2);
            Console.WriteLine("Math.Min(50, 100) returns: " + Math.Min(50, 100));
            Console.WriteLine("Math.Min(5.5f, 10.5f) returns: " + Math.Min(5.5f, 10.5f));
            Console.WriteLine("Math.Min(5, 10.5f) returns: " + Math.Min(5, 10.5f));
            Console.WriteLine("Math.Min(10, Double.NaN) returns: " + Math.Min(10, Double.NaN));
            Console.WriteLine("Math.Min(10, Double.NegativeInfinity) returns: " + Math.Min(10, Double.NegativeInfinity));
            Console.WriteLine("Math.Min(10, Double.PositiveInfinity) returns: " + Math.Min(10, Double.PositiveInfinity));
            TypesMin();
        }

        private static void ResultMin(byte val1, byte val2)
        {
            byte result = Math.Min(val1, val2);
            Console.WriteLine($"Minimum of {val1} and {val2} is {result}.");
        }

        private static void TypesMin()
        {
            Program.Space();
            Console.WriteLine("-- Depending of Types --");
            string str = "{0}: The lesser of {1,3} and {2,3} is {3}.";

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

            Console.WriteLine("Display the lesser of two values:\n");
            Console.WriteLine(str, "Byte   ", xByte1, xByte2, Math.Min(xByte1, xByte2));
            Console.WriteLine(str, "Int16  ", xShort1, xShort2, Math.Min(xShort1, xShort2));
            Console.WriteLine(str, "Int32  ", xInt1, xInt2, Math.Min(xInt1, xInt2));
            Console.WriteLine(str, "Int64  ", xLong1, xLong2, Math.Min(xLong1, xLong2));
            Console.WriteLine(str, "Single ", xSingle1, xSingle2, Math.Min(xSingle1, xSingle2));
            Console.WriteLine(str, "Double ", xDouble1, xDouble2, Math.Min(xDouble1, xDouble2));
            Console.WriteLine(str, "Decimal", xDecimal1, xDecimal2, Math.Min(xDecimal1, xDecimal2));
            Console.WriteLine(str, "SByte  ", xSbyte1, xSbyte2, Math.Min(xSbyte1, xSbyte2));
            Console.WriteLine(str, "UInt16 ", xUshort1, xUshort2, Math.Min(xUshort1, xUshort2));
            Console.WriteLine(str, "UInt32 ", xUint1, xUint2, Math.Min(xUint1, xUint2));
            Console.WriteLine(str, "UInt64 ", xUlong1, xUlong2, Math.Min(xUlong1, xUlong2));

        }
    }
}
