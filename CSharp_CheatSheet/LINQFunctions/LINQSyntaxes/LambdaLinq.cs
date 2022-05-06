using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading;

namespace CSharp_CheatSheet
{
    public class LambdaLinq
    {
        public static void LINQLambdaExpressions(){
            Student stud = new Student() { Age = 25 };

            IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
                };

            Program.Space();
            Console.WriteLine("-- Lambda Expression Multiple Parameters --");
            Console.WriteLine("Wrap the parameters in parenthesis if need to pass more than one parameter :");
            Student.IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;
		    Console.WriteLine(isYoungerThan(stud, 26));

            Program.Space();
            Console.WriteLine("-- Lambda Expression Without Parameter --");
            Student.Print print = () => Console.WriteLine("This is parameter less lambda expression");
		    print();
            
            Program.Space();
            Student.IsYoungerThan multiStatementsIsYoungerThan = (s, youngAge) => {
			    Console.WriteLine("-- Lambda Expression Multi Statements in Body --");
			    return s.Age < youngAge;
            };
            Console.WriteLine(multiStatementsIsYoungerThan(stud, 26));

            Program.Space();
            Console.WriteLine("-- Declare Local Variable in Lambda Expression Body --");
            Student.IsAdult isAdult = (s) => {
                int adultAge = 18;
                Console.WriteLine("Lambda expression with multiple statements in the body");
                return s.Age >= adultAge;
            };
            Console.WriteLine(isAdult(stud));

            Program.Space();
            Console.WriteLine("-- Assign Lambda Expression to Delegate --");
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine(isStudentTeenAger(stud));

            Program.Space();
            Console.WriteLine("-- Action Delegate --");
            Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.StudentName, s.Age);
            Student std = new Student(){ StudentName = "Bill", Age=21};
            PrintStudentDetail(std);
            // With a list
            foreach (Student stds in studentList){
                PrintStudentDetail(stds);
            }

            Program.Space();
            Console.WriteLine("-- Lambda Expression in LINQ Query --");
            Func<Student, bool> isTheStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            var teenAgerStudent = studentList.Where(isTheStudentTeenAger);
            Console.WriteLine("Teen age Students:");
            foreach(Student stdsTeenAger in teenAgerStudent){			
                Console.WriteLine(stdsTeenAger.StudentName);
            }
        }
    }

}