using System;
namespace CSharp_CheatSheet.CBasics
{
    public class MatricesFunctions
    {
        public static void Matrices2D()
        {
            int i, j;
            int[,] Array2D = new int[3, 3];

            Console.WriteLine("--- 2D Array to Matrix ---");

            Console.WriteLine("Input elements in the matrix (int):");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Element - [{0},{1}] : ", i, j);
                    Array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Matrix is :");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", Array2D[i, j]);
                }
            }
            Program.Space();
        }


        public static void AdditionTwoMatrices()
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];

            Console.WriteLine("--- Addition of two Matrices ---");
            Console.WriteLine("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input elements in the first matrix :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The First Matrix is :");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }

            Console.WriteLine("The Second Matrix is :");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }

            // Calculate sum
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    crr1[i, j] = arr1[i, j] + brr1[i, j];
                }
            }

            Console.WriteLine("The Addition of the two matrices is :");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
            Program.Space();
        }






    }
}
