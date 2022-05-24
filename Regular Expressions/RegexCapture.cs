using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexCapture
    {
        public static void MainRegexCapture(){
            string input = "Yes. This dog is very friendly.";
            string pattern = @"((\w+)[\s.])+";

            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine("Match: {0}", match.Value);
                for (int groupCtr = 0; groupCtr < match.Groups.Count; groupCtr++)
                {
                    Group group = match.Groups[groupCtr];
                    Console.WriteLine("   Group {0}: {1}", groupCtr, group.Value);
                    for (int captureCtr = 0; captureCtr < group.Captures.Count; captureCtr++)
                    Console.WriteLine("      Capture {0}: {1}", captureCtr, group.Captures[captureCtr].Value);
                }                      
            }
        }
        
    }

}