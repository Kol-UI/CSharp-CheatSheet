using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class GetLongLength
    {
        public static void GetLongLengthMain()
        {
            Program.Title("GetLongLengthMain");
            Program.Space();
            int[,,] arr = new int[,,] {
                                      { { 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 6, 7, 8 }

                                      },

                                      { { 11, 12, 13 },
                                        { 14, 15, 16 },
                                        { 17, 18, 19 }
                                      },

                                      { { 21, 22, 23 },
                                        { 24, 25, 26 },
                                        { 27, 28, 29 }
                                      },
                                    };

            Console.Write("Total Number of Elements in"+ " first dimension of arr: ");

            Console.Write(arr.GetLongLength(0));

            Console.WriteLine("\nType of returned Length: "+ arr.GetLongLength(0).GetType());

            Console.Write("\nTotal Number of Elements in "+ "second dimension of arr: ");

            Console.Write(arr.GetLength(1));

            Console.WriteLine("\nType of returned Length: "+ arr.GetLength(1).GetType());

            Console.Write("\nTotal Number of Elements in "+ "second dimension of arr: ");

            Console.Write(arr.GetLongLength(1));

            Console.WriteLine("\nType of returned Length: "+ arr.GetLongLength(1).GetType());
        }
    }
}
