using System;

namespace CSharp_CheatSheet.Algorithms
{
	public class CountingSortAlgorithm
	{
        public static int[] CountingSort(int[] input)
        {
            // Steps
            int numberofSteps = 0;

            var size = input.Length;
            // Steps
            numberofSteps += 1;
            var maxElement = GetMaxVal(input, size);
            // Steps
            numberofSteps += size + 1;
            var occurrences = new int[maxElement + 1];

            for (int i = 0; i < maxElement + 1; i++)
            {
                // Steps
                numberofSteps += 1;
                occurrences[i] = 0;
            }
            for (int i = 0; i < size; i++)
            {
                // Steps
                numberofSteps += 1;
                occurrences[input[i]]++;
            }
            for (int i = 0, j = 0; i <= maxElement; i++)
            {
                while (occurrences[i] > 0)
                {
                    input[j] = i;
                    j++;
                    occurrences[i]--;
                    // Steps
                    numberofSteps += 1;
                }
                // Steps
                numberofSteps += 1;
                // Start Print
                Program.Space();
                Console.WriteLine("The Array at step {0}:", numberofSteps);
                Program.PrintArrayIntOneLine(input);
                // End Print
            }

            return input;
        }

        private static int GetMaxVal(int[] input, int size)
        {
            var maxVal = input[0];
            for (int i = 1; i < size; i++)
            {
                if (input[i] > maxVal)
                    maxVal = input[i];
            }
            return maxVal;
        }

        // For Comparison
        public static int CountingSortComparison(int[] input)
        {
            // Steps
            int numberofSteps = 0;

            var size = input.Length;
            // Steps
            numberofSteps += 1;
            var maxElement = GetMaxVal(input, size);
            // Steps
            numberofSteps += size + 1;
            var occurrences = new int[maxElement + 1];
            // Steps
            numberofSteps += 1;

            for (int i = 0; i < maxElement + 1; i++)
            {
                // Steps
                numberofSteps += 1;
                // Steps
                numberofSteps += 1;
                occurrences[i] = 0;
                // Steps
                numberofSteps += 1;
            }
            for (int i = 0; i < size; i++)
            {
                // Steps
                numberofSteps += 1;
                occurrences[input[i]]++;
                // Steps
                numberofSteps += 1;
            }
            for (int i = 0, j = 0; i <= maxElement; i++)
            {
                while (occurrences[i] > 0)
                {
                    input[j] = i;
                    // Steps
                    numberofSteps += 1;
                    j++;
                    // Steps
                    numberofSteps += 1;
                    occurrences[i]--;
                    // Steps
                    numberofSteps += 1;
                }
                // Steps
                numberofSteps += 1;
            }

            return numberofSteps;
        }
    }
}