using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Copy
    {
        public static void CopyMain()
        {
            Program.Title("Copy");
            Array myIntArray = Array.CreateInstance(typeof(System.Int32), 5);
            for (int i = myIntArray.GetLowerBound(0); i <= myIntArray.GetUpperBound(0); i++)
            {
                myIntArray.SetValue(i + 1, i);
            }

            Array myObjArray = Array.CreateInstance(typeof(System.Object), 5);
            for (int i = myObjArray.GetLowerBound(0); i <= myObjArray.GetUpperBound(0); i++)
            {
                myObjArray.SetValue(i + 26, i);
            }

            Console.WriteLine("Int array:");
            PrintValues(myIntArray);
            Console.WriteLine("Object array:");
            PrintValues(myObjArray);

            Array.Copy(myIntArray, myIntArray.GetLowerBound(0), myObjArray, myObjArray.GetLowerBound(0), 1);
            Array.Copy(myObjArray, myObjArray.GetUpperBound(0) - 1, myIntArray, myIntArray.GetUpperBound(0) - 1, 2);

            Console.WriteLine("Int Array - Last two elements should now be the same as Object array:");
            PrintValues(myIntArray);
            Console.WriteLine("Object Array - First element should now be the same as int array:");
            PrintValues(myObjArray);
            Program.Space();
        }

        public static void PrintValues(Array myArr)
        {
            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
}
