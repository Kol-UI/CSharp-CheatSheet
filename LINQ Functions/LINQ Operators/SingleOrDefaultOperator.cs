using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SingleOrDefaultOperator
    {
        public static void LINQSingleOrDefaultMethod(){
            Console.WriteLine("The same as Single, except that it returns a default value of a specified generic type, instead of throwing an exception if no element found for the specified condition. However, it will thrown InvalidOperationException if it found more than one element for the specified condition in the collection.");
            string[] fruits1 = { "orange" };
            string fruit1 = fruits1.SingleOrDefault();
            Console.WriteLine(fruit1);
            string[] fruits2 = { };
            string fruit2 = fruits2.SingleOrDefault();
            Console.WriteLine(String.IsNullOrEmpty(fruit2) ? "No such string!" : fruit2);
            
            int[] pageNumbers = { };
            // Setting the default value to 1 after the query.
            int pageNumber1 = pageNumbers.SingleOrDefault();
            if (pageNumber1 == 0) pageNumber1 = 1;
            Console.WriteLine("The value of the pageNumber1 variable is {0}", pageNumber1);

            int pageNumber2 = pageNumbers.DefaultIfEmpty(1).Single();
            Console.WriteLine("The value of the pageNumber2 variable is {0}", pageNumber2);

            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };
            string fruit3 = fruits.SingleOrDefault(fruit => fruit.Length > 10);
            Console.WriteLine(fruit3);

            string fruit4 = fruits.SingleOrDefault(fruit => fruit.Length > 15);
            Console.WriteLine(String.IsNullOrEmpty(fruit2) ? "No such string!" : fruit4);
                
        }
        
    }

}