using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading;
using CSharp_CheatSheet.Menus.DateTimeMenus;
using CSharp_CheatSheet.Menus;

namespace CSharp_CheatSheet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // dotnet run
            // Template
            // Function.TestFunction(studentList);
            Space();
            AskChapter();
        }

        public static void Space()
        {
            Console.WriteLine();
        }

        public static void Time()
        {
            Thread.Sleep(1000);
        }

        public static void Title(string StringTitle)
        {
            Space();
            Console.WriteLine("--- {0} ---", StringTitle);
        }

        public static void PrintArrayOneLine(string[] arr)
        {
            Console.Write(string.Join(", ", arr));
            Space();
        }

        public static void PrintIntArrayValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }

        public static void PrintStringArrayValues(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
        }

        public static void PrintIndexAndValues(Array array)
        {
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                Console.WriteLine("\t[{0}]:\t{1}", i, array.GetValue(i));
            }
        }

        public static void PrintValues(Array arr)
        {
            IEnumerator myEnumerator = arr.GetEnumerator();
            int i = 0;
            int cols = arr.GetLength(arr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("\t{0}", myEnumerator.Current);
            }
            Console.WriteLine();
        }

        public static void AskChapter()
        {
            Space();
            Console.WriteLine("Which Chapter ? \n1) C# Basics\n2) DateTime\n3) Math\n4) Methods\n5) Regular Expressions\n6) Exceptions \n7) Containers\n8) Compare Number\n9) Convert Celsius\n10) LINQ Functions");
            var exerciseInput = Console.ReadLine();

            int valueInput = int.Parse(exerciseInput);
            switch (valueInput)
            {
                case 1: // C# Basics
                    BasicsMainMenu.BasicsMain();
                    AskChapter();
                    break;
                case 2: // DateTime
                    DateTimeMainMenu.MainMethod();
                    AskChapter();
                    break;
                case 3: // Math
                    Menus.MathMenus.MainMathMenu.MathMainMenu();
                    AskChapter();
                    break;
                case 4: // Methods
                    Menus.MethodsMenus.MainMenuMethods.MethodsMainMenu();
                    AskChapter();
                    break;
                case 5: // Regular Expressions
                    RegularMainMenu.RegularMainMethod();
                    AskChapter();
                    break;
                case 6: // Exceptions
                    Menus.ExceptionsMenus.MainExceptionsMenu.ExceptionsMenu();
                    AskChapter();
                    break;
                case 7:
                    ContainerFunction();
                    AskChapter();
                    break;
                case 8:
                    CompareNumber();
                    AskChapter();
                    break;
                case 9:
                    ConvertKelvinToFahrenheit();
                    AskChapter();
                    break;
                case 10: // LINQ
                    LINQMainMenu.LinqFunctions();
                    AskChapter();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    AskChapter();
                    break;
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
                        Console.WriteLine("Other");
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

        

    }
}
