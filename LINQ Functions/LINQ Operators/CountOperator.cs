using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class CountOperator
    {
        public static void LINQCountMethod(){
            var StudentClasse = Student.GetAllStudents();
            var totalStudents = StudentClasse.Count();

            Console.WriteLine("Total Students: {0}", totalStudents);
            var oldStudents = StudentClasse.Count(s => s.Age > 65);
            Console.WriteLine("Number of Old Adult Students: {0}", oldStudents );
            var adultStudents = StudentClasse.Count(s => s.Age > 27 & s.Age < 65);
            Console.WriteLine("Number of Adult Students: {0}", adultStudents );
            var youngAdultStudents = StudentClasse.Count(s => s.Age >= 18 & s.Age <= 27);
            Console.WriteLine("Number of Young Adult Students: {0}", youngAdultStudents );
            var teenStudents = StudentClasse.Count(s => s.Age >= 13 & s.Age < 18);
            Console.WriteLine("Number of Teen Students: {0}", teenStudents );
            var kidStudents = StudentClasse.Count(s => s.Age < 13);
            Console.WriteLine("Number of Kid Students: {0}", kidStudents );
            
        }
        
    }

}