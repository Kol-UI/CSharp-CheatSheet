using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class DefaultIfEmptyOperator
    {
        public static void LINQDefaultIfEmptyFunction(){
            IList<string> emptyList = new List<string>();
            IList<int> emptyListInt = new List<int>();
            IList<Student> emptyStudentList = new List<Student>();

            var StudentClasse = Student.GetAllStudents();

            var newList1 = emptyList.DefaultIfEmpty(); 
            var newList2 = emptyList.DefaultIfEmpty("None");
            var newList1Int = emptyListInt.DefaultIfEmpty(); 
            var newList2Int = emptyListInt.DefaultIfEmpty(100);
            var newStudentList1 = emptyStudentList.DefaultIfEmpty();
            var newStudentList2 = emptyStudentList.DefaultIfEmpty(new Student(){ StudentID = 0, StudentName = "" });

            Console.WriteLine("Count: {0}" , newList1Int.Count());
            Console.WriteLine("Value: {0}" , newList1Int.ElementAt(0));
            Console.WriteLine("Count: {0}" , newList2Int.Count());
            Console.WriteLine("Value: {0}" , newList2Int.ElementAt(0));

            Console.WriteLine("Count: {0} ", newStudentList1.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0));
            Console.WriteLine("Count: {0} ", newStudentList2.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList2.ElementAt(0).StudentID);

            Console.WriteLine("Count: {0} ", StudentClasse.Count());
            Console.WriteLine("First Student ID: {0} ", StudentClasse.ElementAt(0).StudentID);
            Console.WriteLine("First Student Name: {0} ", StudentClasse.ElementAt(0).StudentName);
            Console.WriteLine("First Student Age: {0} ", StudentClasse.ElementAt(0).Age);
            Console.WriteLine("Last Student ID: {0} ", StudentClasse.LastOrDefault().StudentID);
            Console.WriteLine("Last Student Name: {0} ", StudentClasse.LastOrDefault().StudentName);
            Console.WriteLine("Last Student Age: {0} ", StudentClasse.LastOrDefault().Age);
            


        }
        
    }

}