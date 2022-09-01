using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.TrigonometricMathMethods
{
    public class TanMethod
    {
        public static void TanMethodMain()
        {
            Console.WriteLine("--- Tan ---");
            Console.WriteLine("Returns the trigonometric tangent of an angle\n");

            double pi = Math.PI;
            Console.WriteLine("Math.Tan(pi/6) = " + Math.Tan(pi / 6));
            Console.WriteLine("Math.Tan(pi/4) = " + Math.Tan(pi / 4));
            Console.WriteLine("Math.Tan(pi/3) = " + Math.Tan(pi / 3));
            Console.WriteLine("Math.Tan(Double.NaN) = " + Math.Tan(Double.NaN));
            Console.WriteLine("Math.Tan(Double.NegativeInfinity) = " + Math.Tan(Double.NegativeInfinity));
            Console.WriteLine("Math.Tan(Double.PositiveInfinity) = " + Math.Tan(Double.PositiveInfinity));

            Program.Space();
            double a = 12;
            double b = a * Math.PI / 180;

            Console.WriteLine(Math.Tan(b));
            a = 63;
            b = a * Math.PI / 180;
            Console.WriteLine(Math.Tan(b));
            a = 187;
            b = a * Math.PI / 180;
            Console.WriteLine(Math.Tan(b));
            a = 45;
            b = a * Math.PI / 180;
            Console.WriteLine(Math.Tan(b));
        }

        public static void ATanMethodMain()
        {
            Console.WriteLine("--- Atan ---");
            Console.WriteLine("Returns the arc tangent of a value\n");

            double[] numbers = { -1, 0, 0.09, .105, 0.3584, .5, .798, 1, 4, Double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN };

            foreach (double number in numbers)
            {
                Console.WriteLine("Arc tangent of {0} is {1}.", number, Math.Atan(number));
            }
        }

        public static void ATan2MethodMain()
        {
            Console.WriteLine("--- Atan2 ---");
            Console.WriteLine("Returns the arc tangent of an angle\n");

            double x = 1.0;
            double y = 2.0;
            double angle;
            double radians;
            double result;

            angle = 30;
            radians = angle * (Math.PI / 180);
            result = Math.Tan(radians);
            Console.WriteLine("The tangent of 30 degrees is {0}.", result);

            radians = Math.Atan(result);
            angle = radians * (180 / Math.PI);
            Console.WriteLine("The previous tangent is equivalent to {0} degrees.", angle);

            String line1 = "{0}The arctangent of the angle formed by the x-axis and ";
            String line2 = "a vector to point ({0},{1}) is {2}, ";
            String line3 = "which is equivalent to {0} degrees.";

            radians = Math.Atan2(y, x);
            angle = radians * (180 / Math.PI);

            Console.WriteLine(line1, Environment.NewLine);
            Console.WriteLine(line2, x, y, radians);
            Console.WriteLine(line3, angle);
        }
    }
}
