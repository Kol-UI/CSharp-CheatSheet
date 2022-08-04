using System;
namespace CSharp_CheatSheet.DataClasses
{
    public class DecimalToBinaryClass
    {
        public int DecimalToBinary(int num)
        {
            int bin;
            if (num != 0)
            {
                bin = (num % 2) + 10 * DecimalToBinary(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }

        }
    }
}
