using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Clear
    {
        public static void ClearMethod()
        {
            Program.Title("Clear");
            int[] myArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("Array Before Operation:");
            Program.PrintIntArrayValues(myArr);
            ClearingArray(myArr, 1, 2);
            ClearingArray(myArr, 4, 5);
            ClearMethodOverview();
        }

        private static void ClearingArray(int[] myArr, int a, int b)
        {
            Program.Space();
            Array.Clear(myArr, a, b);
            Console.WriteLine("Array After Operation:");
            Program.PrintIntArrayValues(myArr);
        }

        private static void ClearMethodOverview()
        {
            Program.Title("One Dimension Clear");
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < 9; i++)
            {
                Console.Write("{0} ", numbers1[i]);
            }
            Program.Space();
            Program.Space();
            Array.Clear(numbers1, 2, 5);

            for (int i = 0; i < 9; i++)
            {
                Console.Write("{0} ", numbers1[i]);
            }
            Program.Space();
            Program.Space();

            Program.Title("Two Dimensions Clear");
            int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", numbers2[i, j]);
                }
                Program.Space();
            }
            Program.Space();
            Program.Space();

            Array.Clear(numbers2, 2, 5);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", numbers2[i, j]);
                }
                Console.WriteLine();
            }

            Program.Title("Three Dimensions Clear");
            int[,,] numbers3 = {{{1, 2}, {3, 4}},
                             {{5, 6}, {7, 8}},
                             {{9, 10}, {11, 12}}};

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write("{0} ", numbers3[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Array.Clear(numbers3, 2, 5);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write("{0} ", numbers3[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
