using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class WhereOperator
    {
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
    }

}