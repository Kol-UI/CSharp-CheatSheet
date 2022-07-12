using System;
using System.Globalization;
using CSharp_CheatSheet.DateTimeFunctions;

namespace CSharp_CheatSheet.Menus.DateTimeMenus
{
    public class DateTimeMainMenu
    {
        public static void MainMethod()
        {
            Program.Space();
            Console.WriteLine("Which DateTime ?\n1) Initialization Examples\t2) Formatting DateTime as Strings\t3) Parsing String as DateTime" +
                "\n4) DateTime Resolution\t5) Culture & Calendars\t6) DateTime TimeZone\t7) DateTime Properties" +
                "\n8) Unix Time\t9) Time Interval   10) Format Time\t11) Leap Year");
            var DateTimeInput = Console.ReadLine();
            int valueDateTimeInput = int.Parse(DateTimeInput);
            switch (valueDateTimeInput)
            {
                case 1:
                    DateTimeInitializationExamples.InitializationExamplesMain();
                    break;
                case 2:
                    FormattingDateTimeAsStrings.FormattingDateTimeAsStringsMain();
                    break;
                case 3:
                    ParsingStringAsDateTime.ParsingStringAsDateTimeMain();
                    break;
                case 4:
                    DateTimeResolution();
                    break;
                case 5:
                    CultureAndCalendars();
                    break;
                case 6:
                    DateTimeTimeZone.TimeZoneMain();
                    break; 
                case 7:
                    DateTimeProperties.DateTimePropertiesMain();
                    break;
                case 8:
                    UnixTime();
                    break; 
                case 9:
                    TimeInterval.TimeIntervalMain();
                    break;
                case 10:
                    FormatTime.FormatTimeMain();
                    break;
                case 11:
                    LeapYear();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void DateTimeResolution()
        {
            string output = "";
            for (int i = 0; i <= 20; i++)
            {
                output += String.Format($"{DateTime.Now.Millisecond}\n");
                for (int delay = 0; delay <= 1000; delay++)
                { }

                if (i == 10)
                {
                    output += "Thread.Sleep called...\n";
                    System.Threading.Thread.Sleep(5);
                }
            }
            Console.WriteLine(output);
        }

        private static void CultureAndCalendars()
        {
            Program.Space();
            Console.WriteLine("Which Culture & Calendars Topic ?\n1) Culture Info\n2) List Cultures\n3) Calendars\n4) Represent Dates");
            var DateCCInput = Console.ReadLine();
            int valueCCInput = int.Parse(DateCCInput);
            switch (valueCCInput)
            {
                case 1:
                    DateTimeCultureInfo.CultureInfoMain();
                    break;
                case 2:
                    ListCultures();
                    break;
                case 3:
                    DateTimeCalendars.DateTimeCalendarsMain();
                    break;
                case 4:
                    DateTimeCalendars.RepresentDates();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        public static void ListCultures()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("{0,-15}{0,-5}{0,-45}{0,-40}", "Culture", "ISO", "Display name", "English Name");

            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.Write("{0,-15}", ci.Name);
                Console.Write("{0,-5}", ci.TwoLetterISOLanguageName);
                Console.Write("{0,-45}", ci.DisplayName);
                Console.WriteLine("{0,-40}", ci.EnglishName);
            }
        }

        private static void UnixTime()
        {
            Console.WriteLine("--- Unix Time ---");
            long unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            Console.WriteLine("At this moment {0} seconds have passed since Unix Epoch.", unixTime);
        }

        private static void LeapYear()
        {
            Console.Write("Input a year (yyyy) : ");
            var yearInput = Console.ReadLine();
            int year = Convert.ToInt32(yearInput);
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
