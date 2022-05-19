using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class OrderByOperator
    {
        public static void LINQOrderByFunction(){
            var studentList = Student.GetAllStudents();
            Program.Space();
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

            Program.Space();
            Console.WriteLine("Ascending Order (Name):");
            foreach (var std in orderByResult)
                Console.WriteLine(std.StudentName);
            
            Program.Space();
            Console.WriteLine("Ascending Order (Age):");
            foreach (var std in orderByAgeResult)
                Console.WriteLine(std.StudentName + " - Age : " + std.Age + " years old.");

            Program.Space();
            Console.WriteLine("Ascending Order (ID)");
            foreach (var std in orderByStudentIDResult)
                Console.WriteLine(std.StudentName + " - ID : " + std.StudentID);

        }
        public static void LINQOrderByDescendingFunction(){
            var studentList = Student.GetAllStudents();
            var orderByDescendingResult = from s in studentList // Sorts the studentList collection in descending order
                    orderby s.StudentName descending
                    select s;
            var orderByAgeDescendingResult = from s in studentList
                   orderby s.Age descending // Sorts the studentList collection in descending order
                   select s;
            var orderByStudentIDDescendingResult = from s in studentList
                    orderby s.StudentID descending // Sorts the studentList collection in descending order
                    select s;

            Program.Space();
            Console.WriteLine("Descending Order (Name):");
            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.StudentName);
            
            Program.Space();
            Console.WriteLine("Descending Order (Age):");
            foreach (var std in orderByAgeDescendingResult)
                Console.WriteLine(std.StudentName + " - Age : " + std.Age + " years old.");

            Program.Space();
            Console.WriteLine("Descending Order (ID)");
            foreach (var std in orderByStudentIDDescendingResult)
                Console.WriteLine(std.StudentName + " - ID : " + std.StudentID);
        }
    }

}