using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.BasicsMathMethods
{
    public class MathIEEERemainder
    {
        public static void MethodMathIEEERemainder()
        {
            Program.Space();
            Console.WriteLine("--- IEEERemainder ---");
            Console.WriteLine("Returns the remainder resulting from the division of specified arguments.");
            Program.Space();

            IEEERemainderExample(10, 4);
            IEEERemainderExample(30, 5);
            IEEERemainderExample(25, 3);
            IEEERemainderExample(7.9, 3);
            IEEERemainderExample(37.5, 4); 
            IEEERemainderExample(-10, 5);
            IEEERemainderExample(-17, 3);
            IEEERemainderExample(-25, 2);

            Console.WriteLine("Math.IEEERemainder(60.8, 18.1) = " + Math.IEEERemainder(60.8, 18.1));
            Console.WriteLine("Math.IEEERemainder(Double.NaN, 4) = " + Math.IEEERemainder(Double.NaN, 4));
            Console.WriteLine("Math.IEEERemainder(Double.NegativeInfinity, 4) = " + Math.IEEERemainder(Double.NegativeInfinity, 4));
            Console.WriteLine("Math.IEEERemainder(Double.PositiveInfinity, 4) = " + Math.IEEERemainder(Double.PositiveInfinity, 4));
            Console.WriteLine($"{"IEEERemainder",35} {"Remainder operator",20}");

            Program.Space();
            ShowRemainders(3, 2);
            ShowRemainders(4, 2);
            ShowRemainders(10, 3);
            ShowRemainders(11, 3);
            ShowRemainders(27, 4);
            ShowRemainders(28, 5);
            ShowRemainders(17.8, 4);
            ShowRemainders(17.8, 4.1);
            ShowRemainders(-16.3, 4.1);
            ShowRemainders(17.8, -4.1);
            ShowRemainders(-17.8, -4.1);
        }

        private static void ShowRemainders(double number1, double number2)
        {
            var formula = $"{number1} / {number2} = ";
            var ieeeRemainder = Math.IEEERemainder(number1, number2);
            var remainder = number1 % number2;
            Console.WriteLine($"{formula,-16} {ieeeRemainder,18} {remainder,20}");
        }

        private static void IEEERemainderExample(double x, double y)
        {
            double result;
            result = Math.IEEERemainder(x, y);
            Console.WriteLine($"IEEERemainder({x}, {y}) = {result}");
        }
    }
}
