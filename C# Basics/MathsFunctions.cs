using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class MathsFunctions
    {

        public static void Sum()
        {
            System.Console.WriteLine("Sum:");
            System.Console.WriteLine(15+17);
            Program.Space();
        }

        public static void Divide()
        {
            System.Console.WriteLine("Divide:");
            System.Console.WriteLine(36/6);
            Program.Space();
        }

        public static void MoreMaths()
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

        public static void InputMultiplication()
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

        public static void MoreInputMaths()
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

        public static void MultiplicationTable()
        {
            Program.Space();
            Console.WriteLine("Input number to multiply:");
            int number =int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }

        public static void CheckPosNeg()
        {
            // Way 1
            Console.WriteLine("--- Simple Way ---");
            Console.WriteLine("\nInput first integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");  
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));

            // Way 2
            Program.Space();
            Console.WriteLine("--- Second Way ---");
            Console.WriteLine(" please enter the 1th number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" plese enter the 2th number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < 0 && b > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("true " + $" ({a}) is negative and ({b}) is positive");
            }

            if (a > 0 && b < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("true " + $" ({b}) is negative and ({a}) is positive");
            }
            if (a > 0 && b > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("false " + $" both ({b}) and ({a}) are positive ");
            }

            if (a < 0 && b < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("false " + $" both ({b}) and ({a}) are negative ");
            }
            Console.ResetColor();
        }


        public static void ConditionalSum()
        {
            Console.WriteLine("Put two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            if (num1 == num2)
            {
                Console.WriteLine((num1 +num2) * sum );
            }
            else if (num1 != num2 )
                Console.WriteLine(num1+num2);
        }

        public static void SimpleCalculator()
        {
            int x, y;
            char operation;
            
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation (+ - x /): ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            
            if (operation=='+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
            else if (operation=='-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
            else if ((operation=='x') || (operation=='*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x*y);
            else if (operation=='/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x/y);
            else
                Console.WriteLine("Wrong Character");
        }

        public static void PerimeterAndAreaCircle(){
            Console.WriteLine("--- Calculate Perimeter & Radius of a circle ---");
            Console.WriteLine("Enter the radius of the circle :");
            int radius = Convert.ToInt32( Console.ReadLine());
            double perimeter = 2 * 3.14 * radius;
            Console.WriteLine("The perimeter of the circle is : " + perimeter);
            double area = 3.14 * radius * radius;
            Console.WriteLine("The area of the circle is : " + area);
        }

        public static void CalculateSpeed()
        {
            float distance;
            float hour, min, sec;
            float timeSec;
            float mps;
            float kph, mph;
            
            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());
            
            timeSec = (hour*3600) + (min*60) + sec;
            mps = distance/timeSec;
            kph = (distance/1000.0f)/(timeSec/3600.0f);
            mph = kph / 1.609f;
            
            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        
        }

        public static void SphereArea()
        {
            float r;
            float pi = 3.1415926535f;
            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());
            Console.Write("Area is: ");
            Console.WriteLine( 4 * pi * (r * r) );
        }

        public static void SphereVolume()
        {
            float r;
            float pi = 3.1415926535f;
            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());
            Console.Write("Volume is: ");
            Console.WriteLine( 4f/3f * pi * (r * r * r));
        }

        public static void DecimalToBinary()
        {
            string answer, result;
            Console.WriteLine("Input a number: ");
            answer = Console.ReadLine();
            int num = Convert.ToInt32(answer);
            result = " ";

            while (num > 1){
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }

        
    }

}