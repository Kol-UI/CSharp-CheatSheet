using System;
namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class FormatTime
    {
        public static void FormatTimeMain()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("--- Today's date using some of the standard format specifiers ---"); 
            Console.WriteLine("\nd specifier creates a short date pattern");
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("\nD specifier creates a long date pattern");
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine("\nF specifier creates a full date and time pattern");
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("\nM specifier creates a month and day pattern");
            Console.WriteLine(now.ToString("M"));
            Console.WriteLine("\no specifier creates a round-trip date and time pattern");
            Console.WriteLine(now.ToString("o"));
            Console.WriteLine("\nR specifier creates an RFC1123 date and time pattern");
            Console.WriteLine(now.ToString("R"));
            Console.WriteLine("\nt specifier creates a short time pattern");
            Console.WriteLine(now.ToString("t"));
            Console.WriteLine("\nT specifier creates a long time pattern");
            Console.WriteLine(now.ToString("T"));
            Console.WriteLine("\nY specifier creates a year and month pattern");
            Console.WriteLine(now.ToString("Y"));

            Program.Space();
            CustomizedDateandTimeFormatPatterns(now);
        }

        private static void CustomizedDateandTimeFormatPatterns(DateTime now)
        {
            Console.WriteLine("--- Customized Date and Time Format Patterns ---");
            Console.WriteLine(now.ToString("ddd MMM %d, yyyy"));
            Console.WriteLine(now.ToString("hh:mm:ss tt"));
        }
    }
}
