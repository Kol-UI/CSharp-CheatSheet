using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class AverageOperator
    {
        public static void LINQAverageMethod(){
            var StudentClasse = Student.GetAllStudents();
            double avgAge = Math.Round(StudentClasse.Average(s => s.Age), 1);
            Console.WriteLine("Average Age of Student: {0}", avgAge);
        }
        
    }

}