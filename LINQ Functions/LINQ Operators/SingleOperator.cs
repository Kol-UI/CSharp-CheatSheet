using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SingleOperator
    {
        public static void LINQSingleMethod(){
            Console.WriteLine("Returns the only element from a collection, or the only element that satisfies a condition. If Single() found no elements or more than one elements in the collection then throws InvalidOperationException.");
            string[] fruits1 = { "orange" };
            string[] fruits2 = { "orange", "apple" };
            string fruit2 = null;
            string fruit1 = fruits1.Single();
            string[] fruits3 = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };
            string fruit3 = fruits3.Single(fruit => fruit.Length > 10);
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
            
            // One element
            Console.WriteLine(fruit1);

            // Not containing the exact one
            try
            {
                fruit2 = fruits2.Single();
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("The collection does not contain exactly one element.");
            }
            Console.WriteLine(fruit2);

            // The condition one
            Console.WriteLine(fruit3);

            // The condition does not contain it
            try
            {
                fruit2 = fruits3.Single(fruit => fruit.Length > 15);
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine(@"The collection does not contain exactly one element whose length is greater than 15.");
            }
            Console.WriteLine(fruit2);

            // Other basics examples
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.SingleOrDefault());
            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());
            Console.WriteLine("The only element which is less than 10 in intList: {0}", intList.Single(i => i < 10));

        }
        
    }

}