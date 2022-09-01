using System;

namespace CSharp_CheatSheet.Menus.MathMenus
{
    public class MathMethodsMenu
    {
        public static void MenuMathMethods()
        {
            Program.Space();
            Console.WriteLine("Which Math Methods Category ?\n1) Basics\n2) Pow & Logarithmic Methods \n3) Trigonometric Methods \n4) Hyperbolic Methods");
            var MathMethodsInput = Console.ReadLine();
            int valueMathMethodsInput = int.Parse(MathMethodsInput);
            switch (valueMathMethodsInput)
            {
                case 1:
                    MenuMathMethodsBasics();
                    break;
                case 2:
                    MenuMathPowLogarithmicMethods();
                    break;
                case 3:
                    MenuMathTrigoMethods();
                    break;
                case 4:
                    MenuMathHyperbolicMethods();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void MenuMathMethodsBasics()
        {
            Program.Space();
            Console.WriteLine("Which Basic Math Method ?\n1) Abs  2) BigMul  3) BitDecrement  4) BitIncrement  5) Ceiling  6) Clamp  7) CopySign  8) DivRem  9) Floor  10) FusedMultiplyAdd\n" +
                "11) IEEERemainder  12) Max  13) MaxMagnitude  14) Min  15) MinMagnitude  16) Round  17) ScaleB  18) Sign  19) Truncate");
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
                case 11:
                    MathFunctions.Methods.BasicsMathMethods.MathIEEERemainder.MethodMathIEEERemainder();
                    break;
                case 12:
                    MathFunctions.Methods.BasicsMathMethods.MathMax.MethodMathMax();
                    break;
                case 13:
                    MathFunctions.Methods.BasicsMathMethods.MathMaxMagnitude.MethodMathMaxMagnitude();
                    break;
                case 14:
                    MathFunctions.Methods.BasicsMathMethods.MathMin.MethodMathMin();
                    break;
                case 15:
                    MathFunctions.Methods.BasicsMathMethods.MathMinMagnitude.MethodMathMinMagnitude();
                    break;
                case 16:
                    MathFunctions.Methods.BasicsMathMethods.MathRound.MethodMathRound();
                    break;
                case 17:
                    MathFunctions.Methods.BasicsMathMethods.MathScaleB.MethodMathScaleB();
                    break;
                case 18:
                    MathFunctions.Methods.BasicsMathMethods.MathSign.MethodMathSign();
                    break;
                case 19:
                    MathFunctions.Methods.BasicsMathMethods.MathTruncate.MethodMathTruncate();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }


        private static void MenuMathPowLogarithmicMethods()
        {
            Program.Space();
            Console.WriteLine("Which Pow/Logarithmic Math Method ?\n1) Exp \n2) Log \n3) Sqrt \n4) Cbrt \n5) Pow");
            var MathMethodsPowLogInput = Console.ReadLine();
            int valueMathMethodsPowLogInput = int.Parse(MathMethodsPowLogInput);
            switch (valueMathMethodsPowLogInput)
            {
                case 1:
                    MathFunctions.Methods.PowerLogarithmicMethods.Exp.ExpMain();
                    break;
                case 2:
                    MathFunctions.Methods.PowerLogarithmicMethods.Log.LogMain();
                    break;
                case 3:
                    MathFunctions.Methods.PowerLogarithmicMethods.Sqrt.SqrtMain();
                    break;
                case 4:
                    MathFunctions.Methods.PowerLogarithmicMethods.Cbrt.CbrtMain();
                    break;
                case 5:
                    MathFunctions.Methods.PowerLogarithmicMethods.Pow.PowMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void MenuMathTrigoMethods()
        {
            Program.Space();
            Console.WriteLine("Which Trigo Math Method ?\n1) Sin \n2) Cos \n3) Tan \n4) Asin \n5) Acos \n6) Atan \n7) Atan2 \n8) Trigonometric Examples");
            var MathMethodsTrigoInput = Console.ReadLine();
            int valueMathMethodsTrigoInput = int.Parse(MathMethodsTrigoInput);
            switch (valueMathMethodsTrigoInput)
            {
                case 1:
                    MathFunctions.Methods.TrigonometricMathMethods.SinMethod.SinMethodMain();
                    break;
                case 2:
                    MathFunctions.Methods.TrigonometricMathMethods.CosMethod.CosMethodMain();
                    break;
                case 3:
                    MathFunctions.Methods.TrigonometricMathMethods.TanMethod.TanMethodMain();
                    break;
                case 4:
                    MathFunctions.Methods.TrigonometricMathMethods.SinMethod.ASinMethodMain();
                    break;
                case 5:
                    MathFunctions.Methods.TrigonometricMathMethods.CosMethod.ACosMethodMain();
                    break;
                case 6:
                    MathFunctions.Methods.TrigonometricMathMethods.TanMethod.ATanMethodMain();
                    break;
                case 7:
                    MathFunctions.Methods.TrigonometricMathMethods.TanMethod.ATan2MethodMain();
                    break;
                case 8:
                    MathFunctions.Methods.TrigonometricMathMethods.TrigonometricExamples.TrigonometricExamplesMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }


        private static void MenuMathHyperbolicMethods()
        {
            Program.Space();
            Console.WriteLine("Which Trigo Math Method ?\n1) Sinh \n2) Cosh \n3) SinhCosh \n4) Tanh \n5) Asinh \n6) Acosh \n7) Atanh");
            var MathMethodsTrigoInput = Console.ReadLine();
            int valueMathMethodsTrigoInput = int.Parse(MathMethodsTrigoInput);
            switch (valueMathMethodsTrigoInput)
            {
                case 1:
                    MathFunctions.Methods.HyperbolicMathMethods.Sinh.SinhMain();
                    break;
                case 2:
                    MathFunctions.Methods.HyperbolicMathMethods.Cosh.CoshMain();
                    break;
                case 3:
                    MathFunctions.Methods.HyperbolicMathMethods.Tanh.MainTanh();
                    break;
                case 4:
                    MathFunctions.Methods.HyperbolicMathMethods.Tanh.MainTanh();
                    break;
                case 5:
                    MathFunctions.Methods.HyperbolicMathMethods.Asinh.AsinhMain();
                    break;
                case 6:
                    MathFunctions.Methods.HyperbolicMathMethods.Acosh.AcoshMain();
                    break;
                case 7:
                    MathFunctions.Methods.HyperbolicMathMethods.Atanh.AtanhMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
