using System;

namespace CSharp_CheatSheet.Algorithms
{
	public class SelectionSortAlgorithm
	{
		public static void SelectionSort(int[] input)
        {
            // Steps
            int numberofSteps = 0;
            
            for (var i = 0; i < input.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Length; j++)
                {
                    if(input[min] > input[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }

                // Start Print
                numberofSteps += 1;
                Program.Space();
                Console.WriteLine("The Array at step {0}:", numberofSteps);
                Program.PrintArrayIntOneLine(input);
                // End Print
            }
        }


        // For Comparison
        public static int SelectionSortComparison(int[] input)
        {
            // Steps
            int numberofSteps = 0;
            
            for (var i = 0; i < input.Length; i++)
            {
                // Steps
                numberofSteps += 1;
                var min = i;
                // Steps
                numberofSteps += 1;
                for (var j = i + 1; j < input.Length; j++)
                {
                    // Steps
                    numberofSteps += 1;
                    if(input[min] > input[j])
                    {
                        min = j;
                        // Steps
                        numberofSteps += 1;
                    }
                }
                // Steps
                numberofSteps += 1;
                if (min != i)
                {
                    // Steps
                    numberofSteps += 1;
                    var lowerValue = input[min];
                    // Steps
                    numberofSteps += 1;
                    input[min] = input[i];
                    // Steps
                    numberofSteps += 1;
                    input[i] = lowerValue;
                }

                // Steps
                numberofSteps += 1;
            }

            // Steps
            return numberofSteps;
        }
	}
}
