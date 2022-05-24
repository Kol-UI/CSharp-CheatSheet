using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace CSharp_CheatSheet
{
    public class RegexParse
    {
        public static void ParseMain(){
            string text = "500";
            int num = int.Parse(text);

            Console.WriteLine("--- Parse ---");
            Console.WriteLine(num);

            Console.WriteLine("--- TryParse ---");
            TryParseMethod();

            Console.WriteLine("--- TryParse No If ---");
            TryParseNoIf();

            Console.WriteLine("--- New Out Syntax ---");
            NewOutSyntax();

            Console.WriteLine("--- Converting ---");
            Converting();

            Console.WriteLine("--- TryParse a DateTime ---");
            TryParseDateTime();

            Console.WriteLine("--- Benchmarks Invalid Strings ---");
            BenchmarksInvalidStrings();

            Console.WriteLine("--- Benchmarks IntParse Fast ---");
            BenchmarksIntParseFast();
        }

        private static void TryParseMethod(){
            // See if we can parse the string.
            string text1 = "x";
            int num1;
            bool res = int.TryParse(text1, out num1);
            if (res == false)
            {
                // String is not a number.
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            Console.WriteLine(num1);
            

            // Use int.TryParse on a valid numeric string.
            string text2 = "10000";
            int num2;
            if (int.TryParse(text2, out num2))
            {
                Console.WriteLine("False");
            }
            Console.WriteLine(num2);
        }
        
        private static void TryParseNoIf(){
            string error = "Welcome";
            Console.WriteLine("This will leave the result variable with a value of 0 if error");
            int result;
            int.TryParse(error, out result);
            Console.WriteLine(result);

            string notAnError = "12";
            int result2;
            int.TryParse(notAnError, out result2);
            Console.WriteLine(result2);
        }

        private static void NewOutSyntax(){
            string textOut = "Testing";
            const string value = "345";
            // We can place the "out int" declaration in the method call.
            if (int.TryParse(value, out int result))
            {
                Console.WriteLine(result + 1);
            }
            if (int.TryParse(textOut, out int result2))
            {
                Console.WriteLine(result2 + 1);
            }
            else
            {
                Console.WriteLine("Not a good value.");
            }
        }

        private static void Converting(){
            Console.WriteLine("Convert string to an integer with Convert.ToInt32.");
            string text = "500";
            int num = Convert.ToInt32(text);
            Console.WriteLine(num);
        }

        private static void TryParseDateTime(){
            Console.WriteLine("Use TryParse on the DateTime type to parse a date.");
            string date1 = "22/1/2017";
            string date2 = "January 1 2017";
            string date3 = "text";
            DateTime parsed, parsed2, parsed3;
            if (DateTime.TryParse(date1, out parsed))
            {
                Console.WriteLine(parsed);
            }
            else
            {
                Console.WriteLine("Not valid, can't be parsed with DateTime.");
            }

            if (DateTime.TryParse(date2, out parsed2))
            {
                Console.WriteLine(parsed2);
            }
            else
            {
                Console.WriteLine("Not valid, can't be parsed with DateTime.");
            }

            if (DateTime.TryParse(date3, out parsed3))
            {
                Console.WriteLine(parsed3);
            }
            else
            {
                Console.WriteLine("Not valid, can't be parsed with DateTime.");
            }
        }

        private static void BenchmarksInvalidStrings(){
            const int _max = 10000;

            // Version 1: parse an invalid string with exception handling.
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                int result;
                try
                {
                    result = int.Parse("abc");
                }
                catch
                {
                    result = 0;
                }
            }
            s1.Stop();
            
            // Version 2: parse an invalid string with TryParse.
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                int result;
                int.TryParse("abc", out result);
            }
            s2.Stop();
            Console.WriteLine("Using int.TryParse on invalid input is many times faster:");
            Console.WriteLine("Parse an invalid string with exception handling:\t" + ((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.WriteLine("Parse an invalid string with TryParse:\t\t\t" + ((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
        }

        public static int IntParseFast(string value)
        {
            // An optimized int parse method.
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = 10 * result + (value[i] - 48);
            }
            return result;
        }


        private static void BenchmarksIntParseFast(){
            const int _max = 1000000;

            // Test the methods.
            Console.WriteLine(IntParseFast("123456"));
            Console.WriteLine(int.Parse("123456"));
            
            var s1 = Stopwatch.StartNew();
            // Version 1: use custom parsing algorithm.
            for (int i = 0; i < _max; i++)
            {
                int result = IntParseFast("123456");
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            // Version 2: use int.Parse.
            for (int i = 0; i < _max; i++)
            {
                int result = int.Parse("123456");
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
        }
    }

}