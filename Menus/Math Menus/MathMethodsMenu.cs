using System;

namespace CSharp_CheatSheet.Menus.MathMenus
{
    public class MathMethodsMenu
    {
        public static void MenuMathMethods()
        {
            Program.Space();
            Console.WriteLine("Which Math Methods Category ?\n1) Basics\n2) \n3) ");
            var MathMethodsInput = Console.ReadLine();
            int valueMathMethodsInput = int.Parse(MathMethodsInput);
            switch (valueMathMethodsInput)
            {
                case 1:
                    MenuMathMethodsBasics();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void MenuMathMethodsBasics()
        {
            Program.Space();
            Console.WriteLine("Which Basic Math Method ?\n1) Abs  2) BigMul  3) BitDecrement  4) BitIncrement  5) Ceiling  6) Clamp  7) CopySign  8) DivRem  9) Floor 10) FusedMultiplyAdd");
            var MathMethodsBasicInput = Console.ReadLine();
            int valueMathMethodsBasicInput = int.Parse(MathMethodsBasicInput);
            switch (valueMathMethodsBasicInput)
            {
                case 1:
                    MathFunctions.Methods.MathAbs.MethodMathAbs();
                    break;
                case 2:
                    MathFunctions.Methods.MathBigMul.MethodMathBigMul();
                    break;
                case 3:
                    MathFunctions.Methods.MathBitDecrement.MethodMathBitDecrement();
                    break;
                case 4:
                    MathFunctions.Methods.MathBitIncrement.MethodMathBitIncrement();
                    break;
                case 5:
                    MathFunctions.Methods.MathCeiling.MethodMathCeiling();
                    break;
                case 6:
                    MathFunctions.Methods.MathClamp.MethodMathClamp();
                    break;
                case 7:
                    MathFunctions.Methods.MathCopySign.MethodMathCopySign();
                    break;
                case 8:
                    MathFunctions.Methods.MathDivRem.MethodMathDivRem();
                    break;
                case 9:
                    MathFunctions.Methods.MathFloor.MethodMathFloor();
                    break;
                case 10:
                    MathFunctions.Methods.MathFusedMultiplyAdd.MethodMathFusedMultiplyAdd();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
