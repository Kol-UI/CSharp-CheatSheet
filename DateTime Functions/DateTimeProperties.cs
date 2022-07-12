using System;
namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class DateTimeProperties
    {
        public static void DateTimePropertiesMain()
        {
            string[] months = {"January", "February", "March", "April", "May",
                               "June", "July", "August", "September", "October", "November", "December"};
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));

            Console.WriteLine("Today's date: {0}", now.Date);
            Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
            Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
            Console.WriteLine("Today's time: {0}", now.TimeOfDay);
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Second: {0}", now.Second);
            Console.WriteLine("Millisecond: {0}", now.Millisecond);
            Console.WriteLine("The day of week: {0}", now.DayOfWeek);
            Console.WriteLine("Kind: {0}", now.Kind);

            Program.Space();
            AddDateTime(now);
            Program.Space();
            SubtractDateTime(now);
            Program.Space();
        }

        private static void AddDateTime(DateTime date)
        {
            Console.WriteLine("--- Add DateTime ---");
            DateTime dt1 = date.AddSeconds(55);
            DateTime dt2 = date.AddMinutes(30);
            DateTime dt3 = date.AddHours(72);
            DateTime dt4 = date.AddDays(23);
            DateTime dt5 = date.AddDays(65);
            DateTime dt6 = date.AddMonths(3);
            DateTime dt7 = date.AddYears(4);

            Console.WriteLine(dt1.ToString("F"));
            Console.WriteLine(dt2.ToString("F"));
            Console.WriteLine(dt3.ToString("F"));
            Console.WriteLine(dt4.ToString("F"));
            Console.WriteLine(dt5.ToString("F"));
            Console.WriteLine(dt6.ToString("F"));
            Console.WriteLine(dt7.ToString("F"));
        }

        private static void SubtractDateTime(DateTime date)
        {
            Console.WriteLine("--- Subtract DateTime ---");
            DateTime dt1 = date.AddSeconds(-55);
            DateTime dt2 = date.AddMinutes(-30);
            DateTime dt3 = date.AddHours(-72);
            DateTime dt4 = date.AddDays(-23);
            DateTime dt5 = date.AddDays(-65);
            DateTime dt6 = date.AddMonths(-3);
            DateTime dt7 = date.AddYears(-4);

            Console.WriteLine(dt1.ToString("F"));
            Console.WriteLine(dt2.ToString("F"));
            Console.WriteLine(dt3.ToString("F"));
            Console.WriteLine(dt4.ToString("F"));
            Console.WriteLine(dt5.ToString("F"));
            Console.WriteLine(dt6.ToString("F"));
            Console.WriteLine(dt7.ToString("F"));
        }


    }
}
