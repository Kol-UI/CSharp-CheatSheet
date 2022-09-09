using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class CopyTo
    {
        public static void CopyToMain()
        {
            Program.Title("CopyTo");
            Array myArrayZero = Array.CreateInstance(typeof(string), 3);
            myArrayZero.SetValue("zero", 0);
            myArrayZero.SetValue("one", 1);

            Console.WriteLine("The array with lower bound=0 contains:");
            Program.PrintIndexAndValues(myArrayZero);

            int[] myArrLen = { 4 };
            int[] myArrLow = { 2 };
            Array myArrayTwo = Array.CreateInstance(typeof(string), myArrLen, myArrLow);
            myArrayTwo.SetValue("two", 2);
            myArrayTwo.SetValue("three", 3);
            myArrayTwo.SetValue("four", 4);
            myArrayTwo.SetValue("five", 5);

            Console.WriteLine("The array with lower bound=2 contains:");
            Program.PrintIndexAndValues(myArrayTwo);

            myArrayZero.CopyTo(myArrayTwo, 3);
            Console.WriteLine("\nAfter copying to the target array from index 3:");
            Program.PrintIndexAndValues(myArrayTwo);

            SecondExampleCopyTo();
        }

        private static void SecondExampleCopyTo()
        {
            Program.Space();
            Console.WriteLine("Second Example:");
            Array mySourceArray = Array.CreateInstance(typeof(string), 6);
            mySourceArray.SetValue("three", 0);
            mySourceArray.SetValue("napping", 1);
            mySourceArray.SetValue("cats", 2);
            mySourceArray.SetValue("in", 3);
            mySourceArray.SetValue("the", 4);
            mySourceArray.SetValue("barn", 5);
            Array myTargetArray = Array.CreateInstance(typeof(string), 15);
            myTargetArray.SetValue("The", 0);
            myTargetArray.SetValue("quick", 1);
            myTargetArray.SetValue("brown", 2);
            myTargetArray.SetValue("fox", 3);
            myTargetArray.SetValue("jumps", 4);
            myTargetArray.SetValue("over", 5);
            myTargetArray.SetValue("the", 6);
            myTargetArray.SetValue("lazy", 7);
            myTargetArray.SetValue("dog", 8);

            Console.WriteLine("The target Array contains the following (before and after copying):");
            Program.PrintValues(myTargetArray);
            mySourceArray.CopyTo(myTargetArray, 6);
            Program.PrintValues(myTargetArray);
        }


    }
}
