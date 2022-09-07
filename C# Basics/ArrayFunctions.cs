using System;
using System.Collections.Generic;
using System.Linq;
using CSharp_CheatSheet.CBasics;

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

            Program.Space();
            Console.WriteLine("Original Array:");
            for (int j = 0; j < ReversedArray.Length; j++)
            {
                Console.Write(ReversedArray[j] + " ");
            }
            Program.Space();
            Console.WriteLine("Reversed:");
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
            Program.Space();
            Console.WriteLine("Which Array to Matrices ?\n1) 2D Matrix\t2) Addition two Matrices");
            var MatricesInput = Console.ReadLine();
            int valueMatricesInput = int.Parse(MatricesInput);
            switch (valueMatricesInput)
            {
                case 1:
                    MatricesFunctions.Matrices2D();
                    break;
                case 2:
                    MatricesFunctions.AdditionTwoMatrices();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }


        public static void ArrayOverview()
        {
            Program.Title("Single-Dimensional Array of 5 integers");
            Console.WriteLine("\t int[] array1 = new int[5];");
            int[] array1 = new int[5];
            Array.ForEach(array1, Console.WriteLine);

            Program.Title("Declare & Set Array Element Values");
            Console.WriteLine("\t int[] array2 = new int[] { 1, 3, 5, 7, 9 };");
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            Array.ForEach(array2, Console.WriteLine);

            Program.Title("Alternative Syntax");
            Console.WriteLine("\t int[] array3 = { 1, 2, 3, 4, 5, 6 };");
            int[] array3 = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(array3, Console.WriteLine);

            Program.Title("Declare Two-Dimensional Array");
            Console.WriteLine("\t int[,] multiDimensionalArray1 = new int[2, 3];");
            int[,] multiDimensionalArray1 = new int[2, 3];
            Program.Title("Print Two-Dimensional Array");
            var rowCount = multiDimensionalArray1.GetLength(0);
            var colCount = multiDimensionalArray1.GetLength(1);
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    Console.Write(String.Format("{0}\t", multiDimensionalArray1[row, col]));
                }

                Console.WriteLine();
            }

            Program.Title("Set Multi Dimensional Array Element Values");
            Console.WriteLine("\t int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };");
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            var rowCount2 = multiDimensionalArray2.GetLength(0);
            var colCount2 = multiDimensionalArray2.GetLength(1);
            for (int row = 0; row < rowCount2; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    Console.Write(String.Format("{0}\t", multiDimensionalArray2[row, col]));
                }

                Console.WriteLine();
            }

            Program.Title("Declare Jagged Array");
            Console.WriteLine("\t int[][] jaggedArray1 = new int[6][];");
            int[][] jaggedArray1 = new int[6][];

            Program.Title("Set Values of the First Array in the Jagged Array Structure");
            Console.WriteLine("\t jaggedArray1[0] = new int[4] { 1, 2, 3, 4 };");
            jaggedArray1[0] = new int[4] { 1, 2, 3, 4 };

            Program.Title("Get Number of Dimension of an Array");
            Console.WriteLine("\t int[,] theArray = new int[5, 10];");
            int[,] theArray = new int[5, 10];
            Console.WriteLine("The array has {0} dimensions.", theArray.Rank);

            Program.Title("Single Dimensional String Array");
            Console.WriteLine("\t string[] weekDays = new string[] { 'Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat' }; ");
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Array.ForEach(weekDays, Console.WriteLine);

            Program.Title("Retrieving Data From Array");
            Console.WriteLine(weekDays[6]);
            Console.WriteLine(weekDays[0]);

            Program.Title("Multi Array Dimensions Specified");
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            var rowCount2Da = array2Da.GetLength(0);
            var colCount2Da = array2Da.GetLength(1);
            for (int row = 0; row < rowCount2Da; row++)
            {
                for (int col = 0; col < colCount2Da; col++)
                {
                    Console.Write(String.Format("{0}\t", array2Da[row, col]));
                }

                Console.WriteLine();
            }

            Program.Title("Multi String Array Dimensions Specified");
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            var rowCount2Db = array2Db.GetLength(0);
            var colCount2Db = array2Db.GetLength(1);
            for (int row = 0; row < rowCount2Db; row++)
            {
                for (int col = 0; col < colCount2Db; col++)
                {
                    Console.Write(String.Format("{0}\t", array2Db[row, col]));
                }

                Console.WriteLine();
            }

            Program.Title("Three Dimensional Array");
            Console.WriteLine("\t int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };");
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Program.Title("Three Dimensional Array Dimension Specified");
            Console.WriteLine("\t int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };");
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Program.Title("Array Without Specifying the Rank");
            Console.WriteLine("\t int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };");
            int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Program.Title("Declare Int Jagged Array");
            Console.WriteLine("\t int[][] jaggedArray = new int[3][];");
            int[][] jaggedArray = new int[3][];

            Program.Title("Initialize Int Jagged Array");
            Console.WriteLine("\t jaggedArray[0] = new int[5];");
            Console.WriteLine("\t jaggedArray[1] = new int[4];");
            Console.WriteLine("\t jaggedArray[2] = new int[2];");
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            Program.Title("Access Individual Jagged Array Elements");
            Console.WriteLine("Assign 77 to the second element ([1]) of the first array ([0])");
            Console.WriteLine("\t jaggedArray[0][1] = 77;");
            jaggedArray[0][1] = 77;
            Console.WriteLine("Assign 88 to the second element ([1]) of the third array ([2])");
            Console.WriteLine("\t jaggedArray[2][1] = 88;");
            jaggedArray[2][1] = 88;

            Program.Title("Shorthand Jagged Array Form");
            Console.WriteLine("\t int[][,] jaggedArray2 = new int[3][,] { new int[,] { { 1, 3 }, { 5, 7 } }, new int[,] { { 0, 2 }, { 4, 6 }, { 8, 10 } }, new int[,] { { 11, 22 }, { 99, 88 }, { 0, 9 } } }; ");
            int[][,] jaggedArray2 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

            Program.Title("Number of Arrays Contained in Jagged Array");
            Console.WriteLine("\t jaggedArray2.Length = {0}", jaggedArray2.Length);

            Program.Title("Single Dimensional Array Foreach Statement");
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }

            Program.Title("Multi Dimensional Array Foreach Statement");
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void Result(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array Element: " + arr[i]);
            }

        }

        private static int temp = 0;

        private static void Transpose(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
        }

        private static void Displayresult(int[,] arr)
        {

            Console.WriteLine("Matrix After Transpose: ");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }

        public static void PassingArrayAsArgument()
        {
            Console.WriteLine("--- Passing Arrays as Arguments ---");
            Program.Title("Single Dimension Array as Arguments");
            int[] arrSingle = { 1, 2, 3, 4, 5 };
            Result(arrSingle);


            Program.Title("Multiple Dimension Array as Arguments");
            int[,] arr;
            arr = new int[6, 4]{ { 1, 2, 3, 4},
                             { 5, 6, 7, 8},
                             {9, 10, 11, 12},
                             {13, 14, 9, 10,},
                             { 0, 7, 3, 5},
                             {13, 14, 15, 16} };

            Console.WriteLine("Matrix Before Transpose: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Transpose(arr);
            Displayresult(arr);
        }

    }
}