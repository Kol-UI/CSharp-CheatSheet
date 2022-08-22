using System;

namespace CSharp_CheatSheet.Menus.MathMenus
{
    public class MainMathMenu
    {
        public static void MathMainMenu()
        {
            Program.Space();
            Console.WriteLine("Which Math ?\n1) Fields\n2) Methods");
            var MathInput = Console.ReadLine();
            int valueMathInput = int.Parse(MathInput);
            switch (valueMathInput)
            {
                case 1:
                    MathFieldsMenu.MenuMathFields();
                    break;
                case 2:
                    MathMethodsMenu.MenuMathMethods();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}