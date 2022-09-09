using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Empty
    {
        public static void EmptyMain()
        {
            Program.Title("Empty");
            int[] arr = new int[] { 3, 9, 23, 50, 7, 88, 45, 76 };
            Console.WriteLine("Array (Old):");
            Program.PrintIntArrayValues(arr);

            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("Array (After using Clear):");
            Program.PrintIntArrayValues(arr);
        }
    }
}
