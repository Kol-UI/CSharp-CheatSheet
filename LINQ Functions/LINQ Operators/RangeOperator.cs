using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class RangeOperator
    {
        public static void LINQRangeFunction(){
            IntSequence();
            SequenceWithFilter();
            SequenceAndSquareOfEach();
            StringSequence();
        }


        private static void IntSequence(){
            Console.WriteLine("Sequence of integers from 1 to 10:");
            IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
            foreach (int i in numberSequence)
            {
                Console.WriteLine(i);
            }
            Program.Space();
        }


        private static void SequenceWithFilter(){
            Console.WriteLine("Sequence of integers from 10 to 40:");
            IEnumerable<int> EvenNumbers = Enumerable.Range(10, 30).Where(x => x%2 == 0);
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }
            Program.Space();
        }


        private static void SequenceAndSquareOfEach(){
            Console.WriteLine("Sequence of integers from 1 to 5 and the square of each number:");
            IEnumerable<int> EvenNumbers = Enumerable.Range(1, 5).Select(x => x*x);
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }
            Program.Space();
        }


        private static void StringSequence(){
            Console.WriteLine("Sequence of string with merging:");
            IEnumerable<string> rangewithString = Enumerable.Range(1, 5).Select(x => (x * x) + " " + CustomLogic(x)).ToArray();
            foreach (var item in rangewithString)
            {
                Console.WriteLine(item);
            }
            Program.Space();
        }

        private static string CustomLogic(int x)
        {
            string result = string.Empty;
            switch (x)
            {
                case 1:
                    result = "1st";
                    break;
                case 2:
                    result = "2nd";
                    break;
                case 3:
                    result = "3rd";
                    break;
                case 4:
                    result = "4th";
                    break;
                case 5:
                    result = "5th";
                    break;
            }
            return result;
        }
        
    }

}