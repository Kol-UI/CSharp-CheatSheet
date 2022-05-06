using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class JoinOperator
    {
        record Person(string FirstName, string LastName);
        record Pet(string Name, Person Owner);
        record Employee(string FirstName, string LastName, int EmployeeID);
        record Cat(string Name, Person Owner) : Pet(Name, Owner);
        record Dog(string Name, Person Owner) : Pet(Name, Owner);
        
        public static void JoinOperatorFunction(){
            
            // Collections
            IList<string> strList1 = new List<string>() { 
                "One",
                "Two",
                "Three",
                "Four"
                };
            
            IList<string> strList2 = new List<string>() { 
                "One",
                "Two",
                "Five",
                "Six"
                };

            Console.WriteLine("--- List 1 ---");
            foreach (var values1 in strList1){
                Console.WriteLine("{0} ",values1);
            }
            Console.WriteLine("--- List 2 ---");
            foreach (var values2 in strList2){
                Console.WriteLine("{0} ",values2);
            }
            
            var innerJoinResult = strList1.Join(// outer sequence 
                        strList2,  // inner sequence 
                        str1 => str1,    // outerKeySelector
                        str2 => str2,  // innerKeySelector
                        (str1, str2) => str1);

            Console.WriteLine("--- Joining Results ---");
            foreach (var str in innerJoinResult)
            {			
                Console.WriteLine("{0} ", str);
            }
        }

        public static void JoinMoreComplexe(){
            Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            Person terry = new("Terry", "Adams");
            Person charlotte = new("Charlotte", "Weiss");
            Person arlene = new("Arlene", "Huff");
            Person rui = new("Rui", "Raposo");

            List<Person> people = new() { magnus, terry, charlotte, arlene, rui };

            List<Pet> pets = new()
            {
                new(Name: "Barley", Owner: terry),
                new("Boots", terry),
                new("Whiskers", charlotte),
                new("Blue Moon", rui),
                new("Daisy", magnus),
            };

            // Create a collection of person-pet pairs. Each element in the collection
            // is an anonymous type containing both the person's name and their pet's name.
            var query =
                from person in people
                join pet in pets on person equals pet.Owner
                select new
                {
                    OwnerName = person.FirstName,
                    PetName = pet.Name
                };
            Program.Space();
            Console.WriteLine("--- More Complexe Joining (Simple Key) ---");
            foreach (var ownerAndPet in query)
            {
                Console.WriteLine($"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}");
            }
        }
    }

}