using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class CreateInstance
    {
        public static void CreateInstanceMain()
        {
            Program.Title("CreateInstance");
            Array my1DArray = Array.CreateInstance(typeof(int), 5);
            for (int i = my1DArray.GetLowerBound(0); i <= my1DArray.GetUpperBound(0); i++)
            {
                my1DArray.SetValue(i + 1, i);
            }
            Console.WriteLine("The one-dimensional Array contains the following values:");
            Program.PrintValues(my1DArray);

            Program.Title("CreateInstance Multi Dimension");
            CreateInstanceMulti();
            Program.Title("CreateInstance Two Dimension Array of String");
            TwoDimensionArrayOfString();
            Program.Title("Bound of Multi Dimensional Array");
            BoundOfMultiArray();
            Program.Title("Multi Dimension Array of Object");
            MultiDimensionArrayOfObject();
        }

        private static void CreateInstanceMulti()
        {
            int[] myLengthsArray = new int[4] { 2, 3, 4, 5 };
            Array my4DArray = Array.CreateInstance(typeof(string), myLengthsArray);
            for (int i = my4DArray.GetLowerBound(0); i <= my4DArray.GetUpperBound(0); i++)
            {
                for (int j = my4DArray.GetLowerBound(1); j <= my4DArray.GetUpperBound(1); j++)
                {
                    for (int k = my4DArray.GetLowerBound(2); k <= my4DArray.GetUpperBound(2); k++)
                    {
                        for (int l = my4DArray.GetLowerBound(3); l <= my4DArray.GetUpperBound(3); l++)
                        {
                            int[] myIndicesArray = new int[4] { i, j, k, l };
                            my4DArray.SetValue(Convert.ToString(i) + j + k + l, myIndicesArray);
                        }
                    }
                }
            }
            Console.WriteLine("The four-dimensional Array contains the following values:");
            Program.PrintValues(my4DArray);
            Program.Space();
        }

        private static void TwoDimensionArrayOfString()
        {
            Array my2DArray = Array.CreateInstance(typeof(string), 2, 3);
            for (int i = my2DArray.GetLowerBound(0); i <= my2DArray.GetUpperBound(0); i++)
            {
                for (int j = my2DArray.GetLowerBound(1); j <= my2DArray.GetUpperBound(1); j++)
                {
                    my2DArray.SetValue("abc" + i + j, i, j);
                }
            }

            Console.WriteLine("The two-dimensional Array contains the following values:");
            Program.PrintValues(my2DArray);
            Program.Space();
        }

        private static void BoundOfMultiArray()
        {
            int[] myLengthsArray = new int[2] { 3, 5 };
            int[] myBoundsArray = new int[2] { 2, 3 };
            Array myArray = Array.CreateInstance(typeof(string), myLengthsArray, myBoundsArray);
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                for (int j = myArray.GetLowerBound(1); j <= myArray.GetUpperBound(1); j++)
                {
                    int[] myIndicesArray = new int[2] { i, j };
                    myArray.SetValue(Convert.ToString(i) + j, myIndicesArray);
                }
            }
            Console.WriteLine("Bounds:\tLower\tUpper");
            for (int i = 0; i < myArray.Rank; i++)
            {
                Console.WriteLine("{0}:\t{1}\t{2}", i, myArray.GetLowerBound(i), myArray.GetUpperBound(i));
            }
            Console.WriteLine("The Array contains the following values:");
            Program.PrintValues(myArray);
            Program.Space();
        }

        private static void MultiDimensionArrayOfObject()
        {
            Array my3DArray = Array.CreateInstance(typeof(Object), 2, 3, 4);
            for (int i = my3DArray.GetLowerBound(0); i <= my3DArray.GetUpperBound(0); i++)
            {
                for (int j = my3DArray.GetLowerBound(1); j <= my3DArray.GetUpperBound(1); j++)
                {
                    for (int k = my3DArray.GetLowerBound(2); k <= my3DArray.GetUpperBound(2); k++)
                    {
                        my3DArray.SetValue("abc" + i + j + k, i, j, k);
                    }
                }
            }
            Console.WriteLine("The three-dimensional Array contains the following values:");
            Program.PrintValues(my3DArray);
            Program.Space();
        }
    }
}
