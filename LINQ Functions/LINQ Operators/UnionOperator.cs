using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class UnionOperator
    {
        public static void LINQUnionFunction(){
            var Products1 = Product.GetAllProducts();
            var Products2 = Product.GetAllSecondaryProducts();
            IEnumerable<Product> union = Products1.Union(Products2);

            foreach (var prdt in union)
                Console.WriteLine(prdt.Name + " " + prdt.Code);

            string[] dataSource1 = { "Germany", "India", "USA", "UK", "Iceland", "Canada", "Spain", "Russia", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "Brazil", "China", "France", "Japan", "Poland" };

            List<Student> StudentCollection1 = new List<Student>()
            {
                new Student {StudentID = 101, StudentName = "Preety" },
                new Student {StudentID = 102, StudentName = "Sambit" },
                new Student {StudentID = 105, StudentName = "Hina"},
                new Student {StudentID = 106, StudentName = "Anurag"},
            };
            List<Student> StudentCollection2 = new List<Student>()
            {
                new Student {StudentID = 105, StudentName = "Hina"},
                new Student {StudentID = 106, StudentName = "Anurag"},
                new Student {StudentID = 107, StudentName = "Pranaya"},
                new Student {StudentID = 108, StudentName = "Santosh"},
            };
            SimpleUnion();
            UnionAndRemoveDuplicate(dataSource1, dataSource2);
            UnionRemoveDuplicateAndCase(dataSource1, dataSource2);
            UnionStudents(StudentCollection1, StudentCollection2);
            AllPets();
        }
        

        private static void SimpleUnion(){
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            Console.WriteLine("Union of numbers: ");
            var Union = dataSource1.Union(dataSource2).ToList();
            foreach (var item in Union)
            {
                Console.Write(item + " ");
            }
            Program.Space();
        }

        private static void UnionAndRemoveDuplicate(string[] dataSource1, string[] dataSource2){
            Console.WriteLine("Countries: ");

            var Union = dataSource1.Union(dataSource2).ToList();
            foreach (var item in Union)
            {
                Console.Write(item + " ");
            }
            Program.Space();
        }

        private static void UnionRemoveDuplicateAndCase(string[] dataSource1, string[] dataSource2){
            Console.WriteLine("Countries: ");

            var Union = dataSource1.Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            
            foreach (var item in Union)
            {
                Console.Write(item + " ");
            }
            Program.Space();
        }

        private static void UnionStudents(List<Student> StudentCollection1, List<Student> StudentCollection2){
            var MainStudents = Student.GetAllStudents();
            var SecondaryStudents = StudentCollection2;
            
            Console.WriteLine("Student List 1:");
            var Union = StudentCollection1.Union(StudentCollection2).ToList();
            foreach (var student in Union)
            {
                Console.WriteLine($" ID : {student.StudentID} Name : {student.StudentName}");
            }

            Console.WriteLine("Student List 2:");
            var Union2 = MainStudents.Union(SecondaryStudents).ToList();
            foreach (var student in Union2)
            {
                Console.WriteLine($" ID : {student.StudentID} Name : {student.StudentName}");
            }

            Console.WriteLine("Student Comparer List :");
            StudentComparer studentComparer = new StudentComparer();
            var Union3 = StudentCollection1.Union(StudentCollection2, studentComparer).ToList();
            
            foreach (var student in Union3)
            {
                Console.WriteLine($" ID : {student.StudentID} Name : {student.StudentName}");
            }

            Console.WriteLine("All Students List :");
            StudentComparer studentComparer2 = new StudentComparer();
            var Union4 = MainStudents.Union(Union3, studentComparer2).ToList();
            
            foreach (var student in Union4)
            {
                Console.WriteLine($" ID : {student.StudentID} Name : {student.StudentName}");
            }
        }

        private static void AllPets(){
            var dogs = Pet.GetAllDogs();
            var cats = Pet.GetAllCats();
            var birds = Pet.GetAllBirds();

            PetComparer petComparer1 = new PetComparer();
            var allPetsTogether = dogs.Union(cats, petComparer1).Union(birds, petComparer1).ToList();
            var petUnion = from s in allPetsTogether
                   orderby s.Age
                   select s;

            Console.WriteLine("\tAll pets united :");
            foreach (var pets in petUnion)
            {
                Console.WriteLine($" Age : {pets.Age} Name : {pets.Name}");
            }

        }

    }

}