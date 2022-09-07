using System;
namespace CSharp_CheatSheet.Exceptions
{
    public class Rank
    {
        public static void RankExceptionMain()
        {
            Program.Space();
            try
            {
                String[] srcArr = { "Sun", "Mon", "Tue", "Thu" };
                String[,] destArr = new String[10, 5];
                Console.WriteLine("Initial Array:");
                Program.PrintStringArrayValues(srcArr);
                Console.WriteLine("Trying to get the ConstrainedCopy " + "in destArr of rank 2");
                Console.WriteLine("while rank of srcArr is 1");
                Array.ConstrainedCopy(srcArr, 1, destArr, 0, 3);
            }
            catch (RankException e)
            {
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            Program.Space();
        }
    }
}
