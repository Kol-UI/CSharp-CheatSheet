using System;
namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class DateTimeTimeZone
    {
        public static string DatePatern = @"M/d/yyyy hh:mm:ss tt";

        public static void TimeZoneMain()
        {
            DateTime now = DateTime.Now;
            DateTime nowUTC = DateTime.UtcNow;
            DateTime newDate;

            DisplayNow("UtcNow: ..........", now);
            DisplayNow("Now: .............", nowUTC);
            Console.WriteLine();

            newDate = DateTime.SpecifyKind(now, DateTimeKind.Utc);
            Display("Utc: ...............", newDate);
            newDate = DateTime.SpecifyKind(now, DateTimeKind.Local);
            Display("Local: .............", newDate);
            newDate = DateTime.SpecifyKind(now, DateTimeKind.Unspecified);
            Display("Unspecified: .......", newDate);

            Console.WriteLine("--- ConvertToUTC ---");
            ConvertToUTC(now);

            Program.Space();
            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
            }
        }

        private static void DisplayNow(string title, DateTime date)
        {
            string dtString = date.ToString(DatePatern);
            Console.WriteLine("{0} {1}, Kind = {2}", title, dtString, date.Kind);
        }

        private static void Display(string title, DateTime date)
        {
            DateTime dispDt = date;
            string dtString;

            dtString = dispDt.ToString(DatePatern);
            Console.WriteLine("{0} {1}, Kind = {2}", title, dtString, dispDt.Kind);

            dispDt = date.ToLocalTime();
            dtString = dispDt.ToString(DatePatern);
            Console.WriteLine("  ToLocalTime:     {0}, Kind = {1}", dtString, dispDt.Kind);

            dispDt = date.ToUniversalTime();
            dtString = dispDt.ToString(DatePatern);
            Console.WriteLine("  ToUniversalTime: {0}, Kind = {1}", dtString, dispDt.Kind);
            Console.WriteLine();
        }

        private static void ConvertToUTC(DateTime date)
        {
            Console.WriteLine("The date and time are {0} UTC.", TimeZoneInfo.ConvertTimeToUtc(date));
        }
    }
}
