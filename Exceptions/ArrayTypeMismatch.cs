using System;
namespace CSharp_CheatSheet.Exceptions
{
    public class ArrayTypeMismatch
    {
        public static void ArrayTypeMismatchMain()
        {
            Program.Title("ArrayTypeMismatch");
            try
            {
                String[] srcArr = { "Mario", "Luigi", "Wario", "Waluigi" };
                int[] destArr = new int[10];
                Console.WriteLine("Initial Array:");
                Program.PrintStringArrayValues(srcArr);
                Console.WriteLine("Trying to get the " + "ConstrainedCopy in destArr of type int");
                Console.WriteLine("but srcArr is of type String");
                Array.ConstrainedCopy(srcArr, 1, destArr, 0, 3);
            }
            catch (ArrayTypeMismatchException e)
            {

                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            Program.Space();
        }
    }
}
