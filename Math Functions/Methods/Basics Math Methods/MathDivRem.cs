using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathDivRem
    {
        public static void MethodMathDivRem()
        {
            Program.Space();
            Console.WriteLine("--- DivRem ---");
            Console.WriteLine("Calculates the quotient of two numbers and also returns the remainder in an output parameter.");
            Program.Space();

            int quot = Math.DivRem(100, 50, out int remainder);

            Console.WriteLine("When 100 is divided by 50 it gives:");
            Console.WriteLine("Quotient = " + quot);
            Console.WriteLine("Remainder = " + remainder);

            DivRemResult(100, 20);
            DivRemResult(10, 3);
            DivRemResult(10, 2);
            DivRemResult(10, 4);
            DivRemResult(25, 5);
        }

        private static void DivRemResult(int a, int b)
        {
            int result, quot;
            quot = Math.DivRem(a, b, out result);
            Console.WriteLine($"Division of ({a}, {b}) : Reminder = {result}, Quotient = {quot}");
        }
    }
}
