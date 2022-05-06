using System;
using System.Collections;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class OfTypeOperator
    {
        public static void LINQOfTypeFunction(){
            Program.Space();
            Console.WriteLine("-- OfType --\n-- Returns values from the collection based on a specified type. However, it will depend on their ability to cast to a specified type --\n");
        
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
            
            var stringResult = from s in mixedList.OfType<string>() select s;
            var intResult = from s in mixedList.OfType<int>() select s;
            var stdResult = from s in mixedList.OfType<Student>() select s;
            
            // Only String
            Console.WriteLine("OfType String:");
            foreach (var str in stringResult)
                Console.WriteLine(str);
            // Only Int
            Console.WriteLine("OfType Int:");
            foreach (var integer in intResult)
                Console.WriteLine(integer);
            // Only Student Name
            Console.WriteLine("OfType Student:");
            foreach (var std in stdResult)
                Console.WriteLine(std.StudentName);
        }
    }

}