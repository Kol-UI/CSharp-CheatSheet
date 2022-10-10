using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class GetValue
    {
        public static void GetValueMain()
        {
            Program.Title("GetValue");
            Program.Space();
            Int32Method();
            Program.Space();
            Int64Method();
            Program.Space();
            MultiDimentional();
        }

        private static void Int32Method()
        {
            char[] arr = new char[] { 'A', 'B', 'C', 'D' };
            Console.WriteLine("element at index 3 is : " + arr.GetValue(3));
            Console.WriteLine("element at index 1 is : " + arr.GetValue(1));
            Console.WriteLine("element at index 2 is : " + arr.GetValue(2));
            Console.WriteLine("element at index 0 is : " + arr.GetValue(0));
        }

        private static void Int64Method()
        {
            string[] arr = new string[5];    
            arr.SetValue("C++", 0);
            arr.SetValue("Java", 1);
            arr.SetValue("C#", 2);
            arr.SetValue("Perl", 3);
            arr.SetValue("Python", 4);

            Console.WriteLine("element at index 3 is : " + arr.GetValue(3));
            Console.WriteLine("element at index 1 is : " + arr.GetValue(1));
            Console.WriteLine("element at index 2 is : " + arr.GetValue(2));
            Console.WriteLine("element at index 0 is : " + arr.GetValue(0));
            Console.WriteLine("element at index 0 is : " + arr.GetValue(4));
        }

        private static void MultiDimentional()
        {
            String[] myArr1 = new String[5];
            myArr1.SetValue("three", 3);
            Console.WriteLine("[3]:   {0}", myArr1.GetValue(3));

            String[,] myArr2 = new String[5, 5];

            myArr2.SetValue("one-three", 1, 3);
            Console.WriteLine("[1,3]:   {0}", myArr2.GetValue(1, 3));

            String[,,] myArr3 = new String[5, 5, 5];

            myArr3.SetValue("one-two-three", 1, 2, 3);
            Console.WriteLine("[1,2,3]:   {0}", myArr3.GetValue(1, 2, 3));

            String[,,,,,,] myArr7 = new String[5, 5, 5, 5, 5, 5, 5];

            int[] myIndices = new int[7] { 1, 2, 3, 0, 1, 2, 3 };
            myArr7.SetValue("one-two-three-zero-one-two-three", myIndices);
            Console.WriteLine("[1,2,3,0,1,2,3]:   {0}", myArr7.GetValue(myIndices));
        }
    }
}
