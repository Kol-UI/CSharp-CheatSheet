using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading;

namespace CSharp_CheatSheet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // dotnet run
            // Exercise 17
            


            // Student collection
            IList<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Marc",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } ,
                new Student() { StudentID = 6, StudentName = "Paul", Age = 17} ,
                new Student() { StudentID = 7, StudentName = "Tom",  Age = 22 } ,
                new Student() { StudentID = 8, StudentName = "Bob",  Age = 19 } ,
                new Student() { StudentID = 9, StudentName = "Michel" , Age = 32} ,
                new Student() { StudentID = 10, StudentName = "Leo" , Age = 7 },
                new Student() { StudentID = 10, StudentName = "Pierre" , Age = 17 },
                new Student() { StudentID = 10, StudentName = "Patrick" , Age = 18 },
                new Student() { StudentID = 11, StudentName = "Kevin" , Age = 22 }, // For Group by ID
                new Student() { StudentID = 11, StudentName = "Bill",  Age = 24 }, // For Group by Name
                new Student() { StudentID = 12, StudentName = "Paul", Age = 25}, // For Group by Name
                new Student() { StudentID = 1, StudentName = "Arthur", Age = 18, StandardID = 1 } , // Standard ID
                new Student() { StudentID = 2, StudentName = "Paul",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Roger",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Max" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Clara" , Age = 19, StandardID = 3 } ,
            };

            // Template
            // Function.TestFunction(studentList); 
            Space();
            AskExercise(studentList);

        }

        public static void Space()
        {
            System.Console.WriteLine();
        }

        public static void AskExercise(IList<Student> studentList)
        {
            Space();
            Console.WriteLine("Which Exercise ? \n1) User Input\n2) Basic Maths\n3) Swap Variables\n4) Input Maths\n5) Multiplication Table\n6) Containers\n7) Compare Number\n8) Convert Celsius\n9) Word Modifications\n10) LINQ Functions");
            var exerciseInput = Console.ReadLine();
            int valueInput = int.Parse(exerciseInput);
            switch (valueInput)
            {
                case 1:
                    InputExercise();
                    AskExercise(studentList);
                    break;
                case 2:
                    BasicMaths();
                    AskExercise(studentList);
                    break;
                case 3:
                    SwapVariable();
                    SecondSwap();
                    AskExercise(studentList);
                    break;
                case 4:
                    InputMultiplication();
                    AskExercise(studentList);
                    break;
                case 5:
                    MultiplicationTable();
                    AskExercise(studentList);
                    break;
                case 6:
                    ContainerFunction();
                    AskExercise(studentList);
                    break;
                case 7:
                    CompareNumber();
                    AskExercise(studentList);
                    break;
                case 8:
                    ConvertKelvinToFahrenheit();
                    AskExercise(studentList);
                    break;
                case 9:
                    WordModif();
                    AskExercise(studentList);
                    break;
                case 10:
                    LINQMainMenu.LinqFunctions(studentList);
                    AskExercise(studentList);
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    AskExercise(studentList);
                    break;
            }
        }

        public static void BasicMaths()
        {
            Sum();
            Divide();
            MoreMaths();
        }

        public static void Sum()
        {
            System.Console.WriteLine("Sum:");
            System.Console.WriteLine(15+17);
            Space();
        }

        public static void Divide()
        {
            System.Console.WriteLine("Divide:");
            System.Console.WriteLine(36/6);
            Space();
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
            Space();
        }

        public static void InputExercise()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            Space();
        }

        public static void SwapVariable()
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " +number1);
            Console.Write("\nSecond Number : " +number2);
            // Console.Read();
            Space();
        }

        public static void SecondSwap()
        {
            Space();
            Console.WriteLine("First Number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int B = Convert.ToInt32(Console.ReadLine());
            int SWAP1 = A;
            int SWAP2 = B;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("THE FIRST NUMBER IS " + A);
            Console.WriteLine("THE SECOND NUMBER IS " + B);
            Console.WriteLine("---------------------------\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AFTER SWAPPING: \n");
            Console.WriteLine("FIRST NUMBER IS " + SWAP2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SECOND NUMBER IS " + SWAP1);
            ColorReset();
            Space();
        }

        public static void ColorReset()
        {
            Console.ResetColor();
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
            Space();

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
            Console.WriteLine(result);
            Space();
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
            Space();
            Console.WriteLine("Input number to multiply:");
            int number =int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }

        public static void ContainerFunction()
        {
            // !
            int NumberStart = 0, NumberStop = 16; // !
            // NumberStop = Number of things at the end /2

            Random rnd = new Random();
            string[] surarray = { "1", "2", "3", "4", "5", "6", "7", "8" }; // Number of list
            List<string> list1 = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };
            List<string> list2 = new List<string>() { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10" };
            List<string> list3 = new List<string>() { "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10" };
            List<string> list4 = new List<string>() { "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10" };
            List<string> list5 = new List<string>() { "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "E10" };
            List<string> list6 = new List<string>() { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10" };
            List<string> list7 = new List<string>() { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10" };
            List<string> list8 = new List<string>() { "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10" };
            List<string> containerlist1 = new List<string>();
            List<string> containerlist2 = new List<string>();
            int surIndex, Index;
            int a, plus, less;

            while (NumberStart < NumberStop)
            {
                surIndex = rnd.Next(0, surarray.Length);
                switch (surIndex)
                {
                    case 0:
                        Index = rnd.Next(0, list1.Count);
                        containerlist1.Add(list1[Index].ToString());
                        list1.Remove(list1[Index]);
                        break;
                    case 1:
                        Index = rnd.Next(0, list2.Count);
                        containerlist1.Add(list2[Index].ToString());
                        list2.Remove(list2[Index]);
                        break;
                    case 2:
                        Index = rnd.Next(0, list3.Count);
                        containerlist1.Add(list3[Index].ToString());
                        list3.Remove(list3[Index]);
                        break;
                    case 3:
                        Index = rnd.Next(0, list4.Count);
                        containerlist1.Add(list4[Index].ToString());
                        list4.Remove(list4[Index]);
                        break;
                    case 4:
                        Index = rnd.Next(0, list5.Count);
                        containerlist1.Add(list5[Index].ToString());
                        list1.Remove(list5[Index]);
                        break;
                    case 5:
                        Index = rnd.Next(0, list6.Count);
                        containerlist1.Add(list6[Index].ToString());
                        list2.Remove(list6[Index]);
                        break;
                    case 6:
                        Index = rnd.Next(0, list7.Count);
                        containerlist1.Add(list7[Index].ToString());
                        list3.Remove(list7[Index]);
                        break;
                    case 7:
                        Index = rnd.Next(0, list8.Count);
                        containerlist1.Add(list8[Index].ToString());
                        list4.Remove(list8[Index]);
                        break;
                    default:
                        Console.WriteLine("Autre");
                        break;
                }
                NumberStart += 1;
            }
            Console.WriteLine(String.Join(" - ", containerlist1));
            a = containerlist1.Count();
            while (a > 0)
            {
                less = rnd.Next(0, containerlist1.Count);
                Console.WriteLine("Less: " + containerlist1[less]);
                containerlist1.Remove(containerlist1[less]);
                plus = rnd.Next(0, containerlist1.Count);
                if (plus == less) // while
                {
                    plus = rnd.Next(0, containerlist1.Count);
                    // Console.WriteLine(" RESULTS1: " + String.Join(" - ", containerlist2));
                }
                Console.WriteLine("Plus: " + containerlist1[plus]);
                containerlist2.Add(containerlist1[plus]);
                containerlist1.Remove(containerlist1[plus]);
                Console.WriteLine(" Container list 1: " + String.Join(" - ", containerlist1));
                Console.WriteLine(" Container list 2: " + String.Join(" - ", containerlist2));
                Thread.Sleep(2000);
                a = a - 2;
            };
            Console.WriteLine();
            Console.WriteLine(" RESULTS: " + String.Join(" - ", containerlist2));
        }

        public static void CompareNumber()
        {
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            string answer = (new Random().Next(0, 2) < 1) ? "older" : "younger";
            Console.WriteLine("You look {0} than {1}", answer, age);
            Space();
        }

        public static void ConvertKelvinToFahrenheit()
        {
            Console.Write("Type temperature in Celsius: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int K = C + 273;
            int F = (C * 9 / 5 + 32);
            Console.Write("Temperature in Kalvin is: {0} and Temperature in Fahrenheit is: {1}" , K, F);
            Space();
        }

        public static void WordModif()
        {
            Space();
            Console.WriteLine("Which Function ? \n1) Remove a letter\n2) Change first and last letter");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1:
                    RemoveLetter();
                    break;
                case 2:
                    ChangeFirstAndLast();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    WordModif();
                    break;
            }
            Space();
        }

        public static void RemoveLetter()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the letter of the word you want removed");
            string letter = Console.ReadLine();
            int charPos = word.IndexOf($"{letter}");
            Console.WriteLine("Result: " + word.Remove(charPos, 1));
        }

        public static void ChangeFirstAndLast()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Result:" + $"{word[word.Length-1]}" + $"{word.Substring(1,word.Length-2)}" + $"{word[0]}");
        }


    }
}
