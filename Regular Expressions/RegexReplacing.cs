using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexReplacing
    {
        public static void RegexReplacingMethod(){
            Program.Space();
            Console.WriteLine("Which Replacing ?\n1) International Phone Number\n2) Replacing Spacing\n3) Replacing for Visualization\n4) Replacing Words\n5) Replacing Duplicates");
            var regReplacingInput = Console.ReadLine();
            int valueReplacingInput = int.Parse(regReplacingInput);
            switch (valueReplacingInput)
            {
                case 1: // International Phone Number
                    ReplacingPhoneNumber();
                    break;
                case 2: // Replacing Spacing
                    ReplacingSpacing();
                    break;
                case 3: // Replacing for Visualization
                    ReplacingForVisualization();
                    break;
                case 4: // Replacing Words
                    RegexExample1();
                    Program.Space();
                    RegexExample2();
                    break;
                case 5: // Duplicate
                    ReplacingDuplicates();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }


        }

        public static void RegexExample1(){
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(name);
            Console.WriteLine("-- Regex : 'Mr\\.? |Mrs\\.? |Miss |Ms\\.?' --");
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
        }

        public static void RegexExample2(){
            Regex regex = new Regex(@"\d+");
            string result = regex.Replace("cat 123 456", "bird");
            Console.WriteLine("RESULT: {0}", result);
        }

        public static void ReplacingPhoneNumber(){
            //   \b    -> word boundary, match the beginning of a word
            //   0     -> match a 0
            //   \d{9} -> match 9 other digits
            var regularExpression = new Regex(@"\b(0)(\d{9})");

            var phoneNumbers = "0161172890 0457823941 0390562351 0780665420 0601598210 0954137542";

            var internationalPhoneNumbers = regularExpression.Replace(phoneNumbers, "+33$2");

            Console.WriteLine($"Phone numbers: {phoneNumbers}");
            Console.WriteLine($"Phone numbers (International): {internationalPhoneNumbers}");
            Program.Space();
        }

        public static void ReplacingSpacing(){
            // This pattern will match multiple spaces
            var regularExpression = new Regex(@"\s+");
            var textWithManySpaces = "this     is    a   text    with   spaces";
            var correctText = regularExpression.Replace(textWithManySpaces, " ");

            Console.WriteLine($"Text with many spaces: {textWithManySpaces}");
            Console.WriteLine($"Corrected text: {correctText}");
        }

        public static void ReplacingForVisualization(){
            var regularExpression2 = new Regex(@"(?<firstname>\w+),(?<lastname>\w+),(?<level>\w+),(?<birthdate>\d{2}/\d{2}/\d{4}),(?<state>\w+)");
            var userData =  "John,Doe,Manager,14/01/1982,Arizona\n" + "Jane,Nobody,Analyst,13/12/1986,Colorado\n" + "Carole,Unknown,Consultant,01/07/1983,Arkansas\n";
            var correctText2 = regularExpression2.Replace(userData, "${firstname} ${lastname}, living in ${state}, born on ${birthdate}, is a(n) ${level}");
            Console.WriteLine($"Source data: {userData}");
            Console.WriteLine($"Replaced text: {correctText2}");
        }

        public static void ReplacingDuplicates()
        {
            string pattern = @"\b(\w+?)\s\1\b";
            string input = "This this is a nice day. What about this? This tastes good. I saw a a dog.";
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine("{0} (duplicates '{1}') at position {2}",
                                match.Value, match.Groups[1].Value, match.Index);
        }

    }

}