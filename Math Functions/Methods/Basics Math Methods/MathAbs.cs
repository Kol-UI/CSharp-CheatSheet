using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathAbs
    {
        public static void MethodMathAbs()
        {
            Program.Space();
            Console.WriteLine("--- Abs ---");
            Console.WriteLine("Returns the absolute (positive) value of the given number");
            Program.Space();
            AbsDecimal();
            Program.Space();
            AbsDouble();
            Program.Space();
            AbsInt16();
            Program.Space();
            AbsInt32();
            Program.Space();
            AbsInt64();
            Program.Space();
            AbsSByte();
            Program.Space();
        }

        private static void AbsDecimal()
        {
            Console.WriteLine("--- Abs with Decimal ---");
            decimal[] decimals = { Decimal.MaxValue, 12.45M, 0M, -19.69M, Decimal.MinValue };
            foreach (decimal value in decimals)
            {
                Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
            }
        }

        private static void AbsDouble()
        {
            Console.WriteLine("--- Abs with Double ---");
            double[] doubles = { Double.MaxValue, 16.354e-17, 15.098123, 0, -19.069713, -15.058e18, Double.MinValue };
            foreach (double value in doubles)
            {
                Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
            }
        }

        private static void AbsInt16()
        {
            Console.WriteLine("--- Abs with Int (16) ---");
            short[] values = { Int16.MaxValue, 10328, 0, -1476, Int16.MinValue };
            foreach (short value in values)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.", value);
                }
            }
        }

        private static void AbsInt32()
        {
            Console.WriteLine("--- Abs with Int (32) ---");
            int[] values = { Int32.MaxValue, 16921, 0, -804128, Int32.MinValue };
            foreach (int value in values)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.", value);
                }
            }
        }

        private static void AbsInt64()
        {
            Console.WriteLine("--- Abs with Int (64) ---");
            long[] values = { Int64.MaxValue, 109013, 0, -6871982, Int64.MinValue };
            foreach (long value in values)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.", value);
                }
            }
        }

        private static void AbsSByte()
        {
            Console.WriteLine("--- Abs with SByte ---");
            sbyte[] values = { SByte.MaxValue, 98, 0, -32, SByte.MinValue };
            foreach (sbyte value in values)
            {
                try
                {
                    Console.WriteLine($"Abs({value}) = {Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate the absolute value of {0}.",value);
                }
            }
        }
    }
}
