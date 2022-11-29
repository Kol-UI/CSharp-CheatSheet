using System;
using System.Linq;

namespace CSharp_CheatSheet.Methods.ArrayMethods
{
	public class IndexOf
	{
		public static void IndexOfMain()
		{
            Program.Title("IndexOf");
            Program.Space();
            IntArrayIndexOf();
        }

		private static void IntArrayIndexOf()
		{
            int arraySize = CreateRandom(0);
            int[] intArray = new int[arraySize];
			EnterIntValues(intArray);
            Program.Space();
            Console.WriteLine("[{0}]", string.Join(", ", intArray));
            FindValues(intArray);
            Program.Space();
        }

        private static Array EnterIntValues(int[] intArray)
		{
            int random0 = 0;
            int num = intArray.Count();
            int i = 0;
            for (i = 0; i < num; i++)
            {
                intArray[i] = CreateRandom(random0);
            }
            return intArray;
        }

        private static void FindValues(int[] intArray)
        {
            int num = 10;
            int f = 0; int g = 0;

            for (f = 0; f <= num; f++)
            {
                int index2 = Array.IndexOf(intArray, f);
                if (index2 != -1)
                {
                    Console.WriteLine("IndexOf " + f + " :");
                    Console.WriteLine(index2);
                }
                else
                {
                    Console.WriteLine("There is no " + f + " value here.");
                }
            }
            Program.Space();

            for (g = 0; g <= num; g++)
            {
                int index3 = Array.LastIndexOf(intArray, g);
                if (index3 != -1)
                {
                    Console.WriteLine("LastIndexOf " + g + " :");
                    Console.WriteLine(index3);
                }
                else
                {
                    Console.WriteLine("There is no " + g + " value here.");
                }
            }
        }



        private static int CreateRandom(int random)
        {
            Random rnd = new Random();
            random = rnd.Next(0, 10);
            return random;
        }
    }
}

