using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class AsEnumerableOperator
    {
        public static void LINQAsEnumerableMethod(){
            Console.WriteLine("AsEnumerable: Returns the input sequence as IEnumerable<t>.");

            Student[] studentArray = { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                };   
			
            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.AsEnumerable());

        }

        static void ReportTypeProperties<T>(T obj)
	{
		Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
		Console.WriteLine("Actual type: {0}", obj.GetType().Name);
	}
        
    }

}