using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexMatching
    {
        public static void RegexMatchingMethod(){
            Program.Space();
            Console.WriteLine("Which Matching ?\n1) Default Regex Matching\n2) Simple Use\n3) Greedy Matching\n4) Static Regex Matching\n5) Match Method\n6) Match Numbers\n7) IsMatch Method");
            var regMatchingInput = Console.ReadLine();
            int valueMatchingInput = int.Parse(regMatchingInput);
            switch (valueMatchingInput)
            {
                case 1: // Default Regex Matching
                    DefaultRegexMatching();
                    break;
                case 2: // Simple Use
                    SimpleUseofMatch();
                    break;
                case 3: // Greedy Matching
                    GreedyMatchingAlgo();
                    break;
                case 4: // Static Regex Matching
                    StaticRegexMatching();
                    break;
                case 5: // Match Method
                    MatchMethod();
                    MatchFirstWordContaining();
                    MatchStartingWith();
                    break;
                case 6: // Match Numbers
                    MatchNumbers();
                    break;
                case 7: // IsMatch Method
                    IsMatchMethod();
                    IsMatchPartNumbers();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void DefaultRegexMatching(){
            string test = "/bird/cat/";
            // Version 2: default Regex.
            var result2 = Regex.Match(test, "^/.*/");
            if (result2.Success)
            {
                Console.WriteLine("GREEDY:     {0}", result2.Value);
            }
        }

        private static void SimpleUseofMatch()
        {
            string letters = "lpbtecqiajeqfbdsjksdwofkxrhlwnfgpxdpsnvgneedletgroqsuaeinqfjcdvtewddnnibzneedlezloyxtaetnxia";
            Regex needleRegex = new Regex(@"needle");
            Match needleMatch = needleRegex.Match(letters);
            if(needleMatch.Success)
            {
                Console.WriteLine($"Simple Use:");
                while (needleMatch.Success)
                {
                    Console.WriteLine($"Word '{needleMatch.Value}' found at position {needleMatch.Index}.");
                    needleMatch = needleMatch.NextMatch();
                }
            }
        }

        private static void GreedyMatchingAlgo(){
            string test = "/bird/cat/";
            // Version 1: use lazy (or non-greedy) metacharacter.
            var result1 = Regex.Match(test, "^/.*?/");
            if (result1.Success)
            {
                Console.WriteLine("NON-GREEDY: {0}", result1.Value);
            }
            
        }

        private static void StaticRegexMatching(){
            string input = "/content/RegexMatching-1.cs";
            // This calls the static method specified.
            Console.WriteLine(RegexUtil.MatchKey(input));
        }

        private static void MatchNumbers(){
            string input = "C# Project 100";
            Match match = Regex.Match(input, @"\d+");
            if (match.Success)
            {
                int.TryParse(match.Value, out int number);
                // Show that we have the numbers.
                Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            }
        }

        private static void MatchMethod(){
            string text = "One car red car blue car";
            string pat = @"(\w+)\s+(car)";

            // Instantiate the regular expression object.
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);
            Program.Space();
            Console.WriteLine("--- " + text + " ---");

            // Match the regular expression pattern against a text string.
            Match m = r.Match(text);
            int matchCount = 0;
            while (m.Success)
            {
                Program.Space();
                Console.WriteLine("- Match" + (++matchCount) + " -");
                for (int i = 1; i <= 2; i++)
                {
                    Group g = m.Groups[i];
                    Console.WriteLine("Group " + i + " = '" + g + "'");
                    CaptureCollection cc = g.Captures;
                    for (int j = 0; j < cc.Count; j++)
                    {
                    Capture c = cc[j];
                    Console.WriteLine("Capture " + j + " = '" + c + "', Position = "+c.Index);
                    }
                }
                m = m.NextMatch();
            }
        }

        private static void MatchFirstWordContaining(){
            Program.Space();
            Console.WriteLine("--- Words containing letter 'z' ---");
            string input = "ablaze beagle choral dozen elementary fanatic " +
                            "glaze hunger inept jazz kitchen lemon minus " +
                            "night optical pizza quiz restoration stamina " +
                            "train unrest vertical whiz xray yellow zealous";
            string pattern = @"\b\w*z+\w*\b";
            Match m = Regex.Match(input, pattern);
            while (m.Success) {
                Console.WriteLine("'{0}' found at position {1}", m.Value, m.Index);
                m = m.NextMatch();
            } 
        }

        private static void MatchStartingWith()
        {
            Program.Space();
            Console.WriteLine("--- Find Word Starting with letter 'a' ---");
            string pattern = @"\ba\w*\b";
            string input = "An extraordinary day dawns with each new day.";
            Console.WriteLine(input);
            Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            if (m.Success)
                Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);
        }

        static bool IsValid(string value){
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
        }

        private static void IsMatchMethod(){
            Console.WriteLine(IsValid("csharp0123"));
            Console.WriteLine(IsValid("C# Project"));
            Console.WriteLine(IsValid("Main Project"));
            Console.WriteLine(IsValid("C#"));
            Console.WriteLine(IsValid(":-)"));
            Console.WriteLine(IsValid("username"));
            Console.WriteLine(IsValid("12345"));
            Program.Space();
        }

        private static void IsMatchPartNumbers(){
            string[] partNumbers= { "1298-673-4192", "A08Z-931-468a", "_A90-123-129X", "12345-KKA-1230", "0919-2893-1256" };
            string pattern = @"^[A-Z0-9]\d{2}[A-Z0-9](-\d{3}){2}[A-Z0-9]$";
            foreach (string partNumber in partNumbers)
                try {
                    Console.WriteLine("{0} {1} a valid part number.", partNumber, 
                                    Regex.IsMatch(partNumber, pattern, RegexOptions.IgnoreCase) 
                                    ? "is" : "is not", TimeSpan.FromMilliseconds(500));
                }
                catch (RegexMatchTimeoutException e) {
                    Console.WriteLine("Timeout after {0} seconds matching {1}.", e.MatchTimeout, e.Input);
                }
        }

        

    }

}