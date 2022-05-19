using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class AsQueryableOperator
    {
        public static void LINQAsQueryableMethod(){
            Console.WriteLine("AsQueryable: Converts IEnumerable to IQueryable, to simulate a remote query provider.");

            Student[] studentArray = { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                };   
			
            ReportTypeProperties(studentArray);
            ReportTypeProperties(studentArray.AsQueryable());

        }

        static void ReportTypeProperties<T>(T obj)
	{
		Console.WriteLine("Compile-time type: {0}", typeof(T).Name);
		Console.WriteLine("Actual type: {0}", obj.GetType().Name);
	}
        
    }

}