using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class AllOperator
    {
        public static void LINQAllMethod(){
            var Classe = Student.GetAllStudents();
            // Checks whether all the students are teenagers    
            bool areAllStudentsTeenAger = Classe.All(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine("\nAre All students teenagers ?");
            Console.WriteLine(areAllStudentsTeenAger);
            
            Console.WriteLine("\n----- Younger than 18 years old :");
            var resultA = Classe.Where(s => s.Age < 18).OrderBy(s => s.Age);
            foreach(Student std in resultA){			
                Console.WriteLine(std.StudentName + " Age: " + std.Age);
            }
            Console.WriteLine("\n----- Older than 30 years old :");
            var resultB = Classe.Where(s => s.Age > 30).OrderBy(s => s.Age);
            foreach(Student std in resultB){			
                Console.WriteLine(std.StudentName + " Age: " + std.Age);
            }
            Console.WriteLine("\n----- Between 18 & 30 :");
            var resultC = Classe.Where(s => s.Age >= 18).Where(s => s.Age <= 30).OrderBy(s => s.Age);
            foreach(Student std in resultC){			
                Console.WriteLine(std.StudentName + " Age: " + std.Age);
            }

        }
    }

}