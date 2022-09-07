using System;
namespace CSharp_CheatSheet.Menus.MethodsMenus
{
    public class MainMenuMethods
    {
        public static void MethodsMainMenu()
        {
            Program.Space();
            Console.WriteLine("Which Methods ?\n1) Array\n2) -");
            var MathInput = Console.ReadLine();
            int valueMathInput = int.Parse(MathInput);
            switch (valueMathInput)
            {
                case 1:
                    ArrayMethodsMenu.MenuArrayMethods();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
