using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class AddInDictionary
	{
        public static Dictionary<int, string> AddingValues(Dictionary<int, string> numberNames)
        {
            int value1 = IntToAdd();
            string value2 = StringToAdd();
            numberNames.Add(value1, value2);
            return numberNames;
        }

        private static int IntToAdd()
        {
            int toAdd;
            Console.WriteLine("Enter an Int to Add (Key):");
            string? input = Console.ReadLine();
            while (!int.TryParse(input, out toAdd)) ;
            return toAdd;
        }

        private static string StringToAdd()
        {
            Console.WriteLine("Enter a String to Add (Value):");
            string? input = Console.ReadLine();
            if (input == null)
            {
                input = " ";
            }
            string toAdd = input.ToString();
            return toAdd;
        }
    }
}

