using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ConditionalFunctions
    {
        public static void TemperatureStatement(){
            int tmp;
            Console.WriteLine("Accept temperature and display message.\nEnter a temperature: ");
            tmp = Convert.ToInt32(Console.ReadLine());

            switch (tmp){
                case (< 0):
                    Console.WriteLine("Freezing");
                    break;
                case >= 0 and < 10:
                    Console.WriteLine("Very Cold");
                    break;
                case >= 10 and < 13:
                    Console.WriteLine("Cold");
                    break;
                case >= 13 and < 20:
                    Console.WriteLine("Normal");
                    break;
                case >= 20 and < 30:
                    Console.WriteLine("It's Hot");
                    break;
                case (>= 30):
                    Console.WriteLine("It's Very Hot");
                    break;
            }
        }

        public static void TriangleType(){
            int angA, angB, angC, sum;
            Console.WriteLine("--- Check Triangle Type ---");

            Console.WriteLine("Input Angle A: ");
            angA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Angle B: ");
            angB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Angle C: ");
            angC = Convert.ToInt32(Console.ReadLine());

            sum = angA + angB + angC;
            if(sum == 180){
                Console.WriteLine("Triangle valid.");
                if (angA == angB && angB == angC){
                    Console.WriteLine("It's an Equilateral Triangle.");
                }
                else{
                    if (angA == angB || angA == angC ||angB == angC){
                        Console.WriteLine("It's an Isocele Triangle.");
                    }
                    else{
                        Console.WriteLine("It's a Scalene Triangle.");
                    }
                }
            }
            else{
                Console.WriteLine("Triangle not valid (total shoud be 180).");
            }
        }
        
    }

}