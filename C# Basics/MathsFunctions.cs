using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class MathsFunctions
    {
        public static void BasicMaths()
        {
            Program.Space();
            Console.WriteLine("Which Maths Function ?");
            Console.WriteLine("1) Sum\t2) Divide\t3) MoreMaths\t4) InputMultiplication\t5) MoreInputMaths\t6) MultiplicationTable");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1: // Sum
                    Sum();
                    break;
                case 2: // Divide
                    Divide();
                    break;
                case 3: // MoreMaths
                    MoreMaths();
                    break;
                case 4: // InputMultiplication
                    InputMultiplication();
                    break;
                case 5: // MoreInputMaths
                    MoreInputMaths();
                    break;
                case 6: // MultiplicationTable
                    MultiplicationTable();
                    break;
                case 7: // 
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }

        }

        private static void Sum()
        {
            System.Console.WriteLine("Sum:");
            System.Console.WriteLine(15+17);
            Program.Space();
        }

        private static void Divide()
        {
            System.Console.WriteLine("Divide:");
            System.Console.WriteLine(36/6);
            Program.Space();
        }

        private static void MoreMaths()
        {
            int num1 = -1 + 4 * 6;
            int num2 = (35 + 5) % 7;
            double num3 = 14 + -4 * 6 / 11;
            double num4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}");

            int[] num = new int[3];
            Console.WriteLine("Enter 3 numbers: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y +y.z is {4}", num[0], num[1], num[2], (num[0] + num[1]) * num[2], num[0] * num[1] + num[1]*num[2]);
            Program.Space();
        }

        private static void InputMultiplication()
        {
            // Way 1
            int num1, num2, num3;
            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}", num1, num2, num3, result);
            Program.Space();

            // Way 2
            int[] numArray = new int[3];
            int result2 = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter {i+1} number: ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in numArray)
            {
                result2 *= item;
            }
            Console.WriteLine(result2);
            Program.Space();
            MoreInputMaths();
        }

        private static void MoreInputMaths()
        {
            Console.Write("Enter a number: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
            Console.WriteLine("The result of adding is: " + (num1 + num2));
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
            Console.WriteLine("The result of subtracting is: " + (num1 - num2));
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
            Console.WriteLine("The result of multiplying is: " + num1 * num2 );
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
            Console.WriteLine("The result of dividing is: " + num1 / num2 );
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
            Console.WriteLine("The result of mod is: " + num1 % num2 );
        }

        private static void MultiplicationTable()
        {
            Program.Space();
            Console.WriteLine("Input number to multiply:");
            int number =int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }

        
    }

}