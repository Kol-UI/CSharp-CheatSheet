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
            };

            Function.TestFunction(studentList);
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
                    LinqFunctions(studentList);
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




        // LINQ Functions
        public static void LinqFunctions(IList<Student> studentList)
        {
            Space();
            Console.WriteLine("Which LINQ Function ? \n1) Basic LINQ\n2) Find Positive\n3) Find Number after specifics calculations\n4) Frequency\n5) Query Syntaxe\n6) Operators List");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1:
                    BasicLINQ();
                    BasicLINQOneLine();
                    BasicLINQOneLineTwo();
                    break;
                case 2:
                    FindPositive();
                    break;
                case 3:
                    LINQCalculations();
                    break;
                case 4:
                    FrequencyFunction();
                    break;
                case 5:
                    QuerySyntaxeQuestions();
                    break;
                case 6:
                    LINQOperators(studentList);
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    LinqFunctions(studentList);
                    break;
            }
            Space();
        }

        public static void BasicLINQ()
        {
            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("\nBasic structure of LINQ : "); 
            Console.Write("\n---------------------------");
            // The second part is Query creation.
            // nQuery is an IEnumerable<int>
            var nQuery =
                from VrNum in n1
                where (VrNum % 2) == 0
                select VrNum;
            // The third part is Query execution.
            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
        }

        public static void BasicLINQOneLine()
        {
            Space();
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            nums.Where(x => x % 2 == 0).ToList().ForEach(a => Console.Write(a + " "));
        }

        public static void BasicLINQOneLineTwo()
        {
            Space();
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(n1.Where(x => x % 2 == 0).Aggregate("", (c, v) => $"{c} {v}"));
        }

        public static void FindPositive()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : "); 
            Console.Write("\n---------------");
            var nQuery = from VrNum in n1 where VrNum > 0 where VrNum < 11 select VrNum;  
            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");			
            foreach(var VrNum in nQuery)
            {
               Console.Write("{0}  ", VrNum);
            }

            List<int> numbers = new List<int>();
            for (int i=-10; i<= 20; i++){
                numbers.Add(i);
            }
            //Part 2: Query creation
            var numQuery = from numAnswer in numbers
            where numAnswer >= 0
            select numAnswer;
            //Part 3: Query Execution
            foreach (int numAnswer in numQuery){
                Console.WriteLine(numAnswer);
            }
        }

        public static void LINQCalculations(){
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : "); 
            Console.Write("\n------------------------------------------------------------------------\n");	
            var sqNo = from int Number in arr1
                            let SqrNo = Number * Number
                            where SqrNo > 20
                            select new { Number, SqrNo };
            foreach (var a in sqNo)
                Console.WriteLine(a);
        }

        public static void FrequencyFunction(){
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };  
            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n"); 
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("The numbers in the array are : \n");
            // Print a array in 1 line
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            var n = from x in arr1  
                    group x by x into y  
                    select y;  
                    Console.WriteLine("\nThe number and the Frequency are : \n"); 
                    foreach (var arrNo in n){  
                        Console.WriteLine("Number "+arrNo.Key + " appears " + arrNo.Count()+" time(s)");  
                    }

            // Other way
            Console.Write("\nOther way :\n");
            int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2, 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
            var z = arr2.GroupBy(n=> n).Select(p=>new{MainKey=p.Key,MainCount=p.Count()});
            foreach(var item in z){
                Console.WriteLine("Number {0} appears {1} time(s)",item.MainKey,item.MainCount);
            }
        }

        public static void QuerySyntaxeQuestions(){
            Space();
            Console.WriteLine("Which LINQ Syntaxe ? \n1) String Collection\n2) Sequence Collection\n3) Anonymous Method\n4) Lambda Expressions");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1:
                    LINQSyntaxeStringCollection();
                    break;
                case 2:
                    LINQSyntaxeSequenceCollection();
                    break;
                case 3:
                    LINQAnonymousMethod();
                    break;
                case 4:
                    LINQLambdaExpressions();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    QuerySyntaxeQuestions();
                    break;
            }
            Space();
        }

        public static void LINQSyntaxeStringCollection(){
            // string collection
            IList<string> stringList = new List<string>() { "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials" , "Java" };
            // LINQ Query Syntax
            var result = from s in stringList where s.Contains("Tutorials") select s;
            foreach (var str in result)
			    Console.WriteLine(str);
        }

        public static void LINQSyntaxeSequenceCollection(){
            // Student collection
            IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
                };
            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                where s.Age > 12 && s.Age < 20
                                select s;
            Space();
            Console.WriteLine("Teen age Students:");			  
		    foreach(Student std in teenAgerStudent){			
			    Console.WriteLine(std.StudentName);
		    }
            Space();
            // LINQ Query Method to find out teenager students
            Console.WriteLine("-- When Using Method (Fluent Syntaxe) --");
            var teenAgerStudentForMethod = studentList.Where(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine("Teen age Students:");
            foreach(Student std in teenAgerStudentForMethod){			
                Console.WriteLine(std.StudentName);
            }
        }

        

        delegate bool IsTeenAger(Student stud);

        public static void LINQAnonymousMethod(){
            IsTeenAger isTeenAger = delegate(Student s) { return s.Age > 12 && s.Age < 20; };
            Student stud1 = new Student() { Age = 25 };
            Student stud2 = new Student() { Age = 19 };
            Student stud3 = new Student() { Age = 21 };
            Space();
            Console.WriteLine(isTeenAger(stud1));
            Console.WriteLine("Lambda Expression Anonymous Method :");
            IsTeenAger isTeenAger2 = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine(isTeenAger2(stud2));
        }

        delegate bool IsYoungerThan(Student stud, int youngAge);
        delegate void Print();
        delegate bool IsAdult(Student stud);
        public static void LINQLambdaExpressions(){
            Student stud = new Student() { Age = 25 };

            IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
                };

            Space();
            Console.WriteLine("-- Lambda Expression Multiple Parameters --");
            Console.WriteLine("Wrap the parameters in parenthesis if need to pass more than one parameter :");
            IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;
		    Console.WriteLine(isYoungerThan(stud, 26));

            Space();
            Console.WriteLine("-- Lambda Expression Without Parameter --");
            Print print = () => Console.WriteLine("This is parameter less lambda expression");
		    print();
            
            Space();
            IsYoungerThan multiStatementsIsYoungerThan = (s, youngAge) => {
			    Console.WriteLine("-- Lambda Expression Multi Statements in Body --");
			    return s.Age < youngAge;
            };
            Console.WriteLine(multiStatementsIsYoungerThan(stud, 26));

            Space();
            Console.WriteLine("-- Declare Local Variable in Lambda Expression Body --");
            IsAdult isAdult = (s) => {
                int adultAge = 18;
                Console.WriteLine("Lambda expression with multiple statements in the body");
                return s.Age >= adultAge;
            };
            Console.WriteLine(isAdult(stud));

            Space();
            Console.WriteLine("-- Assign Lambda Expression to Delegate --");
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine(isStudentTeenAger(stud));

            Space();
            Console.WriteLine("-- Action Delegate --");
            Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.StudentName, s.Age);
            Student std = new Student(){ StudentName = "Bill", Age=21};
            PrintStudentDetail(std);
            // With a list
            foreach (Student stds in studentList){
                PrintStudentDetail(stds);
            }

            Space();
            Console.WriteLine("-- Lambda Expression in LINQ Query --");
            Func<Student, bool> isTheStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            var teenAgerStudent = studentList.Where(isTheStudentTeenAger);
            Console.WriteLine("Teen age Students:");
            foreach(Student stdsTeenAger in teenAgerStudent){			
                Console.WriteLine(stdsTeenAger.StudentName);
            }
        }

        public static void LINQOperators(IList<Student> studentList){
            Space();
            Console.WriteLine("Which LINQ Operator ? \n1) Filtering Operator \n2) Sorting Operator\n3) Grouping Operators");
            var InputOperator = Console.ReadLine();
            int valueInputOperator = int.Parse(InputOperator);
            switch (valueInputOperator)
            {
                case 1: // Filtering Operators (Where OfType)
                    Space();
                    Console.WriteLine("Which LINQ Filtering Operator ? \n1) Where\n2) OfType");
                    var InputFilteringOperator = Console.ReadLine();
                    int valueInputFilteringOperator = int.Parse(InputFilteringOperator);
                    switch (valueInputFilteringOperator)
                    {
                        case 1:
                            LINQWhereFunction(studentList);
                            break;
                        case 2:
                            LINQOfTypeFunction();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators(studentList);
                            break;
                    }
                    break;
                case 2: // Sorting Operators (OrderBy ThenBy)
                    Space();
                    Console.WriteLine("Which LINQ Sorting Operator ? \n1) OrderBy\n2) OrderByDescending\n3) ThenBy\n4) ThenByDescending");
                    var InputSortingOperator = Console.ReadLine();
                    int valueInputSortingOperator = int.Parse(InputSortingOperator);
                    switch (valueInputSortingOperator)
                    {
                        case 1:
                            // OrderBy
                            LINQOrderByFunction(studentList);
                            break;
                        case 2:
                            // OrderByDescending
                            LINQOrderByDescendingFunction(studentList);
                            break;
                        case 3:
                            // ThenBy
                            LINQThenByFunction(studentList);
                            break;
                        case 4:
                            // ThenByDescending
                            LINQThenByDescendingFunction(studentList);
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators(studentList);
                            break;
                    }
                    break;
                case 3: // Grouping Operators (GroupBy ToLookup)
                    Space();
                    Console.WriteLine("Which LINQ Grouping Operator ? \n1) GroupBy (Query Syntax)\n2) GroupBy (Method Syntax)");
                    var InputGroupingOperator = Console.ReadLine();
                    int valueInputGroupingOperator = int.Parse(InputGroupingOperator);
                    switch (valueInputGroupingOperator)
                    {
                        case 1:
                            // GroupBy Query
                            GroupByOperator.LINQGroupByFunctionQuery(studentList);
                            break;
                        case 2:
                            // GroupBy Method
                            GroupByOperator.LINQGroupByFunctionMethod(studentList);
                            break;
                        case 3:
                            // ToLookUp
                            LINQToLookUpFunction(studentList);
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators(studentList);
                            break;
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    LINQOperators(studentList);
                    break;
            }
        }


        public static void LINQWhereFunction(IList<Student> studentList){
            Console.WriteLine("-- Where --\n-- Returns values from the collection based on a predicate function --");
            
            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                where s.Age > 12 && s.Age < 20
                                select s;
            Console.WriteLine("Teen age Students (12-20):");
            foreach(Student std in teenAgerStudent){			
                Console.WriteLine(std.StudentName);
            }

            // Where extension method in Method Syntax
            Console.WriteLine("-- Where extension method in Method Syntax --");
            var teenAgerStudentMethodSyntax = studentList.Where(s => s.Age > 6 && s.Age < 12);
            Console.WriteLine("Kids age Students (6-12):");
            foreach(Student std in teenAgerStudentMethodSyntax){			
                Console.WriteLine(std.StudentName);
            }

            // Multiple Where Clause (Query Syntax)
            Console.WriteLine("-- Multiple Where Clause (Query Syntax) --");
            Console.WriteLine("Students (12-20 / ID >1 & <6):");
            var filteredResult = from s in studentList
                    where s.Age > 12
                    where s.Age < 20
                    where s.StudentID > 1
                    where s.StudentID < 6
                    select s;
            foreach(Student std in filteredResult){			
                Console.WriteLine(std.StudentName);
            }

            // Multiple Where Clause (Method Syntax)
            Console.WriteLine("-- Multiple Where Clause (Method Syntax) --");
            Console.WriteLine("Students (12-20 / ID >6):");
            var filteredResult2 = studentList.Where(s => s.Age > 12).Where(s => s.Age < 20).Where(s => s.StudentID > 6);
            foreach(Student std in filteredResult2){			
                Console.WriteLine(std.StudentName);
            }
        }

        public static void LINQOfTypeFunction(){
            Space();
            Console.WriteLine("-- OfType --\n-- Returns values from the collection based on a specified type. However, it will depend on their ability to cast to a specified type --\n");
        
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
            
            var stringResult = from s in mixedList.OfType<string>() select s;
            var intResult = from s in mixedList.OfType<int>() select s;
            var stdResult = from s in mixedList.OfType<Student>() select s;
            
            // Only String
            Console.WriteLine("OfType String:");
            foreach (var str in stringResult)
                Console.WriteLine(str);
            // Only Int
            Console.WriteLine("OfType Int:");
            foreach (var integer in intResult)
                Console.WriteLine(integer);
            // Only Student Name
            Console.WriteLine("OfType Student:");
            foreach (var std in stdResult)
                Console.WriteLine(std.StudentName);
        }

        public static void LINQOrderByFunction(IList<Student> studentList){
            Space();
            Console.WriteLine("-- OrderBy --\n-- Sorts the elements in the collection based on specified fields in ascending or decending order --");
            var orderByResult = from s in studentList
                   orderby s.StudentName // Sorts the studentList collection in ascending order
                   select s;

            var orderByAgeResult = from s in studentList
                   orderby s.Age // Sorts the studentList collection in ascending order
                   select s;

            var orderByStudentIDResult = from s in studentList
                    orderby s.StudentID // Sorts the studentList collection in ascending order
                    select s;

            Space();
            Console.WriteLine("Ascending Order (Name):");
            foreach (var std in orderByResult)
                Console.WriteLine(std.StudentName);
            
            Space();
            Console.WriteLine("Ascending Order (Age):");
            foreach (var std in orderByAgeResult)
                Console.WriteLine(std.StudentName + " - Age : " + std.Age + " years old.");

            Space();
            Console.WriteLine("Ascending Order (ID)");
            foreach (var std in orderByStudentIDResult)
                Console.WriteLine(std.StudentName + " - ID : " + std.StudentID);

        }

        public static void LINQOrderByDescendingFunction(IList<Student> studentList){
            var orderByDescendingResult = from s in studentList // Sorts the studentList collection in descending order
                    orderby s.StudentName descending
                    select s;
            var orderByAgeDescendingResult = from s in studentList
                   orderby s.Age descending // Sorts the studentList collection in descending order
                   select s;
            var orderByStudentIDDescendingResult = from s in studentList
                    orderby s.StudentID descending // Sorts the studentList collection in descending order
                    select s;

            Space();
            Console.WriteLine("Descending Order (Name):");
            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.StudentName);
            
            Space();
            Console.WriteLine("Descending Order (Age):");
            foreach (var std in orderByAgeDescendingResult)
                Console.WriteLine(std.StudentName + " - Age : " + std.Age + " years old.");

            Space();
            Console.WriteLine("Descending Order (ID)");
            foreach (var std in orderByStudentIDDescendingResult)
                Console.WriteLine(std.StudentName + " - ID : " + std.StudentID);
        }

        public static void LINQThenByFunction(IList<Student> studentList){
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age).ThenBy(s => s.StudentID);
            Console.WriteLine("ThenBy:");
            foreach (var std in thenByResult)
                Console.WriteLine("Name: {0}, Age:{1}, ID:{2}", std.StudentName, std.Age, std.StudentID);
        }

        public static void LINQThenByDescendingFunction(IList<Student> studentList){
            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age).ThenByDescending(s => s.StudentID);
            Console.WriteLine("ThenBy Descending:");
            foreach (var std in thenByDescResult)
                Console.WriteLine("Name: {0}, Age:{1}, ID:{2}", std.StudentName, std.Age, std.StudentID);
        }

        

        

        public static void LINQToLookUpFunction(IList<Student> studentList){

        }

    }
}
