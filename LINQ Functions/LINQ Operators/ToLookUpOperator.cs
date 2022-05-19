using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ToLookUpOperator
    {
        public static void LINQToLookUpMethod(){
            var studentList = Student.GetAllStudents();
            var lookupResult = studentList.ToLookup(s => s.Age);

            foreach (var group in lookupResult)
            {
                Console.WriteLine("Age Group: {0}", group.Key);  // Each group has a key 
                foreach(Student s in group)  // Each group has a inner collection  
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
        }
    }

}