using System;
using CSharp_CheatSheet.CBasics;

namespace CSharp_CheatSheet.Menus.BasicsMenus
{
    public class BasicsSearchSortMenu
    {
        public static void SearchSortMenu()
        {
            Program.Space();
            Console.WriteLine("Which Search & Sort ?\n1) Shell Sort Method\t2) Bogo Sort\t3) Bubble Sort\t4) Counting Sort" +
                "\n5) Heap Sort\t6) Insertion Sort\t 7) Merge Sort\t8) Permutation Sort" +
                "\n9) Quick Sort\t10) Radix Sort\t11) Selection Sort");
            var MatricesInput = Console.ReadLine();
            int valueMatricesInput = int.Parse(MatricesInput);
            switch (valueMatricesInput)
            {
                case 1:
                    SearchSortFunctions.ShellSortMethod();
                    break;
                case 2:
                    SearchSortFunctions.BogoSortMain();
                    break;
                case 3:
                    SearchSortFunctions.BubbleSortFunction();
                    break;
                case 4:
                    SearchSortFunctions.CountingSortMain();
                    break;
                case 5:
                    SearchSortFunctions.HeapSortMain();
                    break;
                case 6:
                    SearchSortFunctions.InsertionSortMain();
                    break;
                case 7:
                    SearchSortFunctions.MergeSortMain();
                    break;
                case 8:
                    SearchSortFunctions.PermutationSortMain();
                    break;
                case 9:
                    SearchSortFunctions.QuickSortMain();
                    break;
                case 10:
                    SearchSortFunctions.RadixSortMain();
                    break;
                case 11:
                    SearchSortFunctions.SelectionSortMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
