using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class RepeatOperator
    {
        public static void LINQRepeatFunction(){
            IEnumerable<string> strings = Enumerable.Repeat("Repeating...", 3);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
  
        }

        
    }

}