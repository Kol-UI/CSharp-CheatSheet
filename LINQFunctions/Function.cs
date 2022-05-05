using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp_CheatSheet
{
    
    public class Function
    {
        public static void TestFunction(IList<Student> studentList)
        {
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