using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LastOperator
    {
        public static void LINQLastOperatorFunction(){
            Console.WriteLine("Last: Returns the last element from a collection, or the last element that satisfies a condition. Throws exception if no element found.");
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
                    
            Console.WriteLine("Last Element in intList: {0}", intList.Last());
            Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));
            Console.WriteLine("Last Element in strList: {0}", strList.Last());
        }
        
    }

}