using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SkipWhileOperator
    {
        public static void LINQSkipWhileFunction(){
            var allStudents = Student.GetAllStudents().OrderBy(s => s.Age).ThenBy(s => s.StudentName);
            var adults = allStudents.ToList().Where(x => x.Age > 17);
            var underaged = allStudents.ToList().SkipWhile(x => x.Age <= 17);

            Console.WriteLine("\t Underage Students :");
            foreach (var stds in adults)
            {
                Console.WriteLine($" Age : {stds.Age} \tName : {stds.StudentName}");
            }
            Console.WriteLine("\t Underage Students with SkipWhile :");
            foreach (var stds in underaged)
            {
                Console.WriteLine($" Age : {stds.Age} \tName : {stds.StudentName}");
            }
        }
        
    }

}