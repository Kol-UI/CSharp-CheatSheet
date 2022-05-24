using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexMatching
    {
        public static void RegexMatchingMethod(){
            Program.Space();
            Console.WriteLine("Which Matching ?\n1) Default Regex Matching\n2) Greedy Matching\n3) Static Regex Matching");
            var regMatchingInput = Console.ReadLine();
            int valueMatchingInput = int.Parse(regMatchingInput);
            switch (valueMatchingInput)
            {
                case 1: // Default Regex Matching
                    DefaultRegexMatching();
                    break;
                case 2: // Greedy Matching
                    GreedyMatchingAlgo();
                    break;
                case 3: // Static Regex Matching
                    StaticRegexMatching();
                    break;
                case 4: // 
                    break;
                case 5: // 
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

        

    }

}