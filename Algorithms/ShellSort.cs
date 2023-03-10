using System;

namespace CSharp_CheatSheet.Algorithms
{
	public class ShellSortAlgorithm
	{
        public static void ShellSort(int[] input)
        {
            int numberofSteps = 0;

            int size = input.Length;
            for (int interval = size / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < size; i++)
                {
                    var currentKey = input[i];
                    var k = i;
                    while (k >= interval && input[k - interval] > currentKey)
                    {
                        input[k] = input[k - interval];
                        k -= interval;
                    }
                    input[k] = currentKey;
                    // Steps
                    numberofSteps += 1;
                }
                // Start Print
                numberofSteps += 1;
                Program.Space();
                Console.WriteLine("The Array at step {0}:", numberofSteps);
                Program.PrintArrayIntOneLine(input);
                // End Print
            }
        }


        public static int ShellSortComparison(int[] input)
        {
            int numberofSteps = 0;

            int size = input.Length;
            // Steps
            numberofSteps += 1;
            for (int interval = size / 2; interval > 0; interval /= 2)
            {
                // Steps
                numberofSteps += 1;
                for (int i = interval; i < size; i++)
                {
                    // Steps
                    numberofSteps += 1;
                    var currentKey = input[i];
                    // Steps
                    numberofSteps += 1;
                    var k = i;
                    while (k >= interval && input[k - interval] > currentKey)
                    {
                        // Steps
                        numberofSteps += 1;
                        input[k] = input[k - interval];
                        // Steps
                        numberofSteps += 1;
                        k -= interval;
                    }
                    input[k] = currentKey;
                    // Steps
                    numberofSteps += 1;
                }
            }
            return numberofSteps;
        }
    }
}