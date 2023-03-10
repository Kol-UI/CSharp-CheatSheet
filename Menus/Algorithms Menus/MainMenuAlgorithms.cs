using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet.Menus.AlgorithmsMenus
{
	public class AlgorithmsMenu
	{
		public static void MainMenuAlgorithms()
		{
            Program.Space();
            Console.WriteLine("Which Algorithm ?\n1) BubbleSort\n2) InsertionSort\n3) InsertionSortNew\n4) SelectionSort\n5) Shell Sort\n6) Counting Sort\n7) Algorithms Comparison");
            var AlgoInput = Console.ReadLine();
            int valueAlgoInput = int.Parse(AlgoInput);

            int[] AlgorithmsArray = { 3, 10, 2, 1, 5, 4, 8, 3, 9, 32, 7, 4, 5, 3, 1, 5, 2, 9, 7 };
            switch (valueAlgoInput)
            {
                case 1: // BubbleSort
                    Console.WriteLine("The Array for BubbleSort :");
                    Program.PrintArrayIntOneLine(AlgorithmsArray);
                    Algorithms.BubbleSortAlgorithm.BubbleSort(AlgorithmsArray);
                    break;
                case 2: // InsertionSort
                    Console.WriteLine("The Array for InsertionSort :");
                    Program.PrintArrayIntOneLine(AlgorithmsArray);
                    Algorithms.InsertionSortAlgorithm.InsertionSort(AlgorithmsArray);
                    break;
                case 3: // InsertionSortNew
                    Console.WriteLine("The Array for InsertionSortNew :");
                    Program.PrintArrayIntOneLine(AlgorithmsArray);
                    List<int> AlgorithmsList = AlgorithmsArray.ToList();
                    Algorithms.InsertionSortAlgorithm.InsertionSortNew(AlgorithmsList);
                    break;
                case 4: // SelectionSort
                    Console.WriteLine("The Array for SelectionSort :");
                    Program.PrintArrayIntOneLine(AlgorithmsArray);
                    Algorithms.SelectionSortAlgorithm.SelectionSort(AlgorithmsArray);
                    break;
                case 5: // ShellSort
                    Console.WriteLine("The Array for ShellSort :");
                    Program.PrintArrayIntOneLine(AlgorithmsArray);
                    Algorithms.ShellSortAlgorithm.ShellSort(AlgorithmsArray);
                    break;
                case 6: // CountingSort
                    Console.WriteLine("The Array for CountingSort :");
                    Program.PrintArrayIntOneLine(AlgorithmsArray);
                    Algorithms.CountingSortAlgorithm.CountingSort(AlgorithmsArray);
                    break;
                case 7: // Algorithms Comparison
                    AlgorithmsComparison();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void AlgorithmsComparison()
        {
            Program.Space();
            Console.WriteLine("Which Size Comparison ?\n1) Very Small\n2) Small\n3) Medium\n4) Large");
            var AlgoComparisonInput = Console.ReadLine();
            int valueAlgoComparisonInput = int.Parse(AlgoComparisonInput);

            switch (valueAlgoComparisonInput)
            {
                case 1: // Comparison Very Small
                    int[] TestVerySmallArray = Program.GenerateRandomNumber(19);
                    Program.Title("Comparison of all Algorithms with Very Small array (20 random)");
                    int BubbleSortVerySmallResult = Algorithms.BubbleSortAlgorithm.BubbleSortComparison(TestVerySmallArray);
                    int InsertionSortVerySmallResult = Algorithms.InsertionSortAlgorithm.InsertionSortComparison(TestVerySmallArray);
                    int InsertionSortNewVerySmallResult = Algorithms.InsertionSortAlgorithm.InsertionSortNewComparison(TestVerySmallArray);
                    int SelectionSortVerySmallResult = Algorithms.SelectionSortAlgorithm.SelectionSortComparison(TestVerySmallArray);
                    int ShellSortVerySmallResult = Algorithms.ShellSortAlgorithm.ShellSortComparison(TestVerySmallArray);
                    int CountingSortVerySmallResult = Algorithms.CountingSortAlgorithm.CountingSortComparison(TestVerySmallArray);
                    ComparisonResults(BubbleSortVerySmallResult, InsertionSortVerySmallResult, InsertionSortNewVerySmallResult, SelectionSortVerySmallResult, ShellSortVerySmallResult, CountingSortVerySmallResult);
                    break;
                case 2: // Comparison Small
                    int[] TestSmallArray = Program.GenerateRandomNumber(199);
                    Program.Title("Comparison of all Algorithms with Small array (200 random)");
                    int BubbleSortSmallResult = Algorithms.BubbleSortAlgorithm.BubbleSortComparison(TestSmallArray);
                    int InsertionSortSmallResult = Algorithms.InsertionSortAlgorithm.InsertionSortComparison(TestSmallArray);
                    int InsertionSortNewSmallResult = Algorithms.InsertionSortAlgorithm.InsertionSortNewComparison(TestSmallArray);
                    int SelectionSortSmallResult = Algorithms.SelectionSortAlgorithm.SelectionSortComparison(TestSmallArray);
                    int ShellSortSmallResult = Algorithms.ShellSortAlgorithm.ShellSortComparison(TestSmallArray);
                    int CountingSortSmallResult = Algorithms.CountingSortAlgorithm.CountingSortComparison(TestSmallArray);
                    ComparisonResults(BubbleSortSmallResult, InsertionSortSmallResult, InsertionSortNewSmallResult, SelectionSortSmallResult, ShellSortSmallResult, CountingSortSmallResult);
                    break;
                case 3: // Comparison Medium
                    int[] TestMediumArray = Program.GenerateRandomNumber(1999);
                    Program.Title("Comparison of all Algorithms with Medium array (2000 random)");
                    int BubbleSortMediumResult = Algorithms.BubbleSortAlgorithm.BubbleSortComparison(TestMediumArray);
                    int InsertionSortMediumResult = Algorithms.InsertionSortAlgorithm.InsertionSortComparison(TestMediumArray);
                    int InsertionSortNewMediumResult = Algorithms.InsertionSortAlgorithm.InsertionSortNewComparison(TestMediumArray);
                    int SelectionSortMediumResult = Algorithms.SelectionSortAlgorithm.SelectionSortComparison(TestMediumArray);
                    int ShellSortMediumResult = Algorithms.ShellSortAlgorithm.ShellSortComparison(TestMediumArray);
                    int CountingSortMediumResult = Algorithms.CountingSortAlgorithm.CountingSortComparison(TestMediumArray);
                    ComparisonResults(BubbleSortMediumResult, InsertionSortMediumResult, InsertionSortNewMediumResult, SelectionSortMediumResult, ShellSortMediumResult, CountingSortMediumResult);
                    break;
                case 4: // Comparison Large
                    int[] TestLargeArray = Program.GenerateRandomNumber(19999);
                    Program.Title("Comparison of all Algorithms with Large array (20000 random)");
                    int BubbleSortLargeResult = Algorithms.BubbleSortAlgorithm.BubbleSortComparison(TestLargeArray);
                    int InsertionSortLargeResult = Algorithms.InsertionSortAlgorithm.InsertionSortComparison(TestLargeArray);
                    int InsertionSortNewLargeResult = Algorithms.InsertionSortAlgorithm.InsertionSortNewComparison(TestLargeArray);
                    int SelectionSortLargeResult = Algorithms.SelectionSortAlgorithm.SelectionSortComparison(TestLargeArray);
                    int ShellSortLargeResult = Algorithms.ShellSortAlgorithm.ShellSortComparison(TestLargeArray);
                    int CountingSortLargeResult = Algorithms.CountingSortAlgorithm.CountingSortComparison(TestLargeArray);
                    ComparisonResults(BubbleSortLargeResult, InsertionSortLargeResult, InsertionSortNewLargeResult, SelectionSortLargeResult, ShellSortLargeResult, CountingSortLargeResult);
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void ComparisonResults(int BubbleSortResult, int InsertionSortResult, int InsertionSortNewResult, int SelectionSortResult, int ShellSortResult, int CountingSortResult)
        {
            Console.WriteLine("- Result BubbleSort : {0}", BubbleSortResult);
            Console.WriteLine("- Result InsertionSort : {0}", InsertionSortResult);
            Console.WriteLine("- Result InsertionSortNew : {0}", InsertionSortNewResult);
            Console.WriteLine("- Result SelectionSort : {0}", SelectionSortResult);
            Console.WriteLine("- Result ShellSortResult : {0}", ShellSortResult);
            Console.WriteLine("- Result CountingSortResult : {0}", CountingSortResult);
        }
	}
}