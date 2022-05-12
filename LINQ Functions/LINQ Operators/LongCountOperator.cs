using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LongCountOperator
    {
        public static void LINQLongCountOperator(){
            string[] fruits = { "apple", "banana", "mango","orange", "passionfruit", "grape" };
            long count = fruits.LongCount();
            Console.WriteLine("There are {0} fruits in the collection.", count);
        }

        public static void LINQLongCountOperatorStudents(){
            var StudentPromo = Student.GetAllStudents();
            var filteredResult10yo = from s in StudentPromo where s.Age >= 10 select s;
            var filteredResult20yo = from s in StudentPromo where s.Age >= 20 select s;
            long totalStudents = StudentPromo.LongCount();
            long count10 = filteredResult10yo.LongCount();
            long count20 = filteredResult20yo.LongCount();
            Console.WriteLine("In {0} students, there are {1} students who are more than 10 years old, {2} of them are more than 20 years old.", totalStudents, count10, count20);
        }

        public static void LINQLongCountOperator2()
        {
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                        new Pet { Name="Boots", Age=4 },
                        new Pet { Name="Whiskers", Age=1 } };

            const int Age = 3;
            long count = pets.LongCount(pet => pet.Age > Age);
            Console.WriteLine("There are {0} animals over age {1}.", count, Age);
        }

        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        
    }

}