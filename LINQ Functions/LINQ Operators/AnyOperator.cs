using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class AnyOperator
    {
        public static void LINQAnyFunction(){
            var Classe = Student.GetAllStudents();
            Console.WriteLine("--- Is there any student aged between 12 & 20 ? ---");
            bool isAnyStudentTeenAger = Classe.Any(s => s.Age > 12 && s.Age < 20);
		    Console.WriteLine(isAnyStudentTeenAger);
            Console.WriteLine("--- Which ones ? ---");
            var resultsAny = Classe.Where(s => s.Age >= 12).Where(s => s.Age <= 20).OrderBy(s => s.Age);
            foreach(Student std in resultsAny){			
                Console.WriteLine(std.StudentName + " Age: " + std.Age);
            }
        }
    }

}