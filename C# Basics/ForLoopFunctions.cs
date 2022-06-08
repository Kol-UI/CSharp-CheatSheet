using System;
using System.Collections.Generic;

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
            int i,j,n;
            Console.WriteLine("--- Many Multiplication Tables ---");
            Console.Write("Tables from 1 to : ");
            n = Convert.ToInt32(Console.ReadLine());   
            Console.Write("Multiplication table from 1 to {0} \n",n);
            for(i=1;i<=10;i++)
            {
                for(j=1;j<=n;j++)
                {
                if (j<=n-1)
                    Console.Write("{0}x{1} = {2}, ",j,i,i*j);
                    else
                    Console.Write("{0}x{1} = {2}",j,i,i*j);

                }
                Console.Write("\n");
                }
        }
 
    }

}