using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQBasics
    {
        public static void BasicLINQ()
        {
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("\nBasic structure of LINQ : "); 
            Console.Write("\n---------------------------");
            // The second part is Query creation.
            // nQuery is an IEnumerable<int>
            var nQuery =
                from VrNum in n1
                where (VrNum % 2) == 0
                select VrNum;
            // The third part is Query execution.
            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
        }

        public static void BasicLINQOneLine()
        {
            Program.Space();
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            nums.Where(x => x % 2 == 0).ToList().ForEach(a => Console.Write(a + " "));
        }

        public static void BasicLINQOneLineTwo()
        {
            Program.Space();
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(n1.Where(x => x % 2 == 0).Aggregate("", (c, v) => $"{c} {v}"));
        }

        public static void FindPositive()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : "); 
            Console.Write("\n---------------");
            var nQuery = from VrNum in n1 where VrNum > 0 where VrNum < 11 select VrNum;  
            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");			
            foreach(var VrNum in nQuery)
            {
               Console.Write("{0}  ", VrNum);
            }

            List<int> numbers = new List<int>();
            for (int i=-10; i<= 20; i++){
                numbers.Add(i);
            }
            //Part 2: Query creation
            var numQuery = from numAnswer in numbers
            where numAnswer >= 0
            select numAnswer;
            //Part 3: Query Execution
            foreach (int numAnswer in numQuery){
                Console.WriteLine(numAnswer);
            }
        }

        public static void LINQCalculations(){
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : "); 
            Console.Write("\n------------------------------------------------------------------------\n");	
            var sqNo = from int Number in arr1
                            let SqrNo = Number * Number
                            where SqrNo > 20
                            select new { Number, SqrNo };
            foreach (var a in sqNo)
                Console.WriteLine(a);
        }

        public static void FrequencyFunction(){
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };  
            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n"); 
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("The numbers in the array are : \n");
            // Print a array in 1 line
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            var n = from x in arr1  
                    group x by x into y  
                    select y;  
                    Console.WriteLine("\nThe number and the Frequency are : \n"); 
                    foreach (var arrNo in n){  
                        Console.WriteLine("Number "+arrNo.Key + " appears " + arrNo.Count()+" time(s)");  
                    }

            // Other way
            Console.Write("\nOther way :\n");
            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
            var z = arr2.GroupBy(n=> n).Select(p=>new{MainKey=p.Key,MainCount=p.Count()});
            foreach(var item in z){
                Console.WriteLine("Number {0} appears {1} time(s)",item.MainKey,item.MainCount);
            }
        }
    }

}