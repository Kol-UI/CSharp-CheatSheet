using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class TakeOperator
    {
        public static void LINQTakeMethod(){
            var studentClasse = Student.GetAllStudents();
            int numberOfStudents = studentClasse.Count();
            Console.WriteLine("A number between 1 and {0} will be choosen randomly.", numberOfStudents);

            Random r = new Random();
            int rInt = r.Next(1, numberOfStudents);
            Console.WriteLine("Student ID {0} has been choseen:", rInt);

            var TheOne = studentClasse.Where(s => s.StudentID == rInt).Take(1);

            foreach(var str in TheOne)
                Console.WriteLine("This student is " + str.StudentName + " Age : " + str.Age + " ID : " + str.StudentID);
            
            // Take the last of the collection
            Console.WriteLine("The last one is :");
            var LastStudentEasier = studentClasse.TakeLast(1);
            foreach(var str in LastStudentEasier)
                Console.WriteLine("This student is " + str.StudentName + " Age : " + str.Age + " ID : " + str.StudentID);

        }
   
    }

}