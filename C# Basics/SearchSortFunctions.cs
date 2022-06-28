using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.CBasics
{
    public class SearchSortFunctions
    {
		// Shell Sort
        public static void ShellSortMethod()
        {
            int[] ShellSortArray = new int[] { 5, 7, -4, 3, 11, -2, 0, 24, 18, 7, 22, -7, -6, 5, 1, 67, -1, -6, 51, 6 };
            int Size;
            Program.Space();
            Console.WriteLine("--- Shell Sort Method ---");

            Size = ShellSortArray.Length;
            Console.WriteLine("Original Array Elements :");
            ShowElements(ShellSortArray);
            ShellSortFunction(ShellSortArray, Size);
            Console.WriteLine("Sorted Array Elements :");
            ShowElements(ShellSortArray);
        }


        private static void ShellSortFunction(int[] ShellSortArray, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = ShellSortArray[i];
                    while ((j >= inc) && (ShellSortArray[j - inc] > temp))
                    {
                        ShellSortArray[j] = ShellSortArray[j - inc];
                        j -= inc;
                    }
                    ShellSortArray[j] = temp;
                }
                if (inc / 2 != 0)
                {
                    inc /= 2;
                }
                else
                {
                    inc = inc == 1 ? 0 : 1;
                }
            }
        }


        private static void ShowElements(int[] ShellSortArray)
        {
            foreach (var element in ShellSortArray)
            {
                Console.Write(element + " ");
            }
            Program.Space();
        }


		// Bogo Sort
		public static void BogoSortMain()
		{
			// List<int> list = new List<int>() { 2, 1, 3, 0, 1, 8, 5, 7, 4, 6, 9 };
            List<int> list = new List<int>() { 2, 1, 3, 0, 1, };
            Console.WriteLine("Sorting...");
            BogoSortFunction(list, true, 5);
		}


		private static void BogoSortFunction(List<int> list, bool announce, int delay)
		{
			int iteration = 0;
			while (!IsSorted(list))
			{
				if (announce)
                {
                    PrintBogoIteration(list, iteration);
				}
				else if (delay != 0)
				{
                    System.Threading.Thread.Sleep(Math.Abs(delay));
				}
                else
                {
                    Console.WriteLine("Bogo Sort Error");
                }
				list = Remap(list);
				iteration++;
			}

			PrintBogoIteration(list, iteration);
			Program.Space();
			Console.WriteLine("Bogo Sort completed after {0} iterations.", iteration);
		}


		private static void PrintBogoIteration(List<int> list, int iteration)
		{
			Console.Write("Bogo Sort Iteration {0}: ", iteration);
			for (int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i]);
				if (i < list.Count)
				{
					Console.Write(" ");
				}
			}
			Program.Space();
		}


		private static bool IsSorted(List<int> list)
		{
			for (int i = 0; i < list.Count - 1; i++)
			{
				if (list[i] > list[i + 1])
				{
					return false;
				}
			}
			return true;
		}


		private static List<int> Remap(List<int> list)
		{
			int temp;
			List<int> newList = new List<int>();
			Random r = new Random();

			while (list.Count > 0)
			{
				temp = r.Next(list.Count);
				newList.Add(list[temp]);
				list.RemoveAt(temp);
			}
			return newList;
		}










	}
}
