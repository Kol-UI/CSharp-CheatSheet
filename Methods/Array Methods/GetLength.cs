using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class GetLength
    {
        public static void GetLengthMain()
        {
            Program.Title("GetLength");

            Array MyArray1 = Array.CreateInstance(typeof(int), 5);
            Array MyArray2 = Array.CreateInstance(typeof(int), 5, 3, 2);
            Array MyArray3 = Array.CreateInstance(typeof(int), 8, 6, 4, 2, 31);
            Array MyArray4 = Array.CreateInstance(typeof(int), 75, 53, 22);
            Array MyArray5 = Array.CreateInstance(typeof(int), 1, 1, 3);
            Array MyArray6 = Array.CreateInstance(typeof(int), 9, 10, 6);

            Array BossArray = Array.CreateInstance(typeof(Array), 6);
            BossArray.SetValue(MyArray1, 0);
            BossArray.SetValue(MyArray2, 1);
            BossArray.SetValue(MyArray3, 2);
            BossArray.SetValue(MyArray4, 3);
            BossArray.SetValue(MyArray5, 4);
            BossArray.SetValue(MyArray6, 5);

            int i = 0, j, rank;
            foreach (Array anArray in BossArray)
            {
                rank = anArray.Rank;
                if (rank > 1)
                {
                    Console.WriteLine("Lengths of {0:d} dimension array[{1:d}]", rank, i);
                    for (j = 0; j < rank; j++)
                    {
                        Console.WriteLine("    Length of dimension({0:d}) = {1:d}", j, anArray.GetLength(j));
                    }
                }
                else
                {
                    Console.WriteLine("Lengths of single dimension array[{0:d}]", i);
                }
                Console.WriteLine("    Total length of the array = {0:d}", anArray.Length);
                Console.WriteLine();
                i++;
            }
        }
    }
}
