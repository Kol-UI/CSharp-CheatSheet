using System;
using CSharp_CheatSheet.CBasics;

namespace CSharp_CheatSheet.Menus.BasicsMenus
{
    public class BasicsSearchSortMenu
    {
        public static void SearchSortMenu()
        {
            Program.Space();
            Console.WriteLine("Which Search & Sort ?\n1) Shell Sort Method\t2) Bogo Sort");
            var MatricesInput = Console.ReadLine();
            int valueMatricesInput = int.Parse(MatricesInput);
            switch (valueMatricesInput)
            {
                case 1:
                    SearchSortFunctions.ShellSortMethod();
                    break;
                case 2:
                    SearchSortFunctions.BogoSortMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
