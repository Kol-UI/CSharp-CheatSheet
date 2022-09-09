using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Fill
    {
        public static void FillMain()
        {
            Program.Title("Fill");
            int element = 1;
            int count = 10;

            int[] array = new int[count];
            Array.Fill(array, element);

            Console.WriteLine(string.Join(",", array));
        }
    }
}
