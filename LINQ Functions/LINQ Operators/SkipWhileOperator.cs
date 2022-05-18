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
            var adultsSkipWhile = allStudents.ToList().SkipWhile(x => x.Age <= 17);
            var underaged = allStudents.ToList().OrderByDescending(x => x.Age).SkipWhile(x => x.Age >= 17);

            // SkipWhile is better working with OrderByDescending or OrderBy before calling it

            Console.WriteLine("\t Adult Students :");
            foreach (var stds in adults)
            {
                Console.WriteLine($" Age : {stds.Age} \tName : {stds.StudentName}");
            }
            
            Console.WriteLine("\t Adults (SkipWhile) Students :");
            foreach (var stds in adultsSkipWhile)
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