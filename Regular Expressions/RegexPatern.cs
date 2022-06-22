using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexPattern
    {
        public static void RegexPatternMethod(){
            Program.Space();
            // This pattern will match any string containing a 'ab' substring
            var regularExpression = new Regex("ab");
            Console.WriteLine("-- Regex : ab --");
            Console.WriteLine($"IsMatch 'abc': {regularExpression.IsMatch("abc")}");
            Console.WriteLine($"IsMatch 'aze': {regularExpression.IsMatch("aze")}");
            Console.WriteLine($"IsMatch 'bab': {regularExpression.IsMatch("bab")}");
            Program.Space();

            var regularExpression2 = new Regex("b[aeiou]c");
            Console.WriteLine("-- Regex : b[aeiou]c --");
            Console.WriteLine($"IsMatch 'bac': {regularExpression2.IsMatch("bac")}");
            Console.WriteLine($"IsMatch 'bbc': {regularExpression2.IsMatch("bbc")}");
            Console.WriteLine($"IsMatch 'bec': {regularExpression2.IsMatch("bec")}");
            Program.Space();

            //   b? -> 0 or 1 appearance of 'b'
            //   a{2,5} -> between 2 and 5 appearance of 'a'
            //   .* -> 0 or more appearance of any character
            var regularExpression3 = new Regex("b?a{2,5}.*");
            Console.WriteLine("-- Regex : b?a{2,5}.* --");
            Console.WriteLine("b? -> 0 or 1 appearance of 'b'\na{2,5} -> between 2 and 5 appearance of 'a'\n.* -> 0 or more appearance of any character");

            Console.WriteLine($"IsMatch 'baaac': {regularExpression3.IsMatch("baaac")}");
            Console.WriteLine($"IsMatch 'abc': {regularExpression3.IsMatch("abc")}");
            Console.WriteLine($"IsMatch 'aaaaart': {regularExpression3.IsMatch("aaaaart")}");
            Console.WriteLine($"IsMatch 'bbbaaaaaty': {regularExpression3.IsMatch("bbbaaaaaty")}");
            Program.Space();

            // This pattern will match all text that starts with 'he'
            var regularExpression4 = new Regex("^he");
            Console.WriteLine("-- Regex : ^he --");

            Console.WriteLine($"IsMatch 'hello': {regularExpression4.IsMatch("hello")}");
            Console.WriteLine($"IsMatch 'chemical': {regularExpression4.IsMatch("chemical")}");
            Console.WriteLine($"IsMatch 'he left': {regularExpression4.IsMatch("he left")}");

        }

        
    }

}