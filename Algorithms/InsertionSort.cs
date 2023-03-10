using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet.Algorithms
{
	public class InsertionSortAlgorithm
	{
		public static void InsertionSort(int[] input)
        {
            // Steps
            int numberofSteps = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }
                input[currentIndex] = item;

                // Start Print
                numberofSteps += 1;
                Program.Space();
                Console.WriteLine("The Array at step {0}:", numberofSteps);
                Program.PrintArrayIntOneLine(input);
                // End Print
            }
        }


        public static List<int> InsertionSortNew(List<int> input)
        {
            // Steps
            int numberofSteps = 0;

            var clonedList = new List<int>(input.Count);

            for (int i = 0; i < input.Count; i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && clonedList[currentIndex - 1] > item)
                {
                    currentIndex--;
                }

                // Start Print
                numberofSteps += 1;
                Program.Space();
                Console.WriteLine("The Array at step {0}:", numberofSteps);
                Program.PrintListInt(input);
                // End Print

                clonedList.Insert(currentIndex, item);
            }

            return clonedList;
        }

        // For Comparison
        public static int InsertionSortComparison(int[] input)
        {
            // Steps
            int numberofSteps = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                // Steps
                numberofSteps += 1;
                var item = input[i];
                // Steps
                numberofSteps += 1;
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    // Steps
                    numberofSteps += 3;
                    // Steps
                    numberofSteps += 1;
                    input[currentIndex] = input[currentIndex - 1];
                    // Steps
                    numberofSteps += 1;
                    currentIndex--;

                    // Steps
                    numberofSteps += 1;
                }
                // Steps
                numberofSteps += 1;
                input[currentIndex] = item;

                // Steps
                numberofSteps += 1;
            }

            // Steps
            return numberofSteps;
        }


        public static int InsertionSortNewComparison(int[] inputArray)
        {
            // Steps
            int numberofSteps = 0;

            List<int> input = inputArray.ToList();
            // Steps
            numberofSteps += 1;

            var clonedList = new List<int>(input.Count);
            // Steps
            numberofSteps += 1;

            for (int i = 0; i < input.Count; i++)
            {
                // Steps
                numberofSteps += 1;
                var item = input[i];
                // Steps
                numberofSteps += 1;
                var currentIndex = i;
                
                while (currentIndex > 0 && clonedList[currentIndex - 1] > item)
                {
                    // Steps
                    numberofSteps += 3;
                    // Steps
                    numberofSteps += 1;
                    currentIndex--;
                    // Steps
                    numberofSteps += 1;
                }

                // Steps
                numberofSteps += 1;
                clonedList.Insert(currentIndex, item);

                // Steps
                numberofSteps += 1;
            }

            // return clonedList;

            // Steps
            return numberofSteps;
        }
	}
}