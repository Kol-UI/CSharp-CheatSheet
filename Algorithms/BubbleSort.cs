using System;
using System.Linq;

namespace CSharp_CheatSheet.Algorithms
{
	public class BubbleSortAlgorithm
	{
		public static void BubbleSort(int[] input)
        {
            // Steps
            int numberofSteps = 0;
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
                // Start Print
                numberofSteps += 1;
                Program.Space();
                Console.WriteLine("The Array at step {0}:", numberofSteps);
                Program.PrintArrayIntOneLine(input);
                // End Print

            } while (itemMoved);
        }

        // For Comparison
        public static int BubbleSortComparison(int[] input)
        {
            // Steps
            int numberofSteps = 0;
            var itemMoved = false;
            // Steps
            numberofSteps += 1;
            do
            {
                // Steps
                numberofSteps += 1;
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        // Steps
                        numberofSteps += 1;
                        // Steps
                        numberofSteps += 1;
                        var lowerValue = input[i + 1];
                        // Steps
                        numberofSteps += 1;
                        input[i + 1] = input[i];
                        // Steps
                        numberofSteps += 1;
                        input[i] = lowerValue;
                        // Steps
                        numberofSteps += 1;
                        itemMoved = true;
                        // Steps
                        numberofSteps += 1;
                    }
                    // Steps
                    numberofSteps += 1;
                }
                // Steps
                numberofSteps += 1;

            } while (itemMoved);

            // Steps
            return numberofSteps;
        }
	}
}