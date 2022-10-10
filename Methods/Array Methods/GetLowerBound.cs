using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class GetLowerBound
    {
        public static void GetLowerBoundMain()
        {
            Program.Title("GetLowerBound");
            Program.Space();
            GetLowerBoundInt();
            Program.Space();
            GetLowerBoundWithDimension();
            Program.Space();
            LowerAndUpperBound();
        }

        private static void GetLowerBoundInt()
        {
            int[] value = { 1, 2, 3, 4, 5, 6, 7 };
            int myvalue = value.GetLowerBound(0);
            Console.WriteLine("Index: {0}", myvalue);
        }

        private static void GetLowerBoundWithDimension()
        {
            char[,] value = { { 'a', 'b' }, { 'c', 'd' },
                           { 'e', 'f' }, { 'g', 'h' },
                                       { 'i', 'j' } };
            int myvalue = value.GetLowerBound(0);
            Console.WriteLine("Dimension: {0}", value.Rank);
            Console.WriteLine("Index: {0}", myvalue);
        }

        private static void LowerAndUpperBound()
        {
            int[] integers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int upper = integers.GetUpperBound(0);
            int lower = integers.GetLowerBound(0);
            Console.WriteLine($"Elements from index {lower} to {upper}:");
            for (int ctr = lower; ctr <= upper; ctr++)
                Console.Write($"{(ctr == lower ? "   " : "")}{integers[ctr]}" +
                              $"{(ctr < upper ? ", " : Environment.NewLine)}");

            Console.WriteLine();

            int[,] integers2d = { {2, 4}, {3, 9}, {4, 16}, {5, 25},
                           {6, 36}, {7, 49}, {8, 64}, {9, 81} };
            int rank = integers2d.Rank;
            Console.WriteLine($"Number of dimensions: {rank}");
            for (int ctr = 0; ctr < rank; ctr++)
                Console.WriteLine($"   Dimension {ctr}: " +
                                  $"from {integers2d.GetLowerBound(ctr)} to {integers2d.GetUpperBound(ctr)}");

            Console.WriteLine("   Values of array elements:");
            for (int outer = integers2d.GetLowerBound(0); outer <= integers2d.GetUpperBound(0);
                 outer++)
                for (int inner = integers2d.GetLowerBound(1); inner <= integers2d.GetUpperBound(1);
                     inner++)
                    Console.WriteLine($"      {'\u007b'}{outer}, {inner}{'\u007d'} = " +
                                      $"{integers2d.GetValue(outer, inner)}");
        }
    }
}
