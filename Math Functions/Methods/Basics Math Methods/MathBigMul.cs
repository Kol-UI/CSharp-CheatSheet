using System;
namespace CSharp_CheatSheet.MathFunctions.Methods
{
    public class MathBigMul
    {
        public static void MethodMathBigMul()
        {
            Program.Space();
            Console.WriteLine("--- BigMul ---");
            Console.WriteLine("BigMul method returns full product (Multiplication) of two 32 bit numbers");
            Program.Space();
            Console.WriteLine("Math.BigMul(2255, 33897) = " + Math.BigMul(2255, 33897));
            Console.WriteLine("Math.BigMul(-2256, 54567) = " + Math.BigMul(-2256, 54567));
            Console.WriteLine("Math.BigMul(2123, 35688) = " + Math.BigMul(2123, 35688));
            Console.WriteLine("Math.BigMul(233232322, 189222338) = " + Math.BigMul(233232322, 189222338));
            int int1 = Int32.MaxValue;
            int int2 = Int32.MaxValue;
            long longResult;
            longResult = Math.BigMul(int1, int2);
            Console.WriteLine("Calculate the product of two Int32 Max values:");
            Console.WriteLine("{0} * {1} = {2}", int1, int2, longResult);
        }
    }
}
