using System;
namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class MainDictionary
	{
		public static void MainDictionaryFunc()
		{
			// Create
			Program.Title("Create Dictionary");
			DataStructures.DictionaryStructure.CreateDictionary.CreateDictionaryMain();

            // Add In Dictionary
            Program.Title("Add In Dictionary");
            DataStructures.DictionaryStructure.CreateDictionary.CreateDictionaryForAdd();

            // Access Element In Dictionary
            Program.Title("Access Element In Dictionary");
            DataStructures.DictionaryStructure.CreateDictionary.CreateDictionaryForAccessElement();

            // Update An Element In Dictionary
            Program.Title("Update An Element In Dictionary");
            DataStructures.DictionaryStructure.CreateDictionary.CreateDictionaryForUpdate();

            // Remove An Element In Dictionary
            Program.Title("Remove An Element In Dictionary");
            DataStructures.DictionaryStructure.CreateDictionary.CreateDictionaryForRemove();

            // Clear Dictionary
            Program.Title("Clear A Dictionary");
            DataStructures.DictionaryStructure.CreateDictionary.CreateDictionaryForClear();
        }
    }
}

