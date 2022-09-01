using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.PowerLogarithmicMethods
{
    public class Sqrt
    {
        public static void SqrtMain()
        {
            Console.WriteLine("--- Sqrt ---");
            Console.WriteLine("Returns the square root of the given number.\n");


            double[] numbers = {-500, -10, -1, 0, 0.09, .105, .5, .798, 1, 4, 6.9, 10, 25, 50, 64, 75, 81,
                          100, 250, 500, 750, 1000, Double.MaxValue, Double.NegativeInfinity, Double.PositiveInfinity, Double.NaN};

            foreach (double number in numbers)
            {
                Console.WriteLine("Square root of {0} is {1}.", number, Math.Sqrt(number));
            }

            Program.Space();
            Console.WriteLine("--- Sqrt Area ---");
            Tuple<string, double>[] areas = { Tuple.Create("Sitka, Alaska", 2870.3),
                Tuple.Create("New York City", 302.6),
                Tuple.Create("Los Angeles", 468.7),
                Tuple.Create("Detroit", 138.8),
                Tuple.Create("Chicago", 227.1),
                Tuple.Create("San Diego", 325.2),
                Tuple.Create("Paris", 40.7),
                Tuple.Create("London", 600.7), };

            Console.WriteLine("{0,-18} {1,14:N1} {2,30}\n", "City", "Area (mi.)", "Equivalent to a square with:");

            foreach (var area in areas)
            {
                Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side", area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));
            }
        }
    }
}
