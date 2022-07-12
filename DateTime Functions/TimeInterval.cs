using System;
namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class TimeInterval
    {
        public static void TimeIntervalMain()
        {
            string startTime = "7:00 AM";
            string endTime = "8:30 PM";

            TimeSpan elapsed = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));

            Console.WriteLine($"Time elapsed: {elapsed}");

            DateTime now = DateTime.Today;
            DateTime borodino_battle = new DateTime(1812, 9, 7);

            TimeSpan diff = now - borodino_battle;

            Console.WriteLine($"{diff.TotalDays} days have passed since the Battle of Borodino.");
        }
    }
}
