using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQAnonymousMethod
    {
        public static void LINQAnonymousMethodFunction(){
            Student.IsTeenAger isTeenAger = delegate(Student s) { return s.Age > 12 && s.Age < 20; };
            Student stud1 = new Student() { Age = 25 };
            Student stud2 = new Student() { Age = 19 };
            Student stud3 = new Student() { Age = 21 };
            Program.Space();
            Console.WriteLine(isTeenAger(stud1));
            Console.WriteLine("Lambda Expression Anonymous Method :");
            Student.IsTeenAger isTeenAger2 = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine(isTeenAger2(stud2));
        }
    }

}