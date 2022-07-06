using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class ParsingStringAsDateTime
    {
        public static void ParsingStringAsDateTimeMain()
        {
            var dateParsing = new DateTime(2013, 6, 1, 12, 32, 30);
            string stringDate = "05/01/2009 06:32:00";
            string[] arrayFormats = { "yyyyMMdd", "HHmmss" };
            string[] arrayDateStrings = { "20130816", "09.15.1975", "20131608", "03-12-2004", "  20130816   ", "115216", "521116", "  115216  " };
            string dateExample = "03-12-2004";
            string dateExample2 = "09.15.1975";
            var isoString = "20080501T08:30:52Z";

            Program.Space();
            Console.WriteLine("--- Parse Converting String to Date & Time ---");
            ParseConverting();
            Program.Space();
            Console.WriteLine("--- TryParse Converting String to Date & Time ---");
            TryParseConverting(dateParsing, stringDate);
            Program.Space();
            Console.WriteLine("--- ParseExact Converting String to Unknown Format ---");
            ParseExactConverting(dateExample, dateExample2);
            Program.Space();
            Console.WriteLine("--- TryParseExact Converting String to Unknown Format ---");
            TryParseExactConverting(arrayFormats, arrayDateStrings);
            Program.Space();
            Console.WriteLine("--- Convert ISO8601 to Date & Time ---");
            ConvertISO(isoString);
            Program.Space();
        }

        public static void ParseConverting()
        {
            (string dateAsString, string description)[] dateInfo = { ("08/18/2018 07:22:16", "String with a date and time component"),
                                                                ("08/18/2018", "String with a date component only"),
                                                                ("8/2018", "String with a month and year component only"),
                                                                ("8/18", "String with a month and day component only"),
                                                                ("07:22:16", "String with a time component only"),
                                                                ("7 PM", "String with an hour and AM/PM designator only"),
                                                                ("2018-08-18T07:22:16.0000000Z", "UTC string that conforms to ISO 8601"),
                                                                ("2018-08-18T07:22:16.0000000-07:00", "Non-UTC string that conforms to ISO 8601"),
                                                                ("Sat, 18 Aug 2018 07:22:16 GMT", "String that conforms to RFC 1123"),
                                                                ("08/18/2018 07:22:16 -5:00", "String with date, time, and time zone information" ) };

            Console.WriteLine($"Today is {DateTime.Now:d}\n");

            foreach (var item in dateInfo)
            {
                Console.WriteLine($"{item.description + ":",-52} '{item.dateAsString}' --> {DateTime.Parse(item.dateAsString)}");
            }
        }

        public static void TryParseConverting(DateTime dateParsing, String stringDate)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            var badFormats = new List<String>();

            Console.WriteLine($"{"Date String",-37} {"Date",-19}\n");
            foreach (var dateString in dateParsing.GetDateTimeFormats())
            {
                DateTime parsedDate;
                if (DateTime.TryParse(dateString, out parsedDate))
                {
                    Console.WriteLine($"{dateString,-37} {DateTime.Parse(dateString),-19}");
                }
                else
                {
                    badFormats.Add(dateString);
                }
            }
            // Display strings that could not be parsed.
            if (badFormats.Count > 0)
            {
                Console.WriteLine("\nStrings that could not be parsed: ");
                foreach (var badFormat in badFormats)
                {
                    Console.WriteLine($"   {badFormat}");
                }
            }

            // Simple TryParse
            Program.Space();
            DateTime dateValue;
            if (DateTime.TryParse(stringDate, out dateValue))
            {
                Console.WriteLine("Converted '{0}' to {1}.", stringDate, dateValue);
            }
            else
            {
                Console.WriteLine("Unable to convert '{0}' to a date.", stringDate);
            }
        }

        public static void ParseExactConverting(string dateExample, string dateExample2)
        {
            string[] formats = new string[] { "dd-MM-yyyy", "MM-dd-yyyy", "MM/dd/yyyy", "dd/MM/yyyy" };
            DateTime newDate = DateTime.ParseExact(dateExample, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            Console.WriteLine("Parse '{0}' to {1}.", dateExample, newDate);

            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime newDate2 = DateTime.ParseExact(dateExample2, new string[] { "MM.dd.yyyy", "MM-dd-yyyy", "MM/dd/yyyy" }, provider, DateTimeStyles.None);
            Console.WriteLine("Parse '{0}' to {1}.", dateExample2, newDate2);
        }

        public static void TryParseExactConverting(String[] arrayFormats, String[] arrayDateStrings)
        {
            DateTime parsedDate;
            foreach (var dateString in arrayDateStrings)
            {
                if (DateTime.TryParseExact(dateString, arrayFormats, null, DateTimeStyles.AllowWhiteSpaces |
                                           DateTimeStyles.AdjustToUniversal,
                                           out parsedDate))
                {
                    Console.WriteLine($"{dateString} --> {parsedDate:g}");
                }
                else
                {
                    Console.WriteLine($"Cannot convert {dateString}");
                }
            }
        }

        public static void ConvertISO(string isoString)
        {
            DateTime dateISO8602 = DateTime.ParseExact(isoString, "yyyyMMddTHH:mm:ssZ", CultureInfo.InvariantCulture);
            Console.WriteLine($"{isoString} --> {dateISO8602:g}");
        }
    }
}
