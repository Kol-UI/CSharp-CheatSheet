using System;

namespace CSharp_CheatSheet.MathFunctions.Fields
{
    public class MathE
    {
        public static void MathEMethod()
        {
            Program.Space();
            Console.WriteLine("--- E ---");
            Program.Space();
            CalcPowerSeries();
            Program.Space();
            Program.Space();
            double E = Math.E;
            Console.WriteLine("Math.E = " + E);
        }

        static void CalcPowerSeries()
        {
            double factorial = 1.0;
            double PS = 0.0;

            for (int n = 0; n < 999 && Math.Abs(Math.E - PS) > 1.0E-15; n++)
            {
                if (n > 0)
                {
                    factorial *= (double)n;
                }

                PS += 1.0 / factorial;
                Console.WriteLine("PS({0:D2}) == {1:E16},  Math.E - PS({0:D2}) == {2:E16}", n, PS, Math.E - PS);
            }
        }
    }
}
