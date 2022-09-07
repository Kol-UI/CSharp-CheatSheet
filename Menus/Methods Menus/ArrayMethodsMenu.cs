using System;
namespace CSharp_CheatSheet.Menus.MethodsMenus
{
    public class ArrayMethodsMenu
    {
        public static void MenuArrayMethods()
        {
            Program.Space();
            Console.WriteLine("Which Array Method ?\n1) AsReadOnly \t2) ");
            var MathInput = Console.ReadLine();
            int valueMathInput = int.Parse(MathInput);
            switch (valueMathInput)
            {
                case 1:
                    Methods.ArrayMethods.AsReadOnly.AsReadOnlyFunction();
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
