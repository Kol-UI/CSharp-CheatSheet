using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class EmptyOperator
    {
        public static void LINQEmptyFunction(){

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name );

            Console.WriteLine("Count: {0} ",emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name );

            IEnumerable<decimal> empty = Enumerable.Empty<decimal>();
            string[] names1 = { "Hartono, Tommy" };
            string[] names2 = { "Adams, Terry", "Andersen, Henriette Thaulow", "Hedlund, Magnus", "Ito, Shu" };
            string[] names3 = { "Solanki, Ajay", "Hoeing, Helge", "Andersen, Henriette Thaulow", "Potra, Cristina", "Iallo, Lucio" };

            List<string[]> namesList = new List<string[]> { names1, names2, names3 };

            // Only include arrays that have four or more elements
            IEnumerable<string> allNames = namesList.Aggregate(Enumerable.Empty<string>(), (current, next) => next.Length > 3 ? current.Union(next) : current);
            // If less than 3, returned as empty
            // names1 of not in allNames

            foreach (string name in allNames)
            {
                Console.WriteLine(name);
            }
        }
        
    }

}