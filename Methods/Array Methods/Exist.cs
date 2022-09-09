using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Exist
    {
        public static void ExistMain()
        {
            Program.Title("Exist");
            Program.Space();
            Console.WriteLine("Example 1:");
            Example1();
            Program.Space();
            Console.WriteLine("Example 2:");
            Example2();
            Program.Space();
        }

        private static void Example1()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            Console.WriteLine("One or more planets begin with 'M': {0}",
                Array.Exists(planets, element => element.StartsWith("M")));

            Console.WriteLine("One or more planets begin with 'T': {0}",
                Array.Exists(planets, element => element.StartsWith("T")));

            Console.WriteLine("Is Pluto one of the planets? {0}",
                Array.Exists(planets, element => element == "Pluto"));
        }

        private static void Example2()
        {
            String[] names = { "Adam", "Adel", "Bridgette", "Carla",
                         "Charles", "Daniel", "Elaine", "Frances",
                         "George", "Gillian", "Henry", "Irving",
                         "James", "Janae", "Lawrence", "Miguel",
                         "Nicole", "Oliver", "Paula", "Robert",
                         "Stephen", "Thomas", "Vanessa",
                         "Veronica", "Wilberforce" };
            Char[] charsToFind = { 'A', 'K', 'W', 'Z' };
            Console.WriteLine("Using StartsWith:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("- {0} ", names[i]);
            }
            Program.Space();
            foreach (char charToFind in charsToFind)
            {
                Console.WriteLine("One or more names begin with '{0}': {1}", charToFind, Array.Exists(names, (new StringSearcher(charToFind)).StartsWith));
            }

            Program.Space();
            Console.WriteLine("Using Lambda:");
            foreach (var charToFind in charsToFind)
            {
                Console.WriteLine("One or more names begin with '{0}': {1}", charToFind,
                                  Array.Exists(names,
                                               s => {
                                                   if (string.IsNullOrEmpty(s))
                                                   {
                                                       return false;
                                                   }

                                                   if (s.Substring(0, 1).ToUpper() == charToFind.ToString())
                                                   {
                                                       return true;
                                                   }
                                                   else
                                                   {
                                                       return false;
                                                   }
                                               }));
            }
        }
    }

    public class StringSearcher
    {
        char firstChar;

        public StringSearcher(char firstChar)
        {
            this.firstChar = char.ToUpper(firstChar);
        }

        public bool StartsWith(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            if (s.Substring(0, 1).ToUpper() == firstChar.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
