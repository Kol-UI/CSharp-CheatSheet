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
        }

    }
}
