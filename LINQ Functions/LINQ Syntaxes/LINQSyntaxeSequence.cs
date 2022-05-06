using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQQuerySyntaxeSequence
    {
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
            Program.Space();
            Console.WriteLine("Teen age Students:");			  
		    foreach(Student std in teenAgerStudent){			
			    Console.WriteLine(std.StudentName);
		    }
            Program.Space();
            // LINQ Query Method to find out teenager students
            Console.WriteLine("-- When Using Method (Fluent Syntaxe) --");
            var teenAgerStudentForMethod = studentList.Where(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine("Teen age Students:");
            foreach(Student std in teenAgerStudentForMethod){			
                Console.WriteLine(std.StudentName);
            }
        }
    }

}

