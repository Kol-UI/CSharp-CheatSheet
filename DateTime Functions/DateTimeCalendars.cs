using System;
using System.Globalization;
using System.Threading;

namespace CSharp_CheatSheet.DateTimeFunctions
{
    public class DateTimeCalendars
    {
        public static void DateTimeCalendarsMain()
        {
            Console.WriteLine("--- Calendars per Language ---");
            var now = DateTime.Now;
            var enUS = new CultureInfo("en-US");
            var frFR = new CultureInfo("fr-FR");
            var ruRU = new CultureInfo("ru-RU");
            var esES = new CultureInfo("es-ES");
            var jaJA = new CultureInfo("ja-JA");
            var heIL = new CultureInfo("he-IL");
            var thTH = new CultureInfo("th-TH");
            var arSA = new CultureInfo("ar-SA");
            var arEG = new CultureInfo("ar-EG");
            var arSY = new CultureInfo("ar-SY");
            var zhTW = new CultureInfo("zh-Tw");
            Thread.CurrentThread.CurrentCulture = enUS;
            ShowCalendar(enUS, now);
            ShowCalendar(frFR, now); 
            ShowCalendar(ruRU, now);
            ShowCalendar(esES, now);
            ShowCalendar(jaJA, now);
            ShowCalendar(heIL, now);
            ShowCalendar(thTH, now);
            ShowCalendar(arSA, now);
            ShowCalendar(arEG, now);
            ShowCalendar(arSY, now);
            ShowCalendar(zhTW, now);
        }

        private static void ShowCalendar(CultureInfo langCountry, DateTime now)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Calendars for the {0} culture:", langCountry.Name);
            Calendar defaultCalendar = langCountry.Calendar;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Default Calendar: {0}", GetCalendarName(defaultCalendar));
            Console.ResetColor();

            if (defaultCalendar is GregorianCalendar)
            {
                Console.WriteLine(" ({0})", ((GregorianCalendar)defaultCalendar).CalendarType);
                Calendar gregorian = new GregorianCalendar();
                ReturnGregorianCalendar(langCountry, now, gregorian);
            }
            else
            {
                Console.WriteLine("\nThe default Calendar is not Gregorian.");
                Program.Space();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tOptional Calendars:");
            Console.ResetColor();
            foreach (var optionalCalendar in langCountry.OptionalCalendars)
            {
                Console.Write("\t{0,6}{1}", "", GetCalendarName(optionalCalendar));
                if (optionalCalendar is GregorianCalendar)
                {
                    Console.Write(" ({0})", ((GregorianCalendar)optionalCalendar).CalendarType);
                }
                Program.Space();
            }
            
            TryChangeCalendar(langCountry, now);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            Program.Space();
            Program.Time();
        }

        private static string GetCalendarName(Calendar calendar)
        {
            return calendar.ToString().Replace("System.Globalization.", "");
        }

        private static void DisplayCurrentInfo(CultureInfo langCountry)
        {
            Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
            Console.WriteLine("Current Calendar: {0}", DateTimeFormatInfo.CurrentInfo.Calendar);
        }

        private static void TryChangeCalendar(CultureInfo langCountry, DateTime now)
        {
            Calendar gregorian = new GregorianCalendar();
            Calendar hijri = new HijriCalendar();
            Calendar umalqura = new UmAlQuraCalendar();
            Calendar hebrew = new HebrewCalendar();
            Calendar japanese = new JapaneseCalendar();
            Calendar japaneseLunisolar = new JapaneseLunisolarCalendar();
            Calendar tawain = new TaiwanCalendar();
            Calendar tawainLunisolar = new TaiwanLunisolarCalendar();

            Console.WriteLine("Date: {0:d}", now);
            Console.WriteLine("Date in the Invariant Culture: {0}", now.ToString("d", CultureInfo.InvariantCulture));
            Console.WriteLine("---");
            if (CalendarExists(langCountry, gregorian))
            {
                ReturnGregorianCalendar(langCountry, now, gregorian);
            }
            if (CalendarExists(langCountry, hijri))
            {
                ReturnHijriCalendar(langCountry, now, hijri);
            }
            if (CalendarExists(langCountry, umalqura))
            {
                ReturnUmAlQuraCalendar(langCountry, now, umalqura);
            }
            if (CalendarExists(langCountry, hebrew))
            {
                ReturnHebrewCalendar(langCountry, now, hebrew);
            }
            if (CalendarExists(langCountry, japanese))
            {
                ReturnJapaneseCalendar(langCountry, now, japanese);
            }
            if (CalendarExists(langCountry, japaneseLunisolar))
            {
                ReturnJapaneseLunisolarCalendar(langCountry, now, japaneseLunisolar);
            }
            if (CalendarExists(langCountry, tawain))
            {
                ReturnTawainCalendar(langCountry, now, tawain);
            }
            if (CalendarExists(langCountry, tawainLunisolar))
            {
                ReturnTawainLunisolarCalendar(langCountry, now, tawainLunisolar);
            }

        }

