using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class PrintDictionary
	{
		public static void PrintDicIntPlusString(Dictionary<int, string> DicIntPlusString)
		{
            foreach (KeyValuePair<int, string> values in DicIntPlusString)
            {
                Console.WriteLine("- Key: {0}, Value: {1}", values.Key, values.Value);
            }
        }

        public static void PrintDicStringPlusString(Dictionary<string, string> DicStringPlusString)
        {
            foreach (KeyValuePair<string, string> values in DicStringPlusString)
            {
                Console.WriteLine("- Key: {0}, Value: {1}", values.Key, values.Value);
            }
        }
    }
}

