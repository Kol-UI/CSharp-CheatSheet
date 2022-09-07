using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class AsReadOnly
    {
        public static void AsReadOnlyFunction()
        {
            Program.Title("AsReadOnly");
            String[] myArr = { "This", "is", "an", "array" };
            Console.WriteLine("Initial Array:");
            PrintIndexAndValues(myArr);
            Program.Space();
            IList<String> myList = Array.AsReadOnly(myArr);
            Console.WriteLine("Read-only Array: ");
            PrintIndexAndValues(myList);
            Program.Space();

            try
            {
                myList[3] = "a super";
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("{0} - {1}", e.GetType(), e.Message);
                Console.WriteLine();
            }
            myArr[2] = "a cool";

            Console.WriteLine("Initial Array:");
            PrintIndexAndValues(myArr);
            Program.Space();
            Console.WriteLine("Read-only Array: ");
            PrintIndexAndValues(myList);
        }

        private static void PrintIndexAndValues(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {

                Console.WriteLine("{0}", myArr[i]);
            }
            Console.WriteLine();
        }

        private static void PrintIndexAndValues(IList<String> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("{0}", myList[i]);
            }
        }


    }
}