        private static bool CalendarExists(CultureInfo langCountry, Calendar calendar)
        {
            foreach (Calendar optionalCalendar in langCountry.OptionalCalendars)
            {
                if (calendar.ToString().Equals(optionalCalendar.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private static void ReturnGregorianCalendar(CultureInfo langCountry, DateTime now, Calendar gregorian)
        {
            Console.WriteLine("Month property: {0}", gregorian.GetMonth(now));
            Console.WriteLine("Day property: {0}", gregorian.GetDayOfMonth(now));
            Console.WriteLine("Year property: {0:D4}", gregorian.GetYear(now));
            Console.WriteLine("--");
            langCountry.DateTimeFormat.Calendar = gregorian;
            DisplayCurrentInfo(langCountry);
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnHijriCalendar(CultureInfo langCountry, DateTime now, Calendar hijri)
        {
            Console.WriteLine("Hijri.GetMonth: {0}", hijri.GetMonth(now));
            Console.WriteLine("Hijri.GetDayOfMonth: {0}", hijri.GetDayOfMonth(now));
            Console.WriteLine("Hijri.GetYear: {0}", hijri.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = hijri;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnUmAlQuraCalendar(CultureInfo langCountry, DateTime now, Calendar umalqura)
        {
            Console.WriteLine("UmAlQura.GetMonth: {0}", umalqura.GetMonth(now));
            Console.WriteLine("UmAlQura.GetDayOfMonth: {0}", umalqura.GetDayOfMonth(now));
            Console.WriteLine("UmAlQura.GetYear: {0}", umalqura.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = umalqura;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnHebrewCalendar(CultureInfo langCountry, DateTime now, Calendar hebrew)
        {
            Console.WriteLine("Hebrew.GetMonth: {0}", hebrew.GetMonth(now));
            Console.WriteLine("Hebrew.GetDayOfMonth: {0}", hebrew.GetDayOfMonth(now));
            Console.WriteLine("Hebrew.GetYear: {0}", hebrew.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = hebrew;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnJapaneseCalendar(CultureInfo langCountry, DateTime now, Calendar japanese)
        {
            Console.WriteLine("Japanese.GetMonth: {0}", japanese.GetMonth(now));
            Console.WriteLine("Japanese.GetDayOfMonth: {0}", japanese.GetDayOfMonth(now));
            Console.WriteLine("Japanese.GetYear: {0}", japanese.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = japanese;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnJapaneseLunisolarCalendar(CultureInfo langCountry, DateTime now, Calendar japaneseLunisolar)
        {
            Console.WriteLine("JapaneseLunisolar.GetMonth: {0}", japaneseLunisolar.GetMonth(now));
            Console.WriteLine("JapaneseLunisolar.GetDayOfMonth: {0}", japaneseLunisolar.GetDayOfMonth(now));
            Console.WriteLine("JapaneseLunisolar.GetYear: {0}", japaneseLunisolar.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = japaneseLunisolar;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnTawainCalendar(CultureInfo langCountry, DateTime now, Calendar tawain)
        {
            Console.WriteLine("Tawain.GetMonth: {0}", tawain.GetMonth(now));
            Console.WriteLine("Tawain.GetDayOfMonth: {0}", tawain.GetDayOfMonth(now));
            Console.WriteLine("Tawain.GetYear: {0}", tawain.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = tawain;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }

        private static void ReturnTawainLunisolarCalendar(CultureInfo langCountry, DateTime now, Calendar tawainLunisolar)
        {
            Console.WriteLine("TawainLunisolar.GetMonth: {0}", tawainLunisolar.GetMonth(now));
            Console.WriteLine("TawainLunisolar.GetDayOfMonth: {0}", tawainLunisolar.GetDayOfMonth(now));
            Console.WriteLine("TawainLunisolar.GetYear: {0}", tawainLunisolar.GetYear(now));
            Console.WriteLine("--");
            Thread.CurrentThread.CurrentCulture = langCountry;
            langCountry.DateTimeFormat.Calendar = tawainLunisolar;
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine("----");
        }


        public static void RepresentDates()
        {
            Console.WriteLine("--- Represent Dates ---");
            DateTime nowDate = DateTime.Now;
            Console.WriteLine("Date ({0}): {1:d}", CultureInfo.CurrentCulture.Calendar, nowDate);
            Program.Space();
            ToJulianCalendar(nowDate);
            ToChineseLunisolarCalendar(nowDate);
            ToHebrewCalendar(nowDate);
            ToHijriCalendar(nowDate);
            ToJapaneseLunisolarCalendar(nowDate);
            ToKoreanCalendar(nowDate);
            ToKoreanLunisolarCalendar(nowDate);
            ToPersianCalendar(nowDate);
            ToThaiBuddhistCalendar(nowDate);
            ToUmAlQuraCalendar(nowDate);
            ToJapaneseCalendar(nowDate);
        }

        private static void ToJulianCalendar(DateTime nowDate)
        {
            JulianCalendar julian = new JulianCalendar();
            Console.WriteLine("--- Julian Calendar ---");
            Console.WriteLine("Date in Julian Calendar: {0:d2}/{1:d2}/{2:d4}", julian.GetMonth(nowDate), julian.GetDayOfMonth(nowDate), julian.GetYear(nowDate));
            Program.Space();
        }

        private static void ToChineseLunisolarCalendar(DateTime nowDate)
        {
            ChineseLunisolarCalendar chineseLunisolar = new ChineseLunisolarCalendar();
            Console.WriteLine("--- Chinese Lunisolar Calendar ---");
            Console.WriteLine("Date in Chinese Lunisolar Calendar: {0:d2}/{1:d2}/{2:d4}", chineseLunisolar.GetMonth(nowDate), chineseLunisolar.GetDayOfMonth(nowDate), chineseLunisolar.GetYear(nowDate));
            Program.Space();
        }

        private static void ToHebrewCalendar(DateTime nowDate)
        {
            HebrewCalendar hebrew = new HebrewCalendar();
            Console.WriteLine("--- Hebrew Calendar ---");
            Console.WriteLine("Date in Hebrew Calendar: {0:d2}/{1:d2}/{2:d4}", hebrew.GetMonth(nowDate), hebrew.GetDayOfMonth(nowDate), hebrew.GetYear(nowDate));
            Program.Space();
        }

        private static void ToHijriCalendar(DateTime nowDate)
        {
            HijriCalendar hijri = new HijriCalendar();
            Console.WriteLine("--- Hijri Calendar ---");
            Console.WriteLine("Date in Hijri Calendar: {0:d2}/{1:d2}/{2:d4}", hijri.GetMonth(nowDate), hijri.GetDayOfMonth(nowDate), hijri.GetYear(nowDate));
            Program.Space();
        }

        private static void ToJapaneseLunisolarCalendar(DateTime nowDate)
        {
            JapaneseLunisolarCalendar japaneseLunisolar = new JapaneseLunisolarCalendar();
            Console.WriteLine("--- Japanese Lunisolar Calendar ---");
            Console.WriteLine("Date in Japanese Lunisolar Calendar: {0:d2}/{1:d2}/{2:d4}", japaneseLunisolar.GetMonth(nowDate), japaneseLunisolar.GetDayOfMonth(nowDate), japaneseLunisolar.GetYear(nowDate));
            Program.Space();
        }

        private static void ToKoreanCalendar(DateTime nowDate)
        {
            KoreanCalendar korean = new KoreanCalendar();
            Console.WriteLine("--- Korean Calendar ---");
            Console.WriteLine("Date in Korean Calendar: {0:d2}/{1:d2}/{2:d4}", korean.GetMonth(nowDate), korean.GetDayOfMonth(nowDate), korean.GetYear(nowDate));
            Program.Space();
        }

        private static void ToKoreanLunisolarCalendar(DateTime nowDate)
        {
            KoreanLunisolarCalendar koreanLunisolar = new KoreanLunisolarCalendar();
            Console.WriteLine("--- Korean Lunisolar Calendar ---");
            Console.WriteLine("Date in Korean Lunisolar Calendar: {0:d2}/{1:d2}/{2:d4}", koreanLunisolar.GetMonth(nowDate), koreanLunisolar.GetDayOfMonth(nowDate), koreanLunisolar.GetYear(nowDate));
            Program.Space();
        }
        
        private static void ToPersianCalendar(DateTime nowDate)
        {
            PersianCalendar persian = new PersianCalendar();
            Console.WriteLine("--- Persian Calendar ---");
            Console.WriteLine("Date in Persian Calendar: {0:d2}/{1:d2}/{2:d4}", persian.GetMonth(nowDate), persian.GetDayOfMonth(nowDate), persian.GetYear(nowDate));
            Program.Space();
        }

        private static void ToThaiBuddhistCalendar(DateTime nowDate)
        {
            ThaiBuddhistCalendar thaiBuddhist = new ThaiBuddhistCalendar();
            Console.WriteLine("--- Thai Buddhist Calendar ---");
            Console.WriteLine("Date in Thai Buddhist Calendar: {0:d2}/{1:d2}/{2:d4}", thaiBuddhist.GetMonth(nowDate), thaiBuddhist.GetDayOfMonth(nowDate), thaiBuddhist.GetYear(nowDate));
            Program.Space();
        }

        private static void ToUmAlQuraCalendar(DateTime nowDate)
        {
            UmAlQuraCalendar umAlQura = new UmAlQuraCalendar();
            Console.WriteLine("--- UmAlQura Calendar ---");
            Console.WriteLine("Date in UmAlQura Calendar: {0:d2}/{1:d2}/{2:d4}", umAlQura.GetMonth(nowDate), umAlQura.GetDayOfMonth(nowDate), umAlQura.GetYear(nowDate));
            Program.Space();
        }

        private static void ToJapaneseCalendar(DateTime nowDate)
        {
            JapaneseCalendar japanese = new JapaneseCalendar();
            Console.WriteLine("--- Japanese Calendar ---");
            Console.WriteLine("Date in Japanese Calendar: {0:d2}/{1:d2}/{2:d4}", japanese.GetMonth(nowDate), japanese.GetDayOfMonth(nowDate), japanese.GetYear(nowDate));
            Program.Space();
        }





    }
}
