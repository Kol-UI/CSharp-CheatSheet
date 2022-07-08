using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Globalization.CultureTypes;

namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class DateTimeCultureInfo
    {
        public static void CultureInfoMain()
        {
            Console.WriteLine("--- CultureInfo ---");
            Console.WriteLine("--- Set Culture ---");
            SetCulture();
            Program.Space();
            Console.WriteLine("--- Various Cultures ---");
            VariousCultures();
            Program.Space(); 
            Console.WriteLine("--- CultureInfo Sorting ---");
            CultureInfoSorting();
            Program.Space();
            Console.WriteLine("--- CultureInfo Decimal Separators ---");
            DecimalSeparators();
            Program.Space();
            Console.WriteLine("--- CultureInfo Thousands Separators ---");
            ThousandsSeparators();
            Program.Space();
            Console.WriteLine("--- CultureInfo Currency ---");
            CultureInfoCurrency();
            Program.Space();
            Console.WriteLine("--- CultureInfo First Day of Week ---");
            FirstDayofWeek();
            Program.Space();
            Console.WriteLine("--- CultureInfo Day Names ---");
            DayNames();
            Program.Space();
            Console.WriteLine("--- CultureInfo Month Names ---");
            MonthNames();
            Program.Space();
            Console.WriteLine("--- CultureInfo DateTime Formats ---");
            CultureInfoDateTimeFormat();
            Program.Space();
            

        }


        private static void SetCulture()
        {
            double val = 3960.38;

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(val);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(val);
        }

        private static void VariousCultures()
        {
            CultureInfo[] specificCultures = CultureInfo.GetCultures(SpecificCultures);
            Console.WriteLine($"{specificCultures.Length} specific cultures in .NET");
            CultureInfo[] neutralCultures = CultureInfo.GetCultures(NeutralCultures);
            Console.WriteLine($"{neutralCultures.Length} neutral cultures in .NET");
        }

        private static void CultureInfoSorting()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sk-SK");
            Console.WriteLine("Sorting strings in culture specific:");

            var words = new List<string> { "čaj", "auto", "drevo", "cibuľa", "čučoriedka", "banán", "čerešňa", "červený", "čierny", "cesnak" };

            words.Sort();
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }
            Program.Space();
        }

        private static void DecimalSeparators()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double val = 1278.112;
            Console.WriteLine("sk-SK Decimal Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sk-SK");
            Console.WriteLine($"{val}");
            Console.WriteLine("en-US Decimal Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{val}");
            Console.WriteLine("fa-IR Decimal Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fa-IR");
            Console.WriteLine($"{val}");
        }

        private static void ThousandsSeparators()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int val = 12_156_320;
            Console.WriteLine("sk-SK Thousands Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sk-SK");
            Console.WriteLine($"{val:N}");
            Console.WriteLine("en-US Thousands Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{val:N}");
            Console.WriteLine("de-CH Thousands Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-CH");
            Console.WriteLine($"{val:N}");
            Console.WriteLine("hi-IN Thousands Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("hi-IN");
            Console.WriteLine($"{val:N}");
            Console.WriteLine("es-ES Thousands Separator:");
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            Console.WriteLine($"{val:N}");
        }


        private static void CultureInfoCurrency()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double val = 12_156_320.54;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sk-SK");
            Console.WriteLine($"{val:c}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ff-NG");
            Console.WriteLine($"{val:c}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fil-PH");
            Console.WriteLine($"{val:c}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("zh-CN");
            Console.WriteLine($"{val:c}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-GB");
            Console.WriteLine($"{val:c}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{val:c}"); 
        }


        private static void FirstDayofWeek()
        {
            var enUs = new CultureInfo("en-US");

            var firstDay = enUs.DateTimeFormat.FirstDayOfWeek.ToString();
            var name = enUs.DisplayName;
            Console.WriteLine($"First day of the week in {name}: {firstDay}");

            var skSk = new CultureInfo("sk-Sk");

            var name2 = skSk.DisplayName;
            var firstDay2 = skSk.DateTimeFormat.FirstDayOfWeek.ToString();
            Console.WriteLine($"First day of the week in {name2}: {firstDay2}");

            var faIr = new CultureInfo("fa-IR");

            var name3 = faIr.DisplayName;
            var firstDay3 = faIr.DateTimeFormat.FirstDayOfWeek.ToString();
            Console.WriteLine($"First day of the week in {name3}: {firstDay3}");
        }

        private static void FirstWeek()
        {
            var enUs = new CultureInfo("en-US");

            var weekRule = enUs.DateTimeFormat.CalendarWeekRule.ToString();
            Console.WriteLine($"First calendar week starts with: {weekRule}");

            var skSk = new CultureInfo("sk-Sk");

            var weekRule2 = skSk.DateTimeFormat.CalendarWeekRule.ToString();
            Console.WriteLine($"First calendar week starts with: {weekRule2}");
        }

        private static void DayNames()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var enUs = new CultureInfo("en-US");
            foreach (var dayName in enUs.DateTimeFormat.DayNames)
            {
                Console.Write(dayName + " ");
            }

            Console.WriteLine("\n-----");
            var frFR = new CultureInfo("fr-FR");
            foreach (var dayName in frFR.DateTimeFormat.DayNames)
            {
                Console.Write(dayName + " ");
            }

            Console.WriteLine("\n-----");
            var ruRU = new CultureInfo("ru-RU");
            foreach (var dayName in ruRU.DateTimeFormat.DayNames)
            {
                Console.Write(dayName + " ");
            }

            Console.WriteLine("\n-----");
            var skSk = new CultureInfo("sk-SK");
            foreach (var dayName in skSk.DateTimeFormat.DayNames)
            {
                Console.Write(dayName + " ");
            }

            Console.WriteLine("\n-----");
            var esES = new CultureInfo("es-ES");
            foreach (var dayName in esES.DateTimeFormat.DayNames)
            {
                Console.Write(dayName + " ");
            }
        }

        private static void MonthNames()
        {
            Program.Space();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var enUS = new CultureInfo("en-US");
            var frFR = new CultureInfo("fr-FR");
            var huHU = new CultureInfo("hu-HU");
            var skSK = new CultureInfo("sk-SK");
            var ruRU = new CultureInfo("ru-RU");
            var esES = new CultureInfo("es-ES");
            var nameenUS = enUS.NativeName;
            var namefrFR = frFR.NativeName;
            var nameskSK = skSK.NativeName;
            var namehuHU = huHU.NativeName;
            var nameruRU = ruRU.NativeName;
            var nameesES = esES.NativeName;

            Console.WriteLine($"{nameenUS}: Months");
            foreach (var monthName in enUS.DateTimeFormat.MonthNames)
            {
                Console.Write(monthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{namefrFR}: Months");
            foreach (var monthName in frFR.DateTimeFormat.MonthNames)
            {
                Console.Write(monthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameskSK}: Months");
            foreach (var monthName in skSK.DateTimeFormat.MonthNames)
            {
                Console.Write(monthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{namehuHU}: Months");
            foreach (var monthName in huHU.DateTimeFormat.MonthNames)
            {
                Console.Write(monthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameruRU}: Months");
            foreach (var monthName in ruRU.DateTimeFormat.MonthNames)
            {
                Console.Write(monthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameesES}: Months");
            foreach (var monthName in esES.DateTimeFormat.MonthNames)
            {
                Console.Write(monthName + " ");
            }

            Program.Space();
            Console.WriteLine();
            Console.WriteLine("--- CultureInfo Abbreviated Month Names ---");

            Console.WriteLine();
            Console.WriteLine($"{nameenUS}: Abbreviated Months");
            foreach (var abbMonthName in enUS.DateTimeFormat.AbbreviatedMonthNames)
            {
                Console.Write(abbMonthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{namefrFR}: Abbreviated Months");
            foreach (var abbMonthName in frFR.DateTimeFormat.AbbreviatedMonthNames)
            {
                Console.Write(abbMonthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameskSK}: Abbreviated Months");
            foreach (var abbMonthName in skSK.DateTimeFormat.AbbreviatedMonthNames)
            {
                Console.Write(abbMonthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{namehuHU}: Abbreviated Months");
            foreach (var abbMonthName in huHU.DateTimeFormat.AbbreviatedMonthNames)
            {
                Console.Write(abbMonthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameruRU}: Abbreviated Months");
            foreach (var abbMonthName in ruRU.DateTimeFormat.AbbreviatedMonthNames)
            {
                Console.Write(abbMonthName + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{nameesES}: Abbreviated Months");
            foreach (var abbMonthName in esES.DateTimeFormat.AbbreviatedMonthNames)
            {
                Console.Write(abbMonthName + " ");
            }
            Program.Space();
        }


        private static void CultureInfoDateTimeFormat()
        {
            var enUS = new CultureInfo("en-US");
            var frFR = new CultureInfo("fr-FR");
            var ruRU = new CultureInfo("ru-RU");
            var esES = new CultureInfo("es-ES");

            CultureInfo.DefaultThreadCurrentCulture = enUS;
            var now = DateTime.Now;
            Console.WriteLine("\nEnglish Dates\n");
            PrintCultureInfo(enUS, now);
            Console.WriteLine("\nFrench Dates\n");
            PrintCultureInfo(frFR, now);
            Console.WriteLine("\nRussian Dates\n");
            PrintCultureInfo(ruRU, now);
            Console.WriteLine("\nSpanish Dates\n");
            PrintCultureInfo(esES, now);
            CultureInfo.DefaultThreadCurrentCulture = enUS;
        }

        private static void PrintCultureInfo(CultureInfo langCountry, DateTime now)
        {
            CultureInfo.DefaultThreadCurrentCulture = langCountry;

            Console.WriteLine(langCountry.DateTimeFormat.FullDateTimePattern);
            Console.WriteLine(now.ToString(langCountry.DateTimeFormat.FullDateTimePattern));

            Console.WriteLine();

            Console.WriteLine(langCountry.DateTimeFormat.LongDatePattern);
            Console.WriteLine(now.ToString(langCountry.DateTimeFormat.LongDatePattern));

            Console.WriteLine();

            Console.WriteLine(langCountry.DateTimeFormat.ShortTimePattern);
            Console.WriteLine(now.ToString(langCountry.DateTimeFormat.ShortDatePattern));
        }


    }
}
