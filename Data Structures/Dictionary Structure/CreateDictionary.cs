using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.DataStructures.DictionaryStructure
{
	public class CreateDictionary
	{
		public static void CreateDictionaryMain()
		{
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham"},
                {"USA","Chicago, New York, Washington"},
                {"India","Mumbai, New Delhi, Pune"}
            };
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(cities);
        }

		public static void CreateDictionaryForAdd()
        {
            Dictionary<int, string> numberNames = new()
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
            };
            Console.WriteLine("Before Adding:");
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicIntPlusString(numberNames);
            DataStructures.DictionaryStructure.AddInDictionary.AddingValues(numberNames);
            Console.WriteLine("After Adding:");
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicIntPlusString(numberNames);
        }

        public static void CreateDictionaryForAccessElement()
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham"},
                {"USA","Chicago, New York, Washington"},
                {"India","Mumbai, New Delhi, Pune"},
                {"Spain","Madrid, Barcelona, Valencia"}
            };
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(cities);
            DataStructures.DictionaryStructure.AccessElementsInDictionary.AccessDicStringPlusString(cities);
        }

        public static void CreateDictionaryForUpdate()
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham"},
                {"USA","Chicago, New York, Washington"},
                {"India","Mumbai, New Delhi, Pune"},
                {"Russia","Moscow, Saint-Petersbourg"}
            };
            Console.WriteLine("Before Update:");
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(cities);
            DataStructures.DictionaryStructure.UpdatingDictionary.UpdateDic(cities);
        }

        public static void CreateDictionaryForRemove()
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham, Liverpool, Bristol"},
                {"USA","Chicago, New York, Washington, Los Angeles, Boston"},
                {"India","Mumbai, New Delhi, Pune"},
                {"Russia","Moscow, Saint-Petersbourg"},
                {"Spain","Madrid, Barcelona, Valencia"},
                {"France","Paris, Marseille, Lyon"}
            };
            Console.WriteLine("Before Remove:");
            Console.WriteLine("Total Elements: {0}", cities.Count);
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(cities);
            DataStructures.DictionaryStructure.RemoveElementInDictionary.RemoveInDic(cities);
        }

        public static void CreateDictionaryForClear()
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham, Liverpool, Bristol"},
                {"USA","Chicago, New York, Washington, Los Angeles, Boston"},
                {"India","Mumbai, New Delhi, Pune"},
                {"Russia","Moscow, Saint-Petersbourg"},
                {"Spain","Madrid, Barcelona, Valencia"},
                {"France","Paris, Marseille, Lyon"},
                {"Italy","Rome, Naples, Milan, Turin"},
            };
            Console.WriteLine("Before Clear:");
            Console.WriteLine("Total Elements: {0}", cities.Count);
            DataStructures.DictionaryStructure.PrintDictionary.PrintDicStringPlusString(cities);
            DataStructures.DictionaryStructure.ClearDictionary.DictionaryToClear(cities);
            Console.WriteLine("After Clear:");
            Console.WriteLine("Total Elements: {0}", cities.Count);
        }
    }
}

