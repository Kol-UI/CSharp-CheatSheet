using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathClamp
    {
        public static void MethodMathClamp()
        {
            Program.Space();
            Console.WriteLine("--- Clamp ---");
            Console.WriteLine("Returns the value clamped to the inclusive range of min and max.");
            Console.WriteLine("If min ≤ value ≤ max, the method returns value.");
            Console.WriteLine("If value < min, the method returns min.");
            Console.WriteLine("If value > max, the method returns max.");
            Program.Space();
            Console.WriteLine("Math.Clamp(25, 50, 100): " + Math.Clamp(25, 50, 100));
            Console.WriteLine("Math.Clamp(10, 50, 100): " + Math.Clamp(10, 50, 100));
            Console.WriteLine("Math.Clamp(108.6, 50, 100): " + Math.Clamp(108.6, 50, 100));
            Console.WriteLine("Math.Clamp(7.5, 50, 100): " + Math.Clamp(7.5, 50, 100));
            Console.WriteLine("Math.Clamp(8.4, 2.5, 10.5): " + Math.Clamp(8.4, 2.5, 10.5));
            Console.WriteLine("Math.Clamp(25, 0, 50): " + Math.Clamp(25, 0, 50));
            Console.WriteLine("Math.Clamp(25, -25, 0): " + Math.Clamp(25, -25, 0));
            Console.WriteLine("Math.Clamp(-10, -25, 0): " + Math.Clamp(-10, -25, 0));
            Console.WriteLine("Math.Clamp(-30, -25, 0): " + Math.Clamp(-30, -25, 0));
            Console.WriteLine("Math.Clamp(7, -25, 0): " + Math.Clamp(7, -25, 0));
            Console.WriteLine("Math.Clamp(5, 2, 8): " + Math.Clamp(5, 2, 8));
            Console.WriteLine("Math.Clamp(1, 2, 8): " + Math.Clamp(1, 2, 8));
            Console.WriteLine("Math.Clamp(9, 2, 8): " + Math.Clamp(9, 2, 8));
            Console.WriteLine("Math.Clamp(5.12, 2.2, 8.1): " + Math.Clamp(5.12, 2.2, 8.1));
            Console.WriteLine("Math.Clamp(1.4, 2.2, 8.1): " + Math.Clamp(1.4, 2.2, 8.1));
            Console.WriteLine("Math.Clamp(9, 2.2, 8.4): " + Math.Clamp(9, 2.2, 8.4));
            Console.WriteLine("Math.Clamp(5.7, 2.1, 8.2): " + Math.Clamp(5.7, 2.1, 8.2));
            Console.WriteLine("Math.Clamp(1.4, 2.1, 8.2): " + Math.Clamp(1.4, 2.1, 8.2));
            Console.WriteLine("Math.Clamp(9.3, 2.1, 8.2): " + Math.Clamp(9.3, 2.1, 8.2));
        }
    }
}
