using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class RegexOptionsList
    {
        public static void MainOptionsList(){
            Program.Space();
            Console.WriteLine("--- Ignore Case ---");
            const string value = "TEST";
            // Ignore Case of TE
            if (Regex.IsMatch(value, "te..", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }

            Program.Space();
            Console.WriteLine("--- Ignore White Space ---");
            string pattern = @"d \w+ \s";
            string input = "Dogs are decidedly good pets.";
            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;

            foreach (Match match in Regex.Matches(input, pattern, options))
            Console.WriteLine("'{0}// found at index {1}.", match.Value, match.Index);

            MatchingCaseOption();
            MultilineModOption();
            SinglelineOption();
        }

        public static void MatchingCaseOption(){
            Program.Space();
            Console.WriteLine("--- Match Ignore Case Option ---");
            string pattern = @"\bthe\w*\b";
            string input = "The man then told them about that event.";

            Console.WriteLine("'" + input + "'");
            Console.WriteLine("Without IgnoreCase");
            foreach (Match match in Regex.Matches(input, pattern))
                Console.WriteLine("Found {0} at index {1}.", match.Value, match.Index);

            Console.WriteLine();
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine("Found {0} at index {1}.", match.Value, match.Index);
        }

        public static void MultilineModOption(){
            Program.Space();
            Console.WriteLine("--- Multiple Line Option ---");
            SortedList<int, string> scores = new SortedList<int, string>(new DescendingComparer<int>());

            string input = "Joe 164\n" +
                            "Sam 208\n" +
                            "Allison 211\n" +
                            "Gwen 171\n";
            string pattern = @"^(\w+)\s(\d+)$";
            bool matched = false;
            Console.WriteLine("'" + input + "'");

            Console.WriteLine("Without Multiline option:");
            foreach (Match match in Regex.Matches(input, pattern))
            {
                scores.Add(Int32.Parse(match.Groups[2].Value), (string) match.Groups[1].Value);
                matched = true;
            }
            if (! matched)
                Console.WriteLine("   No matches.");
            Console.WriteLine();

            // Redefine pattern to handle multiple lines.
            pattern = @"^(\w+)\s(\d+)\r*$";
            Console.WriteLine("With multiline option:");
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.Multiline))
                scores.Add(Int32.Parse(match.Groups[2].Value), (string) match.Groups[1].Value);

            // List scores in descending order.
            foreach (KeyValuePair<int, string> score in scores)
                Console.WriteLine("{0}: {1}", score.Value, score.Key);
        }

        public static void SinglelineOption(){
            Program.Space();
            Console.WriteLine("--- Single Line Option ---");
            Console.WriteLine("Forcing input to be on one line.");
            string pattern = "^.+";
            string input = "This is one line and" + Environment.NewLine + "this is the second.";
            foreach (Match match in Regex.Matches(input, pattern))
                Console.WriteLine(Regex.Escape(match.Value));

            Console.WriteLine();
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.Singleline))
                Console.WriteLine(Regex.Escape(match.Value));
        }
        
    }

    public class DescendingComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            return Comparer<T>.Default.Compare(x, y) * -1;
        }
    }

}