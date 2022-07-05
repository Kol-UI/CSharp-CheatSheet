using System;

namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class DateTimeInitializationExamples
    {
        public static void InitializationExamplesMain()
        {
            Program.Space();
            Console.WriteLine("--- Invoke Constructor ---");
            InvokeConstructor();
            Program.Space();
            Console.WriteLine("--- Invoke Implicit DateTime ---");
            InvokeImplicitDateTime();
            Program.Space();
            Console.WriteLine("--- Assigning a Computed Value ---");
            AssigningComputedValue();
            Program.Space();
            Console.WriteLine("--- Parsing a String DateTime ---");
            ParsingStringDateTime();
            Program.Space();
            
        }

        private static void InvokeConstructor()
        {
            var date1 = new DateTime(1998, 3, 23, 10, 30, 23);
            Console.WriteLine(date1);
        }

        private static void InvokeImplicitDateTime()
        {
            var dat1 = new DateTime();
            Console.WriteLine(dat1.ToString(System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine(dat1.Equals(DateTime.MinValue));
        }

        private static void AssigningComputedValue()
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
        }

        private static void ParsingStringDateTime()
        {
            var dateString = "5/1/1939 8:30:52 AM";
            DateTime date1 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateString);
            var iso8601String = "20080501T08:30:52Z";
            DateTime dateISO8602 = DateTime.ParseExact(iso8601String, "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateISO8602);
        }
    }
}
