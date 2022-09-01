using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.HyperbolicMathMethods
{
    public class Tanh
    {
        public static void MainTanh()
        {
            Console.WriteLine("--- Tanh ---");
            Console.WriteLine("Returns the hyperbolic tangent of a value.\n");


            double[] numbers = {-500, -10, -1, 0, 0.09, .105, .5, .798, 1, 4, 6.9, 8, 10, 25, 27.8967, 46, 50, 64, 75, 81,
                          100, 125.2534, 250, 500, 750, 1000, double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN};

            foreach (double number in numbers)
            {
                Console.WriteLine("Hyperbolic tangent of {0} is {1}.", number, Math.Tanh(number));
            }

            Console.WriteLine("\nEvaluate these hyperbolic identities " + "with selected values for X:");
            Console.WriteLine("   tanh(X) == sinh(X) / cosh(X)");
            Console.WriteLine("   tanh(2 * X) == 2 * tanh(X) / (1 + tanh^2(X))");

            UseTanh(0.1);
            UseTanh(1.2);
            UseTanh(4.9);

            Console.WriteLine("\nEvaluate [tanh(X + Y) == (tanh(X) + tanh(Y)) " +"/ (1 + tanh(X) * tanh(Y))]" +"\nwith selected values for X and Y:");

            UseTwoArgs(0.1, 1.2);
            UseTwoArgs(1.2, 4.9);
        }

        private static void UseTanh(double arg)
        {
            double tanhArg = Math.Tanh(arg);

            Console.WriteLine("\n                       Math.Tanh({0}) == {1:E16}\n" +"      Math.Sinh({0}) / Math.Cosh({0}) == {2:E16}",arg, tanhArg, (Math.Sinh(arg) / Math.Cosh(arg)));

            Console.WriteLine("                   2 * Math.Tanh({0}) /",arg, 2.0 * tanhArg);
            Console.WriteLine("             (1 + (Math.Tanh({0}))^2) == {1:E16}",arg, 2.0 * tanhArg / (1.0 + tanhArg * tanhArg));
            Console.WriteLine("                       Math.Tanh({0}) == {1:E16}",
                2.0 * arg, Math.Tanh(2.0 * arg));
        }


        private static void UseTwoArgs(double argX, double argY)
        {
            Console.WriteLine("\n    (Math.Tanh({0}) + Math.Tanh({1})) /\n" +"(1 + Math.Tanh({0}) * Math.Tanh({1})) == {2:E16}",argX, argY, (Math.Tanh(argX) + Math.Tanh(argY)) /(1.0 + Math.Tanh(argX) * Math.Tanh(argY)));
            Console.WriteLine("                       Math.Tanh({0}) == {1:E16}",argX + argY, Math.Tanh(argX + argY));
        }
    }
}
