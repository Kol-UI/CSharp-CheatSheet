using System;
namespace CSharp_CheatSheet.Exceptions
{
    public class ArgumentNull
    {
        public static void ArgumentNullExceptionMain()
        {
            Program.Title("ArgumentNullException");
            try
            {
                int[] myArr = null;
                Console.WriteLine("Try to clear the element from null Array");
                Array.Clear(myArr, 1, 2);
                Console.WriteLine("Array after operation :"); 
                Program.PrintIntArrayValues(myArr);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine();
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            Program.Space();
            ArgumentNullExceptionExample2();
            Program.Space();
        }

        private static void ArgumentNullExceptionExample2()
        {
            Program.Space();
            Console.WriteLine("Example 2:");
            try
            {
                String[] srcArr = null;
                String[] destArr = new String[10];
                Console.WriteLine("Trying to get the ConstrainedCopy " + "while srcArr is null");
                Console.WriteLine();
                Array.ConstrainedCopy(srcArr, 1, destArr, 0, 3);
                Console.WriteLine("Destination Array: ");
                Program.PrintStringArrayValues(destArr);
            }
            catch (ArgumentNullException e)
            {

                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
        }
    }
}
