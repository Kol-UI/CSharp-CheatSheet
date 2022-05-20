using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexGroups
    {
        public static void RegexGroupsMethod(){
            Program.Space();
            
            Console.WriteLine("-- Regex : (banana|ananas|apple) --");
            // This pattern will match any string containing banana, ananas or apple
            var regularExpression = new Regex("(banana|ananas|apple)");

            Console.WriteLine($"IsMatch 'I love fruits, my favorite is ananas': {regularExpression.IsMatch("I love fruits, my favorite is ananas")}");
            Console.WriteLine($"IsMatch 'I ate an apple this morning': {regularExpression.IsMatch("I ate an apple this morning")}");
            Console.WriteLine($"IsMatch 'My favorite ice cream flavor is strawberry': {regularExpression.IsMatch("My favorite ice cream flavor is strawberry")}");
            Program.Space();

            Console.WriteLine("-- Regex : (abc|def|ghi){3} --");
            // This pattern will match any string that contains 3 occurence of either abc, def or ghi
            var regularExpression2 = new Regex("(abc|def|ghi){3}");

            Console.WriteLine($"IsMatch 'abcabcabc': {regularExpression2.IsMatch("abcabcabc")}");
            Console.WriteLine($"IsMatch 'abcdefghi': {regularExpression2.IsMatch("abcdefghi")}");
            Console.WriteLine($"IsMatch 'abcghi': {regularExpression2.IsMatch("abcghi")}");

        }

        
    }

}