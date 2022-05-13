using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class FirstOperator
    {
        public static void LINQFirstFunction(){
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
                    
            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));
            
            Console.WriteLine("1st Element in strList: {0}", strList.First());

        }
        
    }

}