using System;
namespace CSharp_CheatSheet.DataClasses
{
    public class ClassPermut
    {
        public void SwapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void PrnPermut(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                {
                    Console.Write("{0}", list[i]);
                }
                Console.Write(" ");
            }
            else
            {
                for (i = k; i <= m; i++)
                {
                    SwapTwoNumber(ref list[k], ref list[i]);
                    PrnPermut(list, k + 1, m);
                    SwapTwoNumber(ref list[k], ref list[i]);
                }
            }
        }
    }
}



