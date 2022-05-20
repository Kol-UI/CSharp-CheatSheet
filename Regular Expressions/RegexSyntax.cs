using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class RegexSyntax
    {
        public static void RegexSyntaxMethod(){
            Console.WriteLine("--- Regex Syntaxe ---");
            Console.WriteLine("* Quantifier: Used to match the preceding character zero or more times.");
            QuantifierStar();
            Console.WriteLine("+ Quantifier: Used to match the preceding character one or more times.");
            QuantifierPlus();
            Console.WriteLine("? Quantifier: Used to match the preceding character zero or one time.");
            QuantifierQuestionMark();
            Console.WriteLine("^ Special Character: Word after this element matches at the beginning of the string or line.");
            SpecialCharacterCircumflex();
            Console.WriteLine("$ Special Character: Word before this element matches at the end of the line or string.");
            SpecialCharacterDollar();
            Console.WriteLine(". Special Character: Matches any character only once expect.");
            SpecialCharacterDot();
            Console.WriteLine("BackSlash + d Special Character: It is use to match the digit character.");
            SpecialCharacterD();
            Console.WriteLine("[] Character Class: Matches any character only once expect.");
            SpecialCharacterBrackets();
            Console.WriteLine("[a-z] Character Class: It is used to match any character in the range of a-z.");
            SpecialCharacterBracketsLetters();
            Console.WriteLine("() Group Expression: It is used for group expression.");
            SpecialCharacterGroupExpression();
            Console.WriteLine("(a|b) Group Expression: | Operator is used for alternative either a or b.");
            SpecialCharacterGroupExpression2();
        }

        public static void QuantifierStar(){
            // This will return any pattern b, ab, aab, ...
            Regex regex = new Regex(@"a*b");
            Match match = regex.Match("aaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void QuantifierPlus(){
            // This will return any pattern like ab, aab, aaab, ....
            Regex regex = new Regex(@"a+b");
            Match match = regex.Match("aaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void QuantifierQuestionMark(){
            // This return any pattern like b, ab
            Regex regex = new Regex(@"a?b");
            Match match = regex.Match("aaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterCircumflex(){
            // This will return if shyam exist at the beginning of the line
            Regex regex = new Regex(@"^Shyam");
            Match match = regex.Match("Shyam is my pet name");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterDollar(){
            // This return parth if it exist at the end of the line
            Regex regex = new Regex(@"Parth$");
            Match match = regex.Match("My name is Parth");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterDot(){
            // This will return any word which contains only one letter between s and t
            Regex regex = new Regex(@"s..t");
            Match match = regex.Match("This is my seat");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterD(){
            // This will the return the one digit character
            Regex regex = new Regex(@"\d");
            Match match = regex.Match("I am 24 years old");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterBrackets(){
            // This will return one character either a or b or c which will come first
            Regex regex = new Regex(@"[abc]");
            Match match = regex.Match("abcdef");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
        
        public static void SpecialCharacterBracketsLetters(){
            // This will return any character between x and z inclusive
            Regex regex = new Regex(@"[x-z]");
            Match match = regex.Match("xmax");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterGroupExpression(){
            // This will return pattern cd, cdcd, cdcdcd...
            Regex regex = new Regex(@"(cd)+");
            Match match = regex.Match("cdcdde");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        public static void SpecialCharacterGroupExpression2(){
            // This will either d or e which ever comes first
            Regex regex = new Regex(@"d|e");
            Match match = regex.Match("edge");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

    }

}