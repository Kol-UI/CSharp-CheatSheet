using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class BinarySearch
    {
        public static void BinarySearchMethod()
        {
            Program.Title("BinarySearch");
            int[] arrayBinarySearch = new int[15] { 9, 2, 3, 1, 5, 6, 4, 8, 10, 7, 12, 13, 16, 20, 25 };
            Array.Sort(arrayBinarySearch);
            Console.WriteLine("Elements sorted:");
            Display(arrayBinarySearch);
            Program.Space();
            for (int i = 0; i < arrayBinarySearch.Length + 1; i++)
            {
                Result(arrayBinarySearch, i);
            }

            Program.Title("BinarySearch Next");
            for (int i = 0; i < arrayBinarySearch.Length + 1; i++)
            {
                ResultNext(arrayBinarySearch, i);
            }
        }


        private static void Result(int[] arr, object k)
        {
            int res = Array.BinarySearch(arr, k);
            if (res < 0)
            {
                Console.WriteLine("The element to search for " + "({0}) is not found.", k);
            }
            else
            {
                Console.WriteLine("The element to search for " + "({0}) is at index {1}.", k, res);
            }
        }

        private static void ResultNext(int[] arr, object k)
        {
            int res = Array.BinarySearch(arr, k, StringComparer.CurrentCulture);
            if (res < 0)
            {
                Console.WriteLine("The element to search for " + "({0}) is not found. The next larger object is at index {1}.", k, ~res);
            }
            else
            {
                Console.WriteLine("The element to search for " + "({0}) is at index {1}.", k, res);
            }
        }


        private static void Display(int[] arr1)
        {
            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
