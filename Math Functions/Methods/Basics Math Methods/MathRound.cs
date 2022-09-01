using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathRound
    {
        public static void MethodMathRound()
        {
            Program.Space();
            Console.WriteLine("--- Round ---");
            Console.WriteLine("Rounds a value to the nearest integer or to the specified number of fractional digits.");
            Program.Space(); 

            Console.WriteLine("Decimal:");
            RoundDecimal(10.63M);
            RoundDecimal(10.2563M);
            RoundDecimal(10.5M);
            Program.Space();

            Console.WriteLine("Double:");
            RoundDouble();

            Program.Space();
            Console.WriteLine("--- Midpoint Rounding ---");
            Console.WriteLine("AwayFromZero:");
            RoundAwayFromZero(10.2M, 0);
            Console.WriteLine("ToEven:");
            RoundToEven(10.8M, 0);
            Console.WriteLine("ToNegativeInfinity:");
            RoundToNegativeInfinity(10.8M, 0);
            Console.WriteLine("ToPositiveInfinity:");
            RoundToPositiveInfinity(10.2M, 0);
            Console.WriteLine("ToZero:");
            RoundToZero(10.8M, 0);

            Program.Space();
            MidpointRoundingMethod();
        }

        private static void RoundDecimal(decimal d)
        {
            decimal result;
            result = Math.Round(d);
            Console.WriteLine($"Round({d}) = {result}");
        }

        private static void RoundAwayFromZero(decimal d, int decimals)
        {
            decimal result;
            result = Math.Round(d, decimals, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Round({d}, {decimals}, MidpointRounding.AwayFromZero)       = {result}");
        }

        private static void RoundToEven(decimal d, int decimals)
        {
            decimal result;
            result = Math.Round(d, decimals, MidpointRounding.ToEven);
            Console.WriteLine($"Round({d}, {decimals}, MidpointRounding.ToEven)             = {result}");
        }

        private static void RoundToNegativeInfinity(decimal d, int decimals)
        {
            decimal result;
            result = Math.Round(d, decimals, MidpointRounding.ToNegativeInfinity);
            Console.WriteLine($"Round({d}, {decimals}, MidpointRounding.ToNegativeInfinity) = {result}");
        }

        private static void RoundToPositiveInfinity(decimal d, int decimals)
        {
            decimal result;
            result = Math.Round(d, decimals, MidpointRounding.ToPositiveInfinity);
            Console.WriteLine($"Round({d}, {decimals}, MidpointRounding.ToPositiveInfinity) = {result}");
        }

        private static void RoundToZero(decimal d, int decimals)
        {
            decimal result;
            result = Math.Round(d, decimals, MidpointRounding.ToZero);
            Console.WriteLine($"Round({d}, {decimals}, MidpointRounding.ToZero)             = {result}");
        }

        private static void RoundDouble()
        {
            double[] values = { 12.49, 12.50, 12.51, 13.49, 13.50, 13.51 };
            Console.WriteLine("{0,-7} {1,-7} {2,-15}", "Value","Default", "1 fraction digit");
            foreach (var value in values)
            {
                Console.WriteLine("{0,-7:R} {1,-7} {2,-15}",value, Math.Round(value), Math.Round(value, 1));
            }
        }

        private static void MidpointRoundingMethod()
        {
            double[] values = { 12.49, 12.50, 12.51, 13.49, 13.50, 13.51 };
            Console.WriteLine( "{0,-7} {1,-7} {2,-7} {3,-7} {4,-20}", "Value", "Default", "ToEven", "ToZero", "1 fraction digit and ToZero");
            foreach (var value in values)
            {
                Console.WriteLine("{0,-7:R} {1,-7} {2,-7} {3,-7} {4,-20}",value, Math.Round(value), Math.Round(value, MidpointRounding.ToEven), Math.Round(value, MidpointRounding.ToZero), Math.Round(value, 1, MidpointRounding.ToZero));
            }
        }

    }
}
