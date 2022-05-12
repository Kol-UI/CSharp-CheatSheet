using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class MinOperator
    {
        public static void LINQMinFunction(){
            var studentClasse = Student.GetAllStudents();
            var oldest = studentClasse.Min(s => s.Age);
            Console.WriteLine("Youngest Student Age: {0}", oldest);
        }
        
    }

}