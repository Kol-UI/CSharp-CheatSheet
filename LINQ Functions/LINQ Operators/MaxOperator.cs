using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class MaxOperator
    {
        public static void LINQMaxFunction(){
            var studentClasse = Student.GetAllStudents();
            var oldest = studentClasse.Max(s => s.Age);
            Console.WriteLine("Oldest Student Age: {0}", oldest);
            var last = studentClasse.Max(s => s.StudentID);
            Console.WriteLine("Last Student ID given: {0}", last);
        }
        
    }

}