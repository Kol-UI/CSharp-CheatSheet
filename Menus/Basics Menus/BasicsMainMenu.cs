using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class BasicsMainMenu
    {
        // Main Basics Menu
        public static void BasicsMain()
        {
            Program.Space();
            Console.WriteLine("Which Basics ? \n1) User Input\t2) Basic Maths\t3) Conditional Statements");
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
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7: 
                    break;
                case 8: 
                    break;
                case 9: 
                    break;    
                case 10: 
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