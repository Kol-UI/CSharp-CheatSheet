using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ContainsOperator
    {
        public static void LINQContainsMethod(){
            var StudentClasse = Student.GetAllStudents();
            Student std = new Student(){ StudentID =3, StudentName = "Bill"};
            bool result = StudentClasse.Contains(std, new StudentComparer());
            Console.WriteLine(result);
        }
        
    }

}