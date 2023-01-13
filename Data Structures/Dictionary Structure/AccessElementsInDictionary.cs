using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class AccessElementsInDictionary
	{
        public static void AccessDicStringPlusString(Dictionary<string, string> AccessDic)
        {
            Console.WriteLine("Check for UK");
            Console.WriteLine(AccessDic["UK"]);
            Console.WriteLine("Check for USA");
            Console.WriteLine(AccessDic["USA"]);

            Console.WriteLine("Check for France");
            if (AccessDic.ContainsKey("France"))
            {
                Console.WriteLine(AccessDic["France"]);
            }
            else
            {
                Console.WriteLine("France does not exist");
            }

            Console.WriteLine("Check for input, Enter a Country Name");
            string input = Console.ReadLine();
            if (AccessDic.ContainsKey(input))
            {
                Console.WriteLine(AccessDic[input]);
            }
            else
            {
                Console.WriteLine("{0} does not exist", input);
            }
        }
    }
}

