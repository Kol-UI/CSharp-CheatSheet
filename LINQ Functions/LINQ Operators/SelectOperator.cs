using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SelectOperator
    {
        public static void SelectFunction(){
            var studentsClasse = Student.GetAllStudents();
            var selectResult = from s in studentsClasse
                            select s.StudentName;
                            
            foreach(var name in selectResult){			
                Console.WriteLine(name);
            }
        }

        public static void SelectQuerySyntaxe(){
            var studentsClasse = Student.GetAllStudents();
            var selectResult = from s in studentsClasse
                            select new { Name = s.StudentName, Age = s.Age, ID = s.StudentID }; 
            
            foreach (var item in selectResult)
                Console.WriteLine("Student ID: {2}, Name: {0}, {1} years old", item.Name, item.Age, item.ID);
        }

        public static void SelectMethodSyntaxe(){
            var studentsClasse = Student.GetAllStudents();
            var selectResult = studentsClasse.Select(s => new { Name = s.StudentName , Age = s.Age , ID = s.StudentID });
            
            foreach (var item in selectResult)
                Console.WriteLine("Student ID: {2}, Name: {0}, {1} years old", item.Name, item.Age, item.ID);
        }
    }

}