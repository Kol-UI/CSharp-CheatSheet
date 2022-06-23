using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ArrayFunctions
    {
        public static void FrequencyInArray()
        {
            // Using Linq
            int[] arr = { 3, 5, 5, 4, 6, 7, 7, 5, 1, 9, 3, 2, 8, 7, 3, 9, 4, 6, 1, 5 };

            Console.WriteLine("--- Count the frequency of each element of an array ---");

            Console.WriteLine("The Array:");
            Console.WriteLine(string.Join(", ", arr));

            Console.WriteLine("Which number do you want to count ?");
            int value = Convert.ToInt32(Console.ReadLine());
            var frequency = arr.Count(x => x == value);
            Console.Write("{0} occurs {1} times.", value, frequency);

        }


        public static void CreateAnArray()
        {
            int input = 0;
            int[] IntArray = new int[5];

            Console.WriteLine("--- The user will create the 5 elements of an array ---");
            foreach (int i in IntArray)
            {
                Console.WriteLine("Element - {0} :", input + 1);
                int z = int.Parse(Console.ReadLine());
                IntArray[input] = z;
                input++;
            }

            Console.WriteLine("Here are all the elements of the array :");
            Console.WriteLine(string.Join(", ", IntArray));

        }


        public static void ReverseAnArray()
        {
            int[] ReversedArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("--- The program will reverse an Array ---");

            Console.WriteLine("\nOriginal Array:");
            for (int j = 0; j < ReversedArray.Length; j++)
            {
                Console.Write(ReversedArray[j] + " ");
            }
            Console.WriteLine("\nReversed:");
            for (int k = ReversedArray.Length - 1; k >= 0; k--)
            {
                Console.Write(ReversedArray[k] + " ");
            }
        }


        public static void FastReverse()
        {
            int[] ReversedArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("--- The program will .Reverse() an Array ---");
            Console.WriteLine("\nOriginal Array:");
            Console.WriteLine(string.Join(", ", ReversedArray));
            Console.WriteLine("\nFast Reverse:");
            Console.WriteLine(string.Join(", ", ReversedArray.Reverse()));
        }


        public static void SumOfElementsInArray()
        {
            Console.WriteLine("--- Sum of all elements in an Array ---");
            int sum = 0;
            Console.WriteLine("How many elements does the Array have ?");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter a value for each elements.");
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                Console.Write("Element - " + j + ": ");
                int arrayindex = int.Parse(Console.ReadLine());
                arr[i] = arrayindex;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The sum is: " + sum);
        }


        public static void SumOfElementsInArrayMethod()
        {
            Console.WriteLine("--- Sum of all elements in an Array (.Sum) ---");
            Console.WriteLine("How many elements does the Array have ?");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrayLength];

            Console.WriteLine("Enter a value for each elements.");
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                Console.Write("Element - " + j + ": ");
                int arrayindex = int.Parse(Console.ReadLine());
                arr[i] = arrayindex;
            }
            Console.WriteLine("The sum is: " + arr.Sum());
        }


        public static void CopyArrays()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;

            Console.WriteLine("--- Copy the elements from one array to another ---");
            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                int j = i + 1;
                Console.WriteLine("Element - {0} : ", j);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Copy
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("The elements stored in the first array are :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", arr1[i]);
            }
            Console.WriteLine("The elements copied into the second array are :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", arr2[i]);
            }
        }


        public static void CountTotalNumberOfDublicateElements()
        {
            Console.WriteLine("--- Count Total Number of Dublicate Elements in Array ---");
            Console.WriteLine("Select an Array Length:");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arrayLength];
            int[] arr2 = new int[arrayLength];
            int[] arr3 = new int[arrayLength];
            int mm = 1;
            int ctr = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine("Element - {0} : ", j);
                int arrayValue = int.Parse(Console.ReadLine());
                arr1[i] = arrayValue;
            }

            // Copy
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }

            // Mark Duplicate
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }

            // Count Duplicates
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr3[i] == 2)
                {
                    ctr++;
                }
            }
            Console.WriteLine("The number total of duplicate elements is: {0}", ctr);

            // Count Each Reiteration
            for (int i = 0; i < arr1.Length; i++)
            {
                var ReiterationCount = arr1.Count(v => v == i);
                if (ReiterationCount >= 2)
                {
                    Console.WriteLine("There is {0} times the value {1}", ReiterationCount, i);
                }
            }
        }


        public static void PrintUniqueElement()
        {
            int n, ctr = 0;
            int[] arr1 = new int[100];
            int i, j, k;
            Console.WriteLine("--- Print all unique elements of an array ---");
            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                int m = i + 1;
                Console.WriteLine("Element - {0} : ", m);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The unique elements found in the array are :");
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                // Check Duplicate Before Position
                for (j = 0; j < i - 1; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }
                // Check duplicate After Position
                for (k = i + 1; k < n; k++)
                {
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                    else if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.WriteLine();
        }


        public static void MergeArraysInOrder()
        {
            int[] Array1 = { 4, 2, 8, 8, 5, 0, -2 };
            int[] Array2 = { 9, 7, -3, 3, 10, -1, 5, 1, 6, 0 };

            Console.WriteLine("--- Merge Arrays in Order ---");
            Console.WriteLine("The Arrays:");
            Console.WriteLine(string.Join(", ", Array1));
            Console.WriteLine(string.Join(", ", Array2));
            // Using Linq
            int[] Array3 = Array1.Concat(Array2).ToArray();
            Array.Sort(Array3);
            Console.WriteLine("The new Array in Order:");
            Console.WriteLine(string.Join(", ", Array3));
            Console.WriteLine("The new Array Without Duplicates:");
            int[] Array4 = Array1.Union(Array2).ToArray();
            Array.Sort(Array4);
            Console.WriteLine(string.Join(", ", Array4));
        }


        public static void GetMinMaxArray()
        {
            Console.WriteLine("--- Get Min & Max of the Array ---");
            int[] MinMaxArray = { 4, 2, 8, 8, 5, 0, -2, 9, 7, -3, 3, 10, -1, 5, 1, 6, 0 };
            Console.WriteLine("The Array:");
            Console.WriteLine(string.Join(", ", MinMaxArray));

            // By Sorting
            int max_Value, min_Value;
            Array.Sort(MinMaxArray);
            min_Value = MinMaxArray[0];
            max_Value = MinMaxArray[MinMaxArray.Length - 1];
            Console.WriteLine("Array Max is: {0} \nArray Min is: {1}", max_Value, min_Value);

            // Linq Way
            GetMinMaxArrayMethod(MinMaxArray);
        }


        private static void GetMinMaxArrayMethod(int[] newArray)
        {
            Program.Space();
            Console.WriteLine("--- Using Linq to get Min & Max of the Array ---");
            Console.WriteLine("Array Max is: {0} \nArray Min is: {1}", newArray.Max(), newArray.Min());
        }


        public static void SortingArray()
        {
            Console.WriteLine("--- Sorting an Array in Ascending Order ---");
            int[] array = { 2, 7, 4, 5, 9, 1, 2, 9, 4, 7, 2, 5, 21 };
            int[] SecondaryArray = { 2, 7, 4, 5, 9, 1, 2, 9, 4, 7, 2, 5, 21, 1, 2, 9, 4, 7, 2, 5, };
            int tmp, j, i;
            for (i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Ascending Order:");
            Console.WriteLine(string.Join(", ", array));

            // Linq Way
            Program.Space();
            SortArray(SecondaryArray);

            // Descending Order
            Program.Space();
            SortingArrayDescendingOrder(array);

            // Descending Order Linq Way
            Program.Space();
            SortArrayDescending(SecondaryArray);
        }


        private static void SortArray(int[] array)
        {
            Console.WriteLine("--- Using Linq to Sort the Array in Ascending Order---");
            Console.WriteLine("Ascending Order:");
            Array.Sort(array);
            Console.WriteLine(string.Join(", ", array));
        }


        private static void SortingArrayDescendingOrder(int[] array)
        {
            Console.WriteLine("--- Sorting an Array in Descending Order ---");
            int i, j, tmp;
            for (i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Descending Order:");
            Console.WriteLine(string.Join(", ", array));
        }


        private static void SortArrayDescending(int[] array)
        {
            Console.WriteLine("--- Using Linq to Sort the Array in Descending Order ---");
            Console.WriteLine("Descending Order:");
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine(string.Join(", ", array));
        }


        public static void InsertNewValueInArray()
        {
            int[] NumbersArray = new int[] { 1, 2, 3 };
            Console.WriteLine("--- Insert New Value In Array (Sorted) ---");
            Console.WriteLine("The Array:");
            Console.WriteLine(string.Join(", ", NumbersArray));
            Console.WriteLine("Type a new value to insert into the array: ");
            int NumberNew = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref NumbersArray, NumbersArray.Length + 1);
            NumbersArray[^1] = NumberNew;
            Array.Sort(NumbersArray);
            Console.WriteLine("The Array is now:");
            Console.WriteLine(string.Join(", ", NumbersArray));
        }


        public static void ArrayToMatrix()
        {
            int i, j;
            int[,] Array2D = new int[3, 3];

            Console.WriteLine("--- 2D Array to Matrix ---");

            Console.WriteLine("Input elements in the matrix (int):");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Element - [{0},{1}] : ", i, j);
                    Array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Matrix is :");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", Array2D[i, j]);
                }
            }
            Program.Space();
        }










    }
}