using System;
namespace CSharp_CheatSheet.Exceptions
{
    public class IndexOutOfRange
    {
        public static void IndexOutOfRangeExceptionMain()
        {
            Program.Title("IndexOutOfRange");
            try
            {
                int[] myArr = { 10, 20, 30, 40 };
                Console.WriteLine("Array Before Operation:");
                Program.PrintIntArrayValues(myArr);
                Console.WriteLine();
                Console.WriteLine("Taking index out of bound:");
                Array.Clear(myArr, -1, 2);
                Console.WriteLine("Array After Operation:"); 
                Program.PrintIntArrayValues(myArr);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("Exception Thrown :");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            Program.Space();
        }
    }
}
