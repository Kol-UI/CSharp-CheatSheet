using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class GroupByOperator
    {
        public static void LINQGroupByMethodQuery(IList<Student> studentList){
            var groupedAgeResult = from s in studentList group s by s.Age;
            var groupedNameResult = from s in studentList group s by s.StudentName;
            var groupedIDResult = from s in studentList group s by s.StudentID;

            // Iterate each group  
            Program.Space();
            Console.WriteLine("----- Group by Age -----");
            foreach (var ageGroup in groupedAgeResult)
            {
                Console.WriteLine("-- Age Group: {0}", ageGroup.Key); // Each group has a key 
                foreach(Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Program.Space();
            Console.WriteLine("----- Group by Name -----");
            foreach (var ageGroup in groupedNameResult)
            {
                Console.WriteLine("-- Name Group: {0}", ageGroup.Key);
                foreach(Student s in ageGroup)
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Program.Space();
            Console.WriteLine("----- Group by ID -----");
            foreach (var ageGroup in groupedIDResult)
            {
                Console.WriteLine("-- ID Group: {0}", ageGroup.Key); 
                foreach(Student s in ageGroup)
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
        }

        public static void LINQGroupByMethodMethod(IList<Student> studentList){
            var groupedResultAge = studentList.GroupBy(s => s.Age);
            var groupedResultID = studentList.GroupBy(s => s.StudentID);
            var groupedResultName = studentList.GroupBy(s => s.StudentName);

            Program.Space();
            Console.WriteLine("----- Age Groups -----");
            foreach (var ageGroup in groupedResultAge)
            {
                Console.WriteLine("-- Age Group: {0}", ageGroup.Key);  // Each group has a key
                foreach(Student s in ageGroup)  // Each group has a inner collection  
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Program.Space();
            Console.WriteLine("----- ID Groups -----");
            foreach (var IDGroup in groupedResultID)
            {
                Console.WriteLine("-- ID Group: {0}", IDGroup.Key);
                foreach(Student s in IDGroup) 
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Program.Space();
            Console.WriteLine("----- Name Groups -----");
            foreach (var NameGroup in groupedResultName)
            {
                Console.WriteLine("-- Name Group: {0}", NameGroup.Key);
                foreach(Student s in NameGroup) 
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
        }
    }
}