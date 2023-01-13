using System;
namespace CSharp_CheatSheet.Menus.DataStructuresMenu
{
	public class DataStructuresMenu
	{
		public static void MainMenuDataStructures()
		{
            Program.Space();
            Console.WriteLine("Which Data Structure ?\n1) Dictionary ");
            var DataStructureInput = Console.ReadLine();
            int valueDataStructureInput = int.Parse(DataStructureInput);
            switch (valueDataStructureInput)
            {
                case 1: // Dictionary
                    DataStructures.DictionaryStructure.MainDictionary.MainDictionaryFunc();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
	}
}

