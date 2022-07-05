using System;
using CSharp_CheatSheet.DateTimeFunctions;

namespace CSharp_CheatSheet.Menus.DateTimeMenus
{
    public class DateTimeMainMenu
    {
        public static void MainMethod()
        {
            Program.Space();
            Console.WriteLine("Which DateTime ?\n1) Initialization Examples\t2) Formatting DateTime as Strings");
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
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
