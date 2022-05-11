using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class WhereOperator
    {
        public static void LINQWhereFunction(){
            Console.WriteLine("-- Where --\n-- Returns values from the collection based on a predicate function --");
            var studentsClasse = Student.GetAllStudents();
            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentsClasse
                                where s.Age > 12 && s.Age < 20
                                select s;
            Console.WriteLine("Teen age Students (12-20):");
            foreach(Student std in teenAgerStudent){			
                Console.WriteLine(std.StudentName);
            }

            // Where extension method in Method Syntax
            Console.WriteLine("-- Where extension method in Method Syntax --");
            var teenAgerStudentMethodSyntax = studentsClasse.Where(s => s.Age > 6 && s.Age < 12);
            Console.WriteLine("Kids age Students (6-12):");
            foreach(Student std in teenAgerStudentMethodSyntax){			
                Console.WriteLine(std.StudentName);
            }

            // Multiple Where Clause (Query Syntax)
            Console.WriteLine("-- Multiple Where Clause (Query Syntax) --");
            Console.WriteLine("Students (12-20 / ID >1 & <6):");
            var filteredResult = from s in studentsClasse
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
            var filteredResult2 = studentsClasse.Where(s => s.Age > 12).Where(s => s.Age < 20).Where(s => s.StudentID > 6);
            foreach(Student std in filteredResult2){			
                Console.WriteLine(std.StudentName);
            }

            FindStudent();
        }

        public static void FindStudent(){
            Console.WriteLine("----- Finding a specific student -----");
            var studentsClasse = Student.GetAllStudents();

            // ID
            Console.WriteLine("\nEnter the Student ID you are looking for:\n");
            var IDInput = Console.ReadLine();
            int valueIDInput = int.Parse(IDInput);

            var filteredResult = from s in studentsClasse
                    where s.StudentID == valueIDInput select s;

            Console.WriteLine("The student ID({0}) is refered to:", valueIDInput);
            foreach(Student std in filteredResult){			
                Console.WriteLine(std.StudentName);
            }

            // Age
            Console.WriteLine("\nEnter the Student Age you are looking for:\n");
            var AgeInput = Console.ReadLine();
            int valueAgeInput = int.Parse(AgeInput);

            var filteredResult2 = from s in studentsClasse
                    where s.Age == valueAgeInput select s;

            Console.WriteLine("Student(s) who is(are) {0} years old:", valueAgeInput);
            foreach(Student std in filteredResult2){			
                Console.WriteLine(std.StudentName);
            }

            // Name
            Console.WriteLine("\nEnter the Student Name you are looking for:\n");
            var NameInput = Console.ReadLine();
            string valueNameInput = NameInput;

            var filteredResult3 = from s in studentsClasse
                    where s.StudentName == valueNameInput select s;

            Console.WriteLine("Student(s) who is(are) named {0}:", valueNameInput);
            foreach(Student std in filteredResult3){			
                Console.WriteLine(std.StudentName + " ID: " + std.StudentID);
            }
        }
    }

}