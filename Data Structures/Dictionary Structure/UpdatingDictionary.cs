using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class UpdatingDictionary
	{
        public static Dictionary<string, string> UpdateDic(Dictionary<string, string> UpdatedDic)
        {
            Console.WriteLine("Update value of UK key, Adding values");
            UpdatedDic["UK"] += "Liverpool, Bristol";
            Console.WriteLine("After Updating:");
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(UpdatedDic);

            Console.WriteLine("Update value of USA key, Erasing old values");
            UpdatedDic["USA"] = "Los Angeles, Boston";
            Console.WriteLine("After Update:");
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(UpdatedDic);

            return UpdatedDic;
        }
    }
}

