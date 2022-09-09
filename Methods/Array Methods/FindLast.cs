using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class FindLast
    {
        public static void FindLastMain()
        {
            Program.Title("FindLast");
            String[] myArr = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            Console.WriteLine("Initial Array:");
            Program.PrintIndexAndValues(myArr);
            string value1 = Array.FindLast(myArr, element => element.StartsWith("S", StringComparison.Ordinal));
            string value2 = Array.FindLast(myArr, element => element.StartsWith("T", StringComparison.Ordinal));
            Console.WriteLine("Last occurrence: ");
            Console.Write("S: {0} \t T: {1}", value1, value2);
        }
    }
}
