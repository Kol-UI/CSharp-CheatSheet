using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQAdvancedMenu
    {
        public static void LinqAvancedMenuFunctions()
        {
            Program.Space();
            Console.WriteLine("Which LINQ Avanced Part ? \n");
            var LINQAdvancedSelect = Console.ReadLine();
            int Selection = int.Parse(LINQAdvancedSelect);
            switch (Selection)
            {
                case 1:
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    LinqAvancedMenuFunctions();
                    break;
            }
        }
    }
}