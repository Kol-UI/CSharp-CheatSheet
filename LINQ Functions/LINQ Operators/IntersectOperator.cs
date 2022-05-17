using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class IntersectOperator
    {
        public static void LINQIntersectFunction(){
            IList<Student> studentList1 = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
            };

            IList<Student> studentList2 = new List<Student>() { 
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
            };

            var resultedCol = studentList1.Intersect(studentList2); 

            foreach(Student std in resultedCol)
                Console.WriteLine(std.StudentName);
            

            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };
            IEnumerable<int> both = id1.Intersect(id2);

            foreach (int id in both)
                Console.WriteLine(id);
            
            Product[] store1 = { new Product { Name = "apple", Code = 9 },
                       new Product { Name = "orange", Code = 4 } };

            Product[] store2 = { new Product { Name = "apple", Code = 9 },
                                new Product { Name = "lemon", Code = 12 } };
            
            IEnumerable<Product> duplicates = store1.Intersect(store2);

            foreach (var product in duplicates)
                Console.WriteLine(product.Name + " " + product.Code);
            
            Console.WriteLine("\nDuplicates 2:");
            var Products1 = Product.GetAllProducts();
            var Products2 = Product.GetAllSecondaryProducts();
            IEnumerable<Product> duplicates2 = Products1.Intersect(Products2);

            foreach (var prdt in duplicates2)
                Console.WriteLine(prdt.Name + " " + prdt.Code);


        }
    }

}