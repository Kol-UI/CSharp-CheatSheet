using System;
namespace CSharp_CheatSheet.Exceptions
{
    public class ArgumentOutOfRange
    {
        public static void ArgumentOutOfRangeMain()
        {
            Program.Title("ArgumentOutOfRange");
            try
            {
                String[] srcArr = { "Sun", "Mon", "Tue", "Thu" };
                String[] destArr = new String[10];
                Console.WriteLine("Initial Array:");
                Program.PrintStringArrayValues(srcArr);
                Console.WriteLine("Trying to get the ConstrainedCopy" + " of length less than zero");
                Array.ConstrainedCopy(srcArr, 1, destArr, 0, -1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            Program.Space();
        }
    }
}
