using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    
    public class ThenByOperator
    {
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
    }

}