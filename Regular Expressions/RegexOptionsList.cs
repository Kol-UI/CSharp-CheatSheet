using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics;

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

            IgnorePatternWhiteSpaceMethod();
            MatchingCaseOption();
            MultilineModOption();
            SinglelineOption();
            ImplicitExplicitCaptures();
            CompilatedOption();
            RightToLeftOption();
            ECMAScriptOption();
            
        }

        private static void IgnorePatternWhiteSpaceMethod()
        {
            Program.Space();
            Console.WriteLine("--- Ignore White Space ---");
            string pattern = @"d \w+ \s";
            string input = "Dogs are decidedly good pets.";
            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;

            foreach (Match match in Regex.Matches(input, pattern, options))
            Console.WriteLine("'{0}' || found at index {1}.", match.Value, match.Index);

        }

        private static void MatchingCaseOption(){
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

        private static void MultilineModOption(){
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
            Console.WriteLine("With Multiline option:");
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.Multiline))
                scores.Add(Int32.Parse(match.Groups[2].Value), (string) match.Groups[1].Value);

            // List scores in descending order.
            foreach (KeyValuePair<int, string> score in scores)
                Console.WriteLine("{0}: {1}", score.Value, score.Key);
        }

        private static void SinglelineOption(){
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

        private static void ImplicitExplicitCaptures(){
            Program.Space();
            Console.WriteLine("--- Implicit Captures ---");
            string input = "This is the first sentence. Is it the beginning " +
                            "of a literary masterpiece? I think not. Instead, " +
                            "it is a nonsensical paragraph.";
            string pattern = @"\b\(?((?>\w+),?\s?)+[\.!?]\)?";
            Console.WriteLine("With implicit captures:");
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine("The match: {0}", match.Value);
                int groupCtr = 0;
                foreach (Group group in match.Groups)
                {
                    Console.WriteLine("   Group {0}: {1}", groupCtr, group.Value);
                    groupCtr++;
                    int captureCtr = 0;
                    foreach (Capture capture in group.Captures)
                    {
                    Console.WriteLine("      Capture {0}: {1}", captureCtr, capture.Value);
                    captureCtr++;
                    }
                }
            }
            Program.Space();
            Console.WriteLine("--- Explicit Captures ---");
            Console.WriteLine("With explicit captures only:");
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.ExplicitCapture))
            {
                Console.WriteLine("The match: {0}", match.Value);
                int groupCtr = 0;
                foreach (Group group in match.Groups)
                {
                    Console.WriteLine("   Group {0}: {1}", groupCtr, group.Value);
                    groupCtr++;
                    int captureCtr = 0;
                    foreach (Capture capture in group.Captures)
                    {
                    Console.WriteLine("      Capture {0}: {1}", captureCtr, capture.Value);
                    captureCtr++;
                    }
                }
            }
        }

        private static void CompilatedOption()
        {
            const int forMax = 1000000;
            Program.Space();
            Console.WriteLine("--- Compilated Option ---");
            string value = "This option often improves performance with C# Regex code. With it, regular expressions are executed faster.";
            Console.WriteLine(value);

            // Without RegexOptions.Compiled
            
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < forMax; i++)
            {
                Match match = Regex.Match(value, @"\d+");
            }
            s1.Stop();

            // With RegexOptions.Compiled
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < forMax; i++)
            {
                Match match = Regex.Match(value, @"\d+", RegexOptions.Compiled);
            }
            s2.Stop();

            Console.WriteLine("Without RegexOptions.Compiled :");
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / forMax).ToString("0.00 ns"));
            Console.WriteLine("With RegexOptions.Compiled :");
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / forMax).ToString("0.00 ns"));
        }

        private static void RightToLeftOption()
        {
            Program.Space();
            Console.WriteLine("--- Right to Left Option ---");
            string pattern = @"\bb\w+\s";
            string input = "builder rob rabble, Bob is showing up while Pierre being at home.";
            foreach (Match match in Regex.Matches(input, pattern, RegexOptions.RightToLeft | RegexOptions.IgnoreCase))
                Console.WriteLine("'{0}' found at position {1}.", match.Value, match.Index);

            Console.WriteLine("\nIf a date is preceding a month:");
            string[] inputDates = { "1 May 1917", "June 16, 2003" , "23 March 1998" , "14 December 1085" , "24 January 2022"};
            string patternDates = @"(?<=\d{1,2}\s)\w+,?\s\d{4}";

            foreach (string dateInput in inputDates)
            {
                Match match = Regex.Match(dateInput, patternDates, RegexOptions.RightToLeft);
                if (match.Success)
                    Console.WriteLine("The date occurs in {0}.", match.Value);
                else
                    Console.WriteLine("{0} does not match.", dateInput);
            }
        }

        private static void ECMAScriptOption()
        {
            Program.Space();
            Console.WriteLine("--- ECMAScript Option ---");
            string[] values = { "целый мир", "the whole world", "th3 wh0l3 w0rld", "le monde entier" };
            string pattern = @"\b(\w+\s*)+";
            foreach (var value in values)
            {
                Console.Write("Canonical matching: ");
                if (Regex.IsMatch(value, pattern))
                    Console.WriteLine("'{0}' matches the pattern.", value);
                else
                    Console.WriteLine("{0} does not match the pattern.", value);

                Console.Write("ECMAScript matching: ");
                if (Regex.IsMatch(value, pattern, RegexOptions.ECMAScript))
                    Console.WriteLine("'{0}' matches the pattern.", value);
                else
                    Console.WriteLine("{0} does not match the pattern.", value);
                Console.WriteLine();
            }
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