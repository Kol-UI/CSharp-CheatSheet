using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class ConstrainedCopy
    {
        public static void ConstrainedCopyMain()
        {
            Program.Title("ConstrainedCopy");
            String[] srcArr = { "Mario", "Luigi", "Wario", "Waluigi" };
            String[] destArr = new String[10];
            Console.WriteLine("Initial Array:");
            Program.PrintStringArrayValues(srcArr);
            Array.ConstrainedCopy(srcArr, 1, destArr, 0, 3);
            Console.WriteLine("Destination Array: ");
            Program.PrintStringArrayValues(destArr);
        }
    }
}
