using System;
using System.Drawing;

namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Find
    {
        public static void FindMain()
        {
            Program.Title("Find");
            Example1();
            Program.Space();
            Example2();
        }

        private static void Example1()
        {
            Program.Title("Names Example");
            string[] names = { "Steve", "Bill", "Jack", "Bill Gates", "Arthur", "Ravi", "Pierre", "Salim", "Mohan", "Nikita", "Salman", "Manon", "Boski", "Jean" };
            Program.PrintArrayOneLine(names);
            var stringToFind = "Boski";
            var result1 = Array.Find(names, element => element == stringToFind);
            Console.WriteLine("Find using var comparison : {0}", result1);
            var result2 = Array.Find(names, element => element.StartsWith("B"));
            Console.WriteLine("Find using StartsWith : {0}", result2);
            var result3 = Array.Find(names, element => element.Length >= 5);
            Console.WriteLine("Find using Lenght : {0}", result3);
        }

        private static void Example2()
        {
            Program.Title("Points Example");
            Point[] points = { new Point(100, 200),
            new Point(150, 250), new Point(250, 375),
            new Point(275, 395), new Point(295, 450) };
            Point first = Array.Find(points, p => p.X * p.Y > 100000);
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
        }
    }
}
