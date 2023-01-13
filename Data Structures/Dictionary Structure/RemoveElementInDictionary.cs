using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class RemoveElementInDictionary
	{
        public static Dictionary<string, string> RemoveInDic(Dictionary<string, string> cities)
        {
            Console.WriteLine("\nRemoving UK...");
            if (cities.ContainsKey("UK"))
            {
                cities.Remove("UK");
            }
            Console.WriteLine("After Removing:");
            Console.WriteLine("Total Elements: {0}", cities.Count);
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(cities);

            return cities;
        }
    }
}

