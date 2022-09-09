using System;
using System.Drawing;

namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class ConvertAll
    {
        public static void ConvertAllMain()
        {
            Program.Title("ConvertAll");
            PointF[] apf = {
            new PointF(27.8F, 32.62F),
            new PointF(32.6F, 43.2F),
            new PointF(46.1F, 72.71F),
            new PointF(58.932F, 73.147F),
            new PointF(99.3F, 147.273F),
            new PointF(7.5F, 1412.2F) };

            Console.WriteLine();
            foreach (PointF p in apf)
            {
                Console.WriteLine(p);
            }

            Point[] ap = Array.ConvertAll(apf, new Converter<PointF, Point>(PointFToPoint));

            Console.WriteLine();
            foreach (Point p in ap)
            {
                Console.WriteLine(p);
            }

            Program.Title("ConvertAll String to Int");
            ConvertAllStringToInt();
            Program.Title("ConvertAll Int to String");
            ConvertAllIntToString();
        }

        public static Point PointFToPoint(PointF pf)
        {
            return new Point(((int)pf.X), ((int)pf.Y));
        }

        private static void ConvertAllStringToInt()
        {
            string[] strArray = new string[7] { "1", "2", "5", "6", "7", "10", "12" };
            Console.WriteLine("Strings:");
            foreach (string i in strArray)
            {
                Console.WriteLine(i);
            }
            var intArray = Array.ConvertAll(strArray, int.Parse);
            Console.WriteLine("Ints:");
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            Program.Space();
        }

        private static void ConvertAllIntToString()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Ints:");
            string[] result = Array.ConvertAll(numbers, x => x.ToString());
            Console.WriteLine(String.Join(", ", numbers));
            Console.WriteLine("Strings:");
            Console.WriteLine(String.Join(", ", result));
            Program.Space();
        }
    }
}
