using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class ForEach
    {
        public static void ForEachMain()
        {
            Program.Title("ForEach");
            int[] intArray = new int[] { 2, 3, 4, 5, 6 };
            Action<int> action = new Action<int>(ShowSquares);

            Array.ForEach(intArray, action);
        }

        private static void ShowSquares(int val)
        {
            Console.WriteLine("{0:d} squared = {1:d}", val, val * val);
        }
    }
}
