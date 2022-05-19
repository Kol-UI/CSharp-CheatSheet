using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ToDictionaryOperator
    {
        public static void LINQToDictionaryMethod(){
            List<Package> packages = new List<Package>{
                new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89492112L },
                new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 219837L },
                new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 232142L },
                new Package { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4683681773L } };


            // Create a Dictionary of Package objects,
            // using TrackingNumber as the key.
            Dictionary<long, Package> dictionary = packages.ToDictionary(p => p.TrackingNumber);

            foreach (KeyValuePair<long, Package> kvp in dictionary)
            {
                Console.WriteLine( "Key {0}: {1}, {2} pounds", kvp.Key, kvp.Value.Company, kvp.Value.Weight);
            }

            Program.Space();


            IList<Student> studentList = new List<Student>() { 
                    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 } 
                };
            //following converts list into dictionary where StudentId is a key
            IDictionary<int, Student> studentDict = studentList.ToDictionary<Student, int>(s => s.StudentID); 

            foreach(var key in studentDict.Keys)
                Console.WriteLine("Key: {0}, Value: {1}", key, (studentDict[key] as Student).StudentName);
        }
        
    }

}