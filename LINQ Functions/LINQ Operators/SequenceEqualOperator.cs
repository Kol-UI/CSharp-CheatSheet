using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SequenceEqualOperator
    {
        public static void LINQSequenceEqualFunction(){
            IList<string> strList1 = new List<string>(){"One", "Two", "Three", "Four", "Three"};
            IList<string> strList2 = new List<string>(){"One", "Two", "Three", "Four", "Three"};
            IList<string> strList3 = new List<string>(){"One", "Two", "Three", "Four", "Three", "Four"};
            
            Console.WriteLine("\nList 1:");
            foreach (string i in strList1)
            {
                Console.Write("{0}\t", i.ToString());
            }
            Console.WriteLine("\nList 2:");
            foreach (string i in strList2)
            {
                Console.Write("{0}\t", i.ToString());
            }
            Console.WriteLine("\nList 3:");
            foreach (string i in strList3)
            {
                Console.Write("{0}\t", i.ToString());
            }
            
            bool isEqual = strList1.SequenceEqual(strList2); 
            Console.WriteLine("\nDoes List 1 & List 2 have the same number of element ?\t{0} ", isEqual);
            bool isNotEqual = strList1.SequenceEqual(strList3); 
            Console.WriteLine("Does List 1 & List 3 have the same number of element ?\t{0} ", isNotEqual);

            var ClasseofStudents = Student.GetAllStudents();

            IList<Student> studentList1 = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John" },
                new Student() { StudentID = 2, StudentName = "Steve" },
            };

            IList<Student> studentList2 = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John" },
                new Student() { StudentID = 2, StudentName = "Steve" },
            };
        
            // Using Student Comparer here
            bool isEqualStudents = studentList1.SequenceEqual(studentList2, new StudentComparer());
            bool isNotEqualStudents = studentList1.SequenceEqual(ClasseofStudents, new StudentComparer());

            Console.WriteLine("List of students 1:");
            var printStudents1 = from s in studentList1 select s.StudentName;
            foreach(var name in printStudents1){			
                Console.Write(name + " ");
            }
            Program.Space();
            Console.WriteLine("List of students 2:");
            var printStudents2 = from s in studentList1 select s.StudentName;
            foreach(var name in printStudents2){			
                Console.Write(name + " ");
            }
            Program.Space();
            Console.WriteLine("Does Student List 1 & Student List 2 have the same number of element ? {0} ", isEqualStudents);

            Console.WriteLine("List of students 3:");
            var printStudents3 = from s in ClasseofStudents select s.StudentName;
            foreach(var name in printStudents3){			
                Console.Write(name + " ");
            }
            Program.Space();
            Console.WriteLine("Does Student List 1 & Student List 3 have the same number of element ? {0} ", isNotEqualStudents);


        }
        
    }

}