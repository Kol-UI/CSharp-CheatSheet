using System;
using System.Collections;

namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class GetEnumerator
    {
        public static void GetEnumeratorMain()
        {
            Program.Title("GetEnumerator");
            Example1();
            Program.Space();
            Example2();
            Program.Space();
        }

        private static void Example1()
        {
            Console.WriteLine("Int Example:");
            int[] myArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("Initial Array: ");
            Program.PrintIntArrayValues(myArr);

            IEnumerator myEnumerator = myArr.GetEnumerator();
            Console.WriteLine("Enumerated value: ");
            PrintIndexAndValues(myEnumerator);
        }

        private static void Example2()
        {
            Console.WriteLine("String Example:");
            String[] myArr = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Console.WriteLine("Initial Array: ");
            Program.PrintStringArrayValues(myArr);
            IEnumerator myEnumerator = myArr.GetEnumerator();
            Console.WriteLine("Enumerated value: ");
            PrintIndexAndValues(myEnumerator);
        }

        public static void PrintIndexAndValues(IEnumerator myEnumerator)
        {
            int i = 1;
            while ((myEnumerator.MoveNext()) && (myEnumerator.Current != null))
            {
                Console.WriteLine("{0}> {1} ", i++, myEnumerator.Current);
            }
        }
    }
}
