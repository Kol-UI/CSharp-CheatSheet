using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_CheatSheet
{
    public class Student{
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }

            public delegate bool IsYoungerThan(Student stud, int youngAge);
            public delegate void Print();
            public delegate bool IsAdult(Student stud);
            public delegate bool IsTeenAger(Student stud);
        }

        
}