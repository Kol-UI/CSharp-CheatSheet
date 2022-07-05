using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class FormattingDateTimeAsStrings
    {

        public static void FormattingDateTimeAsStringsMain()
        {
            Program.Space();
            Console.WriteLine("--- Default Format Date ---");
            DefaultFormatDate();
            Program.Space();
            Console.WriteLine("--- Specific Culture Date ---");
            SpecificCultureDate();
            Program.Space();
            Console.WriteLine("--- Get All Specific Culture ---");
            GetAllSpecificCulture();
            Program.Space();
            Console.WriteLine("--- DateTime Custom Format String ---");
            CustomFormatString();
            Program.Space();
            Console.WriteLine("--- Specify Format String & Specific Culture ---");
            SpecifyFormatStringAndSpecificCulture();
            Program.Space(); 
            Console.WriteLine("--- Format DateTime Using ISO8601 Standard Web Services ---");
            FormatDateTimeUsingISO8601StandardWebServices();
            Program.Space();
        }

        private static void DefaultFormatDate()
        {
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.ToString());
        }

        private static void SpecificCultureDate()
        {
            Console.WriteLine("French (fr-FR):");
            var date1 = new DateTime(1998, 3, 23, 9, 0, 0);
            Console.WriteLine(date1.ToString(CultureInfo.CreateSpecificCulture("fr-FR")));
        }

        private static void GetAllSpecificCulture()
        {
            Console.WriteLine("{0,-53}{1}", "CULTURE", "SPECIFIC CULTURE");
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            Array.Sort<CultureInfo>(cultures, new NamePropertyComparer<CultureInfo>());

            foreach (var culture in cultures)
            {
                Console.Write("{0,-12} {1,-40}", culture.Name, culture.EnglishName);
                try
                {
                    Console.WriteLine("{0}", CultureInfo.CreateSpecificCulture(culture.Name).Name);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("(no associated specific culture)");
                }
            }
        }

        private static void CustomFormatString()
        {
            var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            var date2 = new DateTime(1998, 3, 23, 9, 0, 0);
            Console.WriteLine(date1.ToString("F"));
            Console.WriteLine(date2.ToString("F"));
        }

        private static void SpecifyFormatStringAndSpecificCulture()
        {
            var date1 = new DateTime(1998, 3, 23, 9, 0, 0);
            Console.WriteLine(date1.ToString("F", new CultureInfo("fr-FR")));
        }

        private static void FormatDateTimeUsingISO8601StandardWebServices()
        {
            var date1 = new DateTime(1998, 3, 23, 9, 0, 0);
            Console.WriteLine("Normal DateTime:");
            Console.WriteLine(date1);
            Console.WriteLine("ToString DateTime:");
            Console.WriteLine(date1.ToString("F"));
            Console.WriteLine("ToString ISO8601 DateTime:");
            Console.WriteLine(date1.ToString("yyyyMMddTHH:mm:ssZ"));
        }


    }

    public class NamePropertyComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            PropertyInfo pX = x.GetType().GetProperty("Name");
            PropertyInfo pY = y.GetType().GetProperty("Name");
            return String.Compare((string)pX.GetValue(x, null), (string)pY.GetValue(y, null));
        }
    }
}
