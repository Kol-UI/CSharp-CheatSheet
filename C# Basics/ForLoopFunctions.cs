using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ForLoopFunctions
    {
        public static void MultiplicationTable(){
            int j,n;
            Console.WriteLine("--- Multiplication Table ---");
            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());   
            Console.Write("\n");
            for(j=1;j<=10;j++)
            {
                Console.Write("{0} X {1} = {2} \n",n,j,n*j);
            }
        }

        public static void ManyMutiplicationTable(){
            int i, j, n;
            Console.WriteLine("--- Many Multiplication Tables ---");
            Console.Write("Tables from 1 to : ");
            n = Convert.ToInt32(Console.ReadLine());   
            Console.Write("Multiplication table from 1 to {0} \n",n);
            for(i = 1; i <= 10; i++)
            {
                for(j = 1; j <= n; j++)
                {
                if (j <= n - 1)
                    Console.Write("{0}x{1} = {2}, ",j,i,i*j);
                    else
                    Console.Write("{0}x{1} = {2}",j,i,i*j);

                }
                Console.Write("\n");
                }
        }

        public static void AsteriskPatternLoop(){
            int i, rows;
            Console.WriteLine("--- Triangle Asterisk ---");
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
            }
        }

        public static void NumbersTrianglePattern(){
            int i, j, rows;
            Console.WriteLine("--- Triangle Numbers ---");
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void RepeatedNumberTrianglePatterns(){
            int i, j, rows;
            Console.WriteLine("--- Repeated Number on each line, Triangle Numbers ---");
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void IncreasingNumberTrianglePatterns(){
            int i, j, rows, k = 1;
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());    
            for(i = 1; i <= rows; i++)
            {
                for(j = 1; j <= i; j++)
                Console.Write("{0} ", k++);
                Console.Write("\n");
            }
        }

        public static void IncreasingNumberPyramidPatterns(){
            int i, j, spc, rows, k, t = 1;

            Console.Write("input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());    
            spc = rows + 3;
            for(i = 1; i <= rows; i++)
            {
                for(k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= i; j++)
                Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;
            }
        }
 
    }

}