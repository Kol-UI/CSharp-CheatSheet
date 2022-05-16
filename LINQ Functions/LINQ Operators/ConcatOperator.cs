using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ConcatOperator
    {
        public static void LINQConcatFunction(){
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };
            IList<string> collection3 = new List<string>() { "Four" };

            Console.WriteLine("Collection 1:");
            foreach (string str in collection1)
                Console.Write(str + " ");
            Program.Space();
            Console.WriteLine("Collection 2:");
            foreach (string str in collection2)
                Console.Write(str + " ");
            Program.Space();
            Console.WriteLine("Collection 3:");
            foreach (string str in collection3)
                Console.Write(str + " ");
            Program.Space();

            var concateResult = collection1.Concat(collection3).Concat(collection2);
            
            Console.WriteLine("After Concatenation:");
            foreach (string str in concateResult)
                Console.Write(str + " ");
            Program.Space();



            var cats = Pet.GetAllCats();
            var dogs = Pet.GetAllDogs();
            var birds = Pet.GetAllBirds();

            Console.WriteLine("List of cats:");
            var printCats = from s in cats select s.Name;
            foreach(var name in printCats){			
                Console.Write(name + " ");
            }
            Program.Space();
            Console.WriteLine("List of dogs:");
            var printDogs = from s in dogs select s.Name;
            foreach(var name in printDogs){			
                Console.Write(name + " ");
            }
            Program.Space();

            IEnumerable<string> query = cats.Select(cat => cat.Name).Concat(dogs.Select(dog => dog.Name));
            Console.WriteLine("List of cats & dogs:");
            foreach (string name in query)
            {
                Console.Write(name + " ");
            }

            IEnumerable<string> AllPets = cats.Select(cat => cat.Name).Concat(dogs.Select(dog => dog.Name)).Concat(birds.Select(birds => birds.Name));
            Console.WriteLine("List of all pets:");
            foreach (string name in AllPets)
            {
                Console.Write(name + " ");
            }

        }
        
    }

}