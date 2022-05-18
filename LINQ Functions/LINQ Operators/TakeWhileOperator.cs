using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class TakeWhileOperator
    {
        public static void LINQTakeWhileMethod(){

            Console.WriteLine("\t --- Differences between TakeWhile & Where ---");


            var intList = new int[] { 1, 2, 3, 4, 5, -1, -2 };
            
            Console.WriteLine("TakeWhile\nStops when condition is false");
            foreach (var i in intList.TakeWhile(x => x <= 3))
                Console.WriteLine(i);

            Console.WriteLine("Where\nContinues and find all elements matching the condition");
            foreach (var i in intList.Where(x => x <= 3))
                Console.WriteLine(i);
            

        }
        
    }

}