using System;
namespace CSharp_CheatSheet.MathFunctions.Methods.HyperbolicMathMethods
{
    public class SinhCosh
    {
        public static void SinhCoshMain()
        {
            Console.WriteLine("--- SinhCosh ---");
            Console.WriteLine("Hyperbolic Math.Sinh(double) and Math.Cosh(double)");
            Console.WriteLine("   cosh^2(X) - sinh^2(X) == 1\n" +"   sinh(2 * X) == 2 * sinh(X) * cosh(X)");
            Console.WriteLine("   cosh(2 * X) == cosh^2(X) + sinh^2(X)");

            UseSinhCosh(0.1);
            UseSinhCosh(1.2);
            UseSinhCosh(4.9);

            Console.WriteLine("\nEvaluate these hyperbolic identities " + "with selected values for X and Y:");
            Console.WriteLine("   sinh(X + Y) == sinh(X) * cosh(Y) + cosh(X) * sinh(Y)");
            Console.WriteLine("   cosh(X + Y) == cosh(X) * cosh(Y) + sinh(X) * sinh(Y)");

            UseTwoArgs(0.1, 1.2);
            UseTwoArgs(1.2, 4.9);
        }

        private static void UseSinhCosh(double arg)
        {
            double sinhArg = Math.Sinh(arg);
            double coshArg = Math.Cosh(arg);

            Console.WriteLine("\n                         Math.Sinh({0}) == {1:E16}\n" + "                         Math.Cosh({0}) == {2:E16}",arg, Math.Sinh(arg), Math.Cosh(arg));
            Console.WriteLine("(Math.Cosh({0}))^2 - (Math.Sinh({0}))^2 == {1:E16}", arg, coshArg * coshArg - sinhArg * sinhArg);

            Console.WriteLine("                         Math.Sinh({0}) == {1:E16}", 2.0 * arg, Math.Sinh(2.0 * arg));
            Console.WriteLine("    2 * Math.Sinh({0}) * Math.Cosh({0}) == {1:E16}", arg, 2.0 * sinhArg * coshArg);

            Console.WriteLine("                         Math.Cosh({0}) == {1:E16}", 2.0 * arg, Math.Cosh(2.0 * arg));
            Console.WriteLine("(Math.Cosh({0}))^2 + (Math.Sinh({0}))^2 == {1:E16}", arg, coshArg * coshArg + sinhArg * sinhArg);
        }

        private static void UseTwoArgs(double argX, double argY)
        {
            Console.WriteLine("\n        Math.Sinh({0}) * Math.Cosh({1}) +\n" + "        Math.Cosh({0}) * Math.Sinh({1}) == {2:E16}", argX, argY, Math.Sinh(argX) * Math.Cosh(argY) + Math.Cosh(argX) * Math.Sinh(argY));
            Console.WriteLine("                         Math.Sinh({0}) == {1:E16}", argX + argY, Math.Sinh(argX + argY));

            Console.WriteLine("        Math.Cosh({0}) * Math.Cosh({1}) +\n" + "        Math.Sinh({0}) * Math.Sinh({1}) == {2:E16}", argX, argY, Math.Cosh(argX) * Math.Cosh(argY) + Math.Sinh(argX) * Math.Sinh(argY));
            Console.WriteLine("                        Math.Cosh({0}) == {1:E16}", argX + argY, Math.Cosh(argX + argY));
        }
    }
}
