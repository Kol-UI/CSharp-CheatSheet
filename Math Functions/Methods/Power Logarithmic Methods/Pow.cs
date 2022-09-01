using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.PowerLogarithmicMethods
{
    public class Pow
    {
        public static void PowMain()
        {
            Console.WriteLine("--- Pow ---");
            Console.WriteLine("Returns base raised to the power of exponent\n");

            int value = 2;
            int value2 = 3;
            for (int power = 0; power <= 32; power++)
            {
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");
            }

            Program.Space();
            for (int power = 0; power <= 32; power++)
            {
                Console.WriteLine($"{value2}^{power} = {(long)Math.Pow(value2, power):N0} (0x{(long)Math.Pow(value2, power):X})");
            }

            Program.Space();

            Console.WriteLine("Math.Pow(10, 2) = " + Math.Pow(10, 2));
            Console.WriteLine("Math.Pow(5.2, 3) = " + Math.Pow(5.2, 3));
            Console.WriteLine("Math.Pow(5.2, -3) = " + Math.Pow(5.2, -3));
            Console.WriteLine("Math.Pow(5, Double.NaN) = " + Math.Pow(5, Double.NaN));
            Console.WriteLine("Math.Pow(Double.NaN, 2) = " + Math.Pow(Double.NaN, 2));
            Console.WriteLine("Math.Pow(2, Double.PositiveInfinity) = " + Math.Pow(2, Double.PositiveInfinity));
            Console.WriteLine("Math.Pow(2, Double.NegativeInfinity) = " + Math.Pow(2, Double.NegativeInfinity));
        }
    }
}
