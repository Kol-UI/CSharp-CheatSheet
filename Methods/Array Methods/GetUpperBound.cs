using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class GetUpperBound
    {
        public static void GetUpperBoundMain()
        {
            Program.Title("GetUpperBound");
            Program.Space();
            GetUpperBoundInt();
            Program.Space();
            GetUpperBoundWithDimension();
        }

        private static void GetUpperBoundInt()
        {
            int[] value = { 1, 2, 3, 4, 5, 6, 7 };
            int myvalue = value.GetUpperBound(0);
            Console.WriteLine("Index: {0}", myvalue);
        }

        private static void GetUpperBoundWithDimension()
        {
            char[,] value = { { 'a', 'b' }, { 'c', 'd' },
                           { 'e', 'f' }, { 'g', 'h' },
                                       { 'i', 'j' } };
            int myvalue = value.GetUpperBound(0);
            Console.WriteLine("Dimension: {0}", value.Rank);
            Console.WriteLine("Index: {0}", myvalue);
        }
    }
}
