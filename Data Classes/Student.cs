using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_CheatSheet
{
    public class Student{
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public int StandardID { get; set; }

            public delegate bool IsYoungerThan(Student stud, int youngAge);
            public delegate void Print();
            public delegate bool IsAdult(Student stud);
            public delegate bool IsTeenAger(Student stud);

            public static List<Student> GetAllStudents()
            {
                return new List<Student>()
                    {
                        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                        new Student() { StudentID = 2, StudentName = "Marc",  Age = 21 } ,
                        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } ,
                        new Student() { StudentID = 6, StudentName = "Paul", Age = 17} ,
                        new Student() { StudentID = 7, StudentName = "Tom",  Age = 22 } ,
                        new Student() { StudentID = 8, StudentName = "Bob",  Age = 19 } ,
                        new Student() { StudentID = 9, StudentName = "Michel" , Age = 32} ,
                        new Student() { StudentID = 10, StudentName = "Leo" , Age = 7 },
                        new Student() { StudentID = 10, StudentName = "Pierre" , Age = 17 },
                        new Student() { StudentID = 10, StudentName = "Patrick" , Age = 18 },
                        new Student() { StudentID = 11, StudentName = "Kevin" , Age = 22 }, // For Group by ID
                        new Student() { StudentID = 11, StudentName = "Bill",  Age = 24 }, // For Group by Name
                        new Student() { StudentID = 12, StudentName = "Paul", Age = 25}, // For Group by Name
                        new Student() { StudentID = 13, StudentName = "Arthur", Age = 18, StandardID = 1 } , // Standard ID
                        new Student() { StudentID = 14, StudentName = "Paul",  Age = 21, StandardID = 1 } ,
                        new Student() { StudentID = 15, StudentName = "Roger",  Age = 18, StandardID = 2 } ,
                        new Student() { StudentID = 16, StudentName = "Max" , Age = 20, StandardID = 2 } ,
                        new Student() { StudentID = 17, StudentName = "Clara" , Age = 19, StandardID = 3 } ,
                        new Student() { StudentID = 18, StudentName = "Alice" , Age = 18 },
                        new Student() { StudentID = 19, StudentName = "Mark" , Age = 17 },
                        new Student() { StudentID = 20, StudentName = "John" , Age = 16 },
                        new Student() { StudentID = 21, StudentName = "Joseph" , Age = 27 },
                        new Student() { StudentID = 22, StudentName = "Castro" , Age = 32 },
                        new Student() { StudentID = 23, StudentName = "Cruz" , Age = 28 },
                        new Student() { StudentID = 24, StudentName = "Lopez" , Age = 22 },
                        new Student() { StudentID = 25, StudentName = "Anjita" , Age = 25 },
                        new Student() { StudentID = 26, StudentName = "Soniya" , Age = 18 },
                        new Student() { StudentID = 27, StudentName = "Rohit" , Age = 16 },
                        new Student() { StudentID = 28, StudentName = "Supriya" , Age = 20 },
                        new Student() { StudentID = 29, StudentName = "Anil" , Age = 18 },
                        new Student() { StudentID = 30, StudentName = "Anju" , Age = 20 },
                        new Student() { StudentID = 31, StudentName = "Terry" , Age = 29 },
                        new Student() { StudentID = 32, StudentName = "Marion" , Age = 19 },
                        new Student() { StudentID = 33, StudentName = "Romane" , Age = 17 },
                        new Student() { StudentID = 34, StudentName = "Arthur" , Age = 29 },
                        new Student() { StudentID = 35, StudentName = "Manon" , Age = 26 },
                        new Student() { StudentID = 36, StudentName = "Paulette" , Age = 78 },
                        new Student() { StudentID = 37, StudentName = "Cassandra" , Age = 20 },
                        new Student() { StudentID = 38, StudentName = "Alexandre" , Age = 21 },
                        
                    };
            }
        }

        
}