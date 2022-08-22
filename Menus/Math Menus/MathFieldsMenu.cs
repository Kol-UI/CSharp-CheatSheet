using System;

namespace CSharp_CheatSheet.Menus.MathMenus
{
    public class MathFieldsMenu
    {
        public static void MenuMathFields()
        {
            Program.Space();
            Console.WriteLine("Which Math Field ?\n1) E\n2) PI\n3) Tau");
            var MathFieldsInput = Console.ReadLine();
            int valueMathFieldsInput = int.Parse(MathFieldsInput);
            switch (valueMathFieldsInput)
            {
                case 1:
                    MathFunctions.Fields.MathE.MathEMethod();
                    break;
                case 2:
                    MathFunctions.Fields.MathPI.MainMathPI();
                    break;
                case 3:
                    MathFunctions.Fields.MathTau.MainMathTau();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
