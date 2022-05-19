using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ToListOperator
    {
        public static void LINQToListMethod(){
            IList<string> strList = new List<string>() { 
                "One", 
                "Two", 
                "Three", 
                "Four", 
                "Three" 
            };

            Console.WriteLine("strList type: {0}", strList.GetType().Name);
            
            string[] strArray = strList.ToArray<string>();// converts List to Array

            Console.WriteLine("strArray type: {0}", strArray.GetType().Name);
            
            IList<string> newList = strArray.ToList<string>(); // converts array into list
            
            Console.WriteLine("newList type: {0}", newList.GetType().Name);
            
        }
        
    }

}