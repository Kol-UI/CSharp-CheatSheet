using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ElementAtOperator
    {
        public static void LINQElementAtFunction(){
            string[] names =
                { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow",
                    "Hedlund, Magnus", "Ito, Shu" };
            Random random = new Random(DateTime.Now.Millisecond);
            string name = names.ElementAt(random.Next(0, names.Length));
            Console.WriteLine("The name chosen at random is '{0}'.", name);
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two",  null, "Four", "Five" };		
            Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
            Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));
            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

            var StudentClasse = Student.GetAllStudents();
            // First of the Students
            var first = StudentClasse.Select(s => s.StudentName).ElementAt(0);
            // Last of the Students
            var last = StudentClasse.OrderByDescending(s => s.StudentID).Select(s => s.StudentName).ElementAt(0);
            Console.WriteLine("Very First Student: {0}\nVery Last Student: {1}", first, last);

        }
        
    }

}