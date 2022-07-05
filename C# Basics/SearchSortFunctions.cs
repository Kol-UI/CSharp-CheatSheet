using System;
using System.Collections.Generic;
using System.Linq;

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


		// Bubble Sort
		public static void BubbleSortFunction()
        {
            int[] array = { 5, -1, 4, 1, 3, 0, 2, 7 };
            int t;
            Console.WriteLine("--- Bubble Sort ---");

            Console.WriteLine("The Array :");
            foreach (int intCouple in array)
            {
                Console.Write(intCouple + " ");
            }

            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        t = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = t;
                    }
                }
            }

            Program.Space();
            Console.WriteLine("Sorted array :");
            foreach (int intCouple in array)
            {
                Console.Write(intCouple + " ");
            }
            Program.Space();
        }



		// Counting Sort
        public static void CountingSortMain()
        {

            Console.WriteLine("--- Counting Sort ---");
            int[] array = new int[10]{ 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };

            Program.Space();
            Console.WriteLine("Original array :");
            foreach (int intCouple in array)
            {
                Console.Write(intCouple + " ");
            }

            int[] sortedArray = new int[array.Length];

            // Smallest & Largest
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // Frequencies
            int[] counts = new int[maxVal - minVal + 1];
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            int sortedArrayIndex = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int k = 0; k < counts[i]; k++)
                {
                    sortedArray[sortedArrayIndex++] = i + minVal;
                }
            }

            Program.Space();
            Console.WriteLine("Sorted array :");
            foreach (int intCouple in sortedArray)
            {
                Console.Write(intCouple + " ");
            }
            Program.Space();

        }


        // Heap Sort
        public static void HeapSortMain()
        {
            Console.WriteLine("--- Heap Sort ---");
			int[] arrayInt = new int[] { 2, 5, 1, -4, 11, 0, 10, 18, 3, 8, 22, 3, 44, 7, 8, 67, 15, 51, 6, 12};
			double[] arrayDouble = new double[] { 2.22, -9.23, -8.6, 6.5, 6.8, -3.4, 0.5, 2.7, -1.0, 11.2, 6.29, 5.3, 2.5, 1.4, 1.1, 0.10, 8.1, 3.8, 2.2, 3.4, 4.7, 8.6, 7.1, 5.51, 6.1, 2.2};
            string[] arrayString = new string[] {"Red", "Maganta", "Blue", "White", "Gray", "Black", "Green", "Orange", "Yellow", "Purple", "Cyan"};

			// Int
            Program.Space();
			Console.WriteLine("Original Int Array Elements :");
			PrintArray(arrayInt);
			HeapSort(arrayInt);
			Program.Space();
			Console.WriteLine("Sorted Int Array Elements :");
			PrintArray(arrayInt);
			Program.Space();

			// Double
			Program.Space();
			Console.WriteLine("Original Double Array Elements :");
            PrintArray(arrayDouble);
			HeapSort(arrayDouble);
			Program.Space();
			Console.WriteLine("Sorted Double Array Elements :");
			PrintArray(arrayDouble);
			Program.Space();

			// String
			Program.Space();
			Console.WriteLine("Original String Array Elements :");
			PrintArray(arrayString);
			HeapSort(arrayString);
			Program.Space();
			Console.WriteLine("Sorted String Array Elements :");
			PrintArray(arrayString);
			Program.Space();

		}


		private static void HeapSort<T>(T[] array) where T : IComparable<T>
		{
			int heapSize = array.Length;

			BuildMaxHeap(array);

			for (int i = heapSize - 1; i >= 1; i--)
			{
				Swap(array, i, 0);
				heapSize--;
				Sink(array, heapSize, 0);
			}
		}

		private static void BuildMaxHeap<T>(T[] array) where T : IComparable<T>
		{
			int heapSize = array.Length;

			for (int i = (heapSize / 2) - 1; i >= 0; i--)
			{
				Sink(array, heapSize, i);
			}
		}

		private static void Sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
		{
            if (GetLeftKidPos(toSinkPos) >= heapSize)
            {
				return;
			}
			int largestKidPos;
			bool leftIsLargest;

			if (GetRightKidPos(toSinkPos) >= heapSize || array[GetRightKidPos(toSinkPos)].CompareTo(array[GetLeftKidPos(toSinkPos)]) < 0)
			{
				largestKidPos = GetLeftKidPos(toSinkPos);
				leftIsLargest = true;
			}
			else
			{
				largestKidPos = GetRightKidPos(toSinkPos);
				leftIsLargest = false;
			}

			if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
			{
				Swap(array, toSinkPos, largestKidPos);

				if (leftIsLargest)
				{
					Sink(array, heapSize, GetLeftKidPos(toSinkPos));

				}
				else
				{
					Sink(array, heapSize, GetRightKidPos(toSinkPos));
				}
			}

		}

		private static void Swap<T>(T[] array, int pos0, int pos1)
		{
			T tmpVal = array[pos0];
			array[pos0] = array[pos1];
			array[pos1] = tmpVal;
		}

		private static int GetLeftKidPos(int parentPos)
		{
			return (2 * (parentPos + 1)) - 1;
		}

		private static int GetRightKidPos(int parentPos)
		{
			return 2 * (parentPos + 1);
		}

		private static void PrintArray<T>(T[] array)
		{

			foreach (T t in array)
			{
				Console.Write(' ' + t.ToString() + ' ');
			}

		}




        // Insertion Sort
        public static void InsertionSortMain()
        {
            Console.WriteLine("--- Insertion Sort ---");
            int[] intArray = new int[] { 24, 5, -4, 11, 0, 18, 22, 63, 51, 6, 26, 35, 1, -2, 13, 0, 10, 18, 39, 8, 25, 32, 44, 7, 8, 67, 15, 54, 46, 12,
                38, 57, 66, 75, 29, 30, 87, 39, 49, 52, 79, 69, 99, 95, 65, 45, 63, 40, 27, 92, 14};

            Program.Space();
            Console.WriteLine("Original Array Elements :");
            PrintIntegerArray(intArray);
            Program.Space();
            Console.WriteLine("Sorted Array Elements :");
            PrintIntegerArray(InsertionSort(intArray));
            Program.Space();
        }

        private static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        private static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }




        // Merge Sort
        public static void MergeSortMain()
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;

            Random random = new Random();
            Console.WriteLine("--- Merge Sort ---");
            Console.WriteLine("Original array elements:");
            for (int i = 0; i < 20; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Program.Space();

            sorted = SortingMerge(unsorted);
            Console.WriteLine("Sorted array elements: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Program.Space();
        }


        private static List<int> SortingMerge(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = SortingMerge(left);
            right = SortingMerge(right);
            return Merging(left, right);
        }

        private static List<int> Merging(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  // Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());       // First() Linq
                        left.Remove(left.First());      // Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }



        // Permutation Sort
        public static void PermutationSortMain()
        {
            Console.WriteLine("--- Permutation Sort ---");
            string str = "ABC";
            char[] arr = str.ToCharArray();
            GetPerList(arr);
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        private static void GetPerList(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(list);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
            }
        }



        // Quick Sort
        public static void QuickSortMain()
        {
            Console.WriteLine("--- Quick Sort ---");
            int[] QuickArray = new int[] { 24, 5, -4, 11, 0, 18, 22, 63, 51, 6, 26, 35, 1, -2, 13, 0, 10, 18, 39, 8, 25, 32, 44, 7, 8, 67, 15, 54, 46, 12,
                38, 57, 66, 75, 29, 30, 87, 39, 49, 52, 79, 69, 99, 95, 65, 45, 63, 40, 27, 92, 14, 272, 145, 175, 181, 501, 102, 124, 166};

            Program.Space();
            Console.WriteLine("Original Values:");
            Console.WriteLine(string.Join(", ", QuickArray));
            Program.Space();
            QuickSorting(QuickArray, 0, QuickArray.Length - 1);
            Console.WriteLine("Sorted Values:");
            Console.WriteLine(string.Join(", ", QuickArray));
        }


        private static void QuickSorting(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSorting(arr, start, i - 1);
                QuickSorting(arr, i + 1, end);
            }
        }


        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }




        // Radix Sort
        public static void RadixSortMain()
        {
            Console.WriteLine("--- Radix Sort ---");
            int[] RadixArray = new int[] { 24, 5, -4, 11, 0, 18, 22, 63, 51, 6, 26, 35, 1, -2, 13, 0, 10, 18, 39, 8, 25, 32, 44, 7, 8, 67, 15, 54, 46, 12,
                38, 57, 66, 75, 29, 30, 87, 39, 49, 52, 79, 69, 99, 95, 65, 45, 63, 40, 27, 92, 14, 272, 145, 175, 181, 501, 102, 124, 166};

            Program.Space();
            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", RadixArray));
            Program.Space();
            RadixSortHelper(RadixArray);
            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", RadixArray));
        }

        private static void RadixSortHelper(int[] RadixArray)
        {
            int i, j;
            int[] tmp = new int[RadixArray.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < RadixArray.Length; ++i)
                {
                    bool move = (RadixArray[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                    {
                        RadixArray[i - j] = RadixArray[i];
                    }
                    else
                    {
                        tmp[j++] = RadixArray[i];
                    }
                }
                Array.Copy(tmp, 0, RadixArray, RadixArray.Length - j, j);
            }
        }

        



        // Selection Sort
        public static void SelectionSortMain()
        {
            Console.WriteLine("--- Selection Sort ---");
            int[] SelectionArray = new int[] { 24, 5, -4, 11, 0, 18, 22, 63, 51, 6, 26, 35, 1, -2, 13, 0, 10, 18, 39, 8, 25, 32, 44, 7, 8, 67, 15, 54, 46, 12,
                38, 57, 66, 75, 29, 30, 87, 39, 49, 52, 79, 69, 99, 95, 65, 45, 63, 40, 27, 92, 14, 272, 145, 175, 181, 501, 102, 124, 166, 140, 110, 120, 130,
                150};

            Program.Space();
            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", SelectionArray));
            Program.Space();
            SelectionSortHelper(SelectionArray);
            Program.Space();
            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(", ", SelectionArray));
        }


        private static int[] SelectionSortHelper(int[] SelectionArray)
        {
            var arrayLength = SelectionArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (SelectionArray[j] < SelectionArray[smallestVal])
                    {
                        smallestVal = j;
                        Console.WriteLine("Sorting Array...");
                        Console.WriteLine(string.Join(", ", SelectionArray));
                        System.Threading.Thread.Sleep(100);
                    }
                }
                var tempVar = SelectionArray[smallestVal];
                SelectionArray[smallestVal] = SelectionArray[i];
                SelectionArray[i] = tempVar;
            }
            return SelectionArray;
        }



    }
}
