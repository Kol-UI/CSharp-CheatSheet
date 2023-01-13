using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class ClearDictionary
	{
        public static Dictionary<string, string> DictionaryToClear(Dictionary<string, string> cities)
        {
            Console.WriteLine("Clearing...");
            cities.Clear();
            return cities;
        }
    }
}

