using System;
using System.Collections.Generic;
using System.Linq;
using CSharp_CheatSheet.CBasics;
using CSharp_CheatSheet.Menus.BasicsMenus;

namespace CSharp_CheatSheet
{
    public class BasicsMainMenu
    {
        // Main Basics Menu
        public static void BasicsMain()
        {
            Program.Space();
            Console.WriteLine("Which Basics ? \n1) User Input\t2) Basic Maths\t3) Conditional Statements  4) Remove Diacritics  5) For Loop  6) Array  7) Search & Sort" +
                "  8) Random  9) Recursion  10) Naming Conventions");
            var BasicsInput = Console.ReadLine();
            int valueBasicsInput = int.Parse(BasicsInput);
            switch (valueBasicsInput)
            {
                case 1:
                    BasicsInputMenu.MenuInput();
                    break;
                case 2:
                    BasicsMathsMenu.BasicsMaths();
                    break;
                case 3:
                    BasicsConditionalMenu.MenuInputConditional();
                    break;
                case 4:
                    RemoveDiacritics.DiacriticsMain();
                    break;
                case 5:
                    BasicsForLoopMenu.MenuForInput();
                    break;
                case 6:
                    BasicsArrayMenu.MenuInputArray();
                    break;
                case 7:
                    BasicsSearchSortMenu.SearchSortMenu();
                    break;
                case 8:
                    RandomFunctions.RandomFunctionsMain();
                    break;
                case 9:
                    RecursionFunctions.RecursionMain();
                    break;    
                case 10:
                    NamingConventions.NamingConventionsMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    BasicsMain();
                    break;
            }
            Program.Space();
        }
    }

}