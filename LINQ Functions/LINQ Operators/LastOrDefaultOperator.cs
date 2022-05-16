using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LastOrDefaultOperator
    {
        public static void LINQLastOrDefaultFunction(){
            Console.WriteLine("Returns the last element from a collection, or the last element that satisfies a condition. Returns a default value if no element found.");
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
            IList<string> strList2 = new List<string>() {"Two", "Three", "Four", "Five"};
            IList<string> strList3 = new List<string>() {null, "Two", "Three", "Four", "Five"};
            int[] objList = { 1, 2, 3, 4, 5 };
            int[] objVals = { };
            int result = objList.LastOrDefault();
            int val = objVals.LastOrDefault();
            
            Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());
            Console.WriteLine("Last Even Element in intList: {0}", intList.LastOrDefault(i => i % 2 == 0));
            Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());
            Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault());
            Console.WriteLine(strList2.LastOrDefault(s => s.Contains("T")));
            Console.WriteLine(strList3.LastOrDefault(s => s.Contains("T")));
            Console.WriteLine("Elements from the List (numbers): {0}", result);
            Console.WriteLine("Elements from the List (empty): {0}", val);
            
            // Query Syntaxe
            int resultQuery = (from l in objList select l).LastOrDefault();
            int valQuery = (from x in objVals select x).LastOrDefault();
            Console.WriteLine("Elements from the List (numbers/query): {0}", resultQuery);
            Console.WriteLine("Elements from the List (empty/query) : {0}", valQuery);
            Console.ReadLine();
            
        }
        
    }

}