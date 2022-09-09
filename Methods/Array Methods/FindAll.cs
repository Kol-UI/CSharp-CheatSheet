using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class FindAll
    {
        public static void FindAllMain()
        {
            Program.Title("FindAll");
            Example1();
            Program.Space();
            Example2();
            Program.Space();
            Example3();
            Program.Space();
        }

        private static void Example1()
        {
            Program.Title("Names Example");
            string[] names = { "Steve", "Bill", "Jack", "Bill Gates", "Arthur", "bill", "Ravi", "Pierre", "Salim", "Mohan", "Nikita", "Salman", "Manon", "Boski", "Jean" };
            Program.PrintArrayOneLine(names);
            var stringToFind = "bill";
            string[] result1 = Array.FindAll(names, element => element.ToLower() == stringToFind);
            Console.WriteLine("Find using var comparison :");
            Program.PrintArrayOneLine(result1);
            string[] result2 = Array.FindAll(names, element => element.StartsWith("B"));
            Console.WriteLine("Find using StartsWith :");
            Program.PrintArrayOneLine(result2);
            string[] result3 = Array.FindAll(names, element => element.Length >= 5);
            Console.WriteLine("Find using Lenght :");
            Program.PrintArrayOneLine(result3);
        }

        private static void Example2()
        {
            Program.Title("Random List Example");
            int[] values = GetArray(150, 0, 1000);
            int lBound = 900;
            int uBound = 1000;
            int[] matchedItems = Array.FindAll(values, x =>
                                             x >= lBound && x <= uBound);
            for (int ctr = 0; ctr < matchedItems.Length; ctr++)
            {
                Console.Write("{0}  ", matchedItems[ctr]);
                if ((ctr + 1) % 12 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        private static int[] GetArray(int n, int lower, int upper)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int ctr = 1; ctr <= n; ctr++)
            {
                list.Add(rnd.Next(lower, upper + 1));
            }

            return list.ToArray();
        }


        private static void Example3()
        {
            Program.Title("Dino Example");
            string[] dinosaurs =
            {
                "Compsognathus", "Amargasaurus", "Oviraptor",
                "Velociraptor",  "Deinonychus",  "Dilophosaurus",
                "Gallimimus",    "Triceratops"
            };

            FindAll GoMesozoic = new FindAll(dinosaurs);

            GoMesozoic.DiscoverAll();
            GoMesozoic.DiscoverByEnding("saurus");
        }

        private string[] dinosaurs;

        public FindAll(string[] items)
        {
            dinosaurs = items;
        }

        public void DiscoverAll()
        {
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }
        }

        public void DiscoverByEnding(string Ending)
        {
            Predicate<string> dinoType;

            switch (Ending.ToLower())
            {
                case "raptor":
                    dinoType = EndsWithRaptor;
                    break;
                case "tops":
                    dinoType = EndsWithTops;
                    break;
                case "saurus":
                default:
                    dinoType = EndsWithSaurus;
                    break;
            }
            Console.WriteLine(
                "\nArray.Exists(dinosaurs, \"{0}\"): {1}",
                Ending,
                Array.Exists(dinosaurs, dinoType));

            Console.WriteLine(
                "\nArray.TrueForAll(dinosaurs, \"{0}\"): {1}",
                Ending,
                Array.TrueForAll(dinosaurs, dinoType));

            Console.WriteLine(
                "\nArray.Find(dinosaurs, \"{0}\"): {1}",
                Ending,
                Array.Find(dinosaurs, dinoType));

            Console.WriteLine(
                "\nArray.FindLast(dinosaurs, \"{0}\"): {1}",
                Ending,
                Array.FindLast(dinosaurs, dinoType));

            Console.WriteLine(
                "\nArray.FindAll(dinosaurs, \"{0}\"):", Ending);

            string[] subArray =
                Array.FindAll(dinosaurs, dinoType);

            foreach (string dinosaur in subArray)
            {
                Console.WriteLine(dinosaur);
            }
        }

        private bool EndsWithSaurus(string s)
        {
            if ((s.Length > 5) &&
                (s.Substring(s.Length - 6).ToLower() == "saurus"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EndsWithRaptor(String s)
        {
            if ((s.Length > 5) &&
                (s.Substring(s.Length - 6).ToLower() == "raptor"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EndsWithTops(String s)
        {
            if ((s.Length > 3) &&
                (s.Substring(s.Length - 4).ToLower() == "tops"))
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
