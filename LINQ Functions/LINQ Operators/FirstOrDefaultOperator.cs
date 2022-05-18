using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class FirstOrDefaultOperator
    {
        public static void LINQFirstOrDefaultMethod(){
            int[] numbers = { };
            int first = numbers.FirstOrDefault();
            Console.WriteLine(first);
        }
        
    }

}