using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class AggregateOperator
    {
        public static void LINQAggregateMethod(){
            var StudentClasse = Student.GetAllStudents();

            // Simple Aggregate
            Program.Space();
            Console.WriteLine("--- Simple Aggregate ---");
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five"};
            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(commaSeperatedString);

            // Simple Aggregate 2
            Program.Space();
            Console.WriteLine("--- Simple Aggregate 2 ---");
            IEnumerable<int> ints = new List<int> { 2, 4, 1, 6 };
            int result = ints.Aggregate((sum, val) => sum + val);
            Console.WriteLine(result);

            // Simple Aggregate 3
            Program.Space();
            Console.WriteLine("--- Simple Aggregate 3 ---");
            IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd", "z" };
            string result2 = strings.Aggregate((concat, str) => $"{concat} & {str}");
            Console.WriteLine(result2);

            // Aggregate Seed Value
            Program.Space();
            Console.WriteLine("--- Aggregate Seed Value ---");
            string commaSeparatedStudentNames = StudentClasse.Aggregate<Student, string,string>(
                                            "Student Names: ", // Seed Value
                                            (str, s) => str += s.StudentName + ", ",
                                            str => str.Substring(0,str.Length - 2 ));
            Console.WriteLine(commaSeparatedStudentNames);

        }
        
    }

}