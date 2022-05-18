using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SkipOperator
    {
        public static void LINQSkipMethod(){
            IList<string> strList = new List<string>(){ "One", "Two", "Three", "Four", "Five" };
            var numbersValues = new [] { 5, 4, 3, 2, 1 };
            
            var newList = strList.Skip(2);
            var skipTwo = strList.Skip(2); 
            var takeThree = numbersValues.Take(3); 
            var skipOneTakeTwo = numbersValues.Skip(1).Take(2); 
            var takeZero = numbersValues.Take(0);

            Console.WriteLine("\tBefore Skip:");
            foreach(var str in strList)
                Console.WriteLine(str);

            Console.WriteLine("\tAfter Skip:");
            foreach(var str in newList)
                Console.WriteLine(str);
            
            Console.WriteLine("\tSkip 2:");
            foreach(var val in skipTwo)
                Console.WriteLine(val);

            Console.WriteLine("\tTake 3:");
            foreach(var val in takeThree)
                Console.WriteLine(val);

            Console.WriteLine("\tSkip 1 Take 2:");
            foreach(var val in skipOneTakeTwo)
                Console.WriteLine(val);

            Console.WriteLine("\tTake 0:");
            foreach(var val in takeZero)
                Console.WriteLine(val);
            
            Program.Space();
            SkipStudents();
        }

        private static void SkipStudents(){
            var studentsClasse = Student.GetAllStudents().ToList().Skip(10);

            Console.WriteLine("\t 10 first students skipped :");
            foreach (var stds in studentsClasse)
            {
                Console.WriteLine($" ID : {stds.StudentID} \tName : {stds.StudentName}");
            }
        }
        
    }

}