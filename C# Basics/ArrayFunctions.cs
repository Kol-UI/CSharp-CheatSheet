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





    }
}
