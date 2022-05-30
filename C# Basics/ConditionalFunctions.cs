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

        public static void CheckVowelOrConsonant(){
            Program.Space();
            Console.WriteLine("--- Checking if the letter is a Vowel or a Consonant ---");
            Console.WriteLine("Please input a letter:");
            ConsoleKeyInfo key = Console.ReadKey();
            Program.Space();

            if ("aeiouy".IndexOf(key.KeyChar) != -1)
            {
                Console.WriteLine("Its a vowel.");
            }
            else if (key.KeyChar >= '0' && key.KeyChar <= '9')
            {
                Console.WriteLine("\n It's a digit.");
            }
            else
            {
                Console.WriteLine("Its a consonant.");
            }
            Program.Space();
        }

        public static void ProfitAndLoss(){
            Program.Space();
            Console.WriteLine("--- Calculating the Profit and Loss of a transaction ---");
            Console.WriteLine("Enter a cost price:");
            int costPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a selling price:");
            int sellingPrice = int.Parse(Console.ReadLine());
            int amount = sellingPrice - costPrice;

            if (amount > 0)
            {
                Console.WriteLine("You made a profit of {0}", amount);
                int percentage = ((sellingPrice - costPrice) / costPrice) * 10;
                string percentageString = percentage.ToString("0.00%");
                Console.WriteLine(percentageString);
                Console.WriteLine("+" + percentage + "%");

                if (percentage < 10){
                    Console.WriteLine("You made a F grade profit, which is a Fail (under 10% of profit).");
                }
                else if (10 <= percentage && percentage <= 20){
                    Console.WriteLine("You made a E grade profit, which is Average (between 10% and 20% of profit).");
                }
                else if (20 < percentage && percentage <= 30){
                    Console.WriteLine("You made a D grade profit, which is Correct (between 21% and 30% of profit).");
                }
                else if (30 < percentage && percentage <= 40){
                    Console.WriteLine("You made a B grade profit, which is Good (between 31% and 40% of profit).");
                }
                else if (40 < percentage && percentage <= 50){
                     Console.WriteLine("You made a A grade profit, which is Very Good (between 41% and 50% of profit).");
                }
                else if (percentage > 50){
                    Console.WriteLine("You made a S grade profit, which is Excellent (more than 50% of profit).");
                }
                else {
                    Console.WriteLine("test");
                }
            }
            else if (sellingPrice == costPrice)
            {
                Console.WriteLine("No profit and no loss.");
            }
            else if (sellingPrice < costPrice)
            {
                Console.WriteLine("You made a loss of {0}", amount);
            }
            Program.Space();
        }


 
    }

}