using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class CastOperator
    {
        public static void LINQCastMethod(){
            Console.WriteLine("Cast: Coverts a non-generic collection to a generic collection (IEnumerable to IEnumerable<T>)");
            System.Collections.ArrayList fruits = new System.Collections.ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            IEnumerable<string> query = fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

            // The following code, without the cast, doesn't compile.
            // IEnumerable<string> query1 = fruits.OrderBy(fruit => fruit).Select(fruit => fruit);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
        
    }

}