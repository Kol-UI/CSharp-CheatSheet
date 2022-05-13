using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ElementAtOrDefaultOperator
    {
        public static void LINQElementAtOrDefaultFunction(){
            string[] names = { "Hartono, Tommy", "Adams, Terry", "Andersen, Henriette Thaulow", "Hedlund, Magnus", "Ito, Shu" };
            int index = 20;
            string name = names.ElementAtOrDefault(index);
            Console.WriteLine("The name chosen at index {0} is '{1}'.", index, String.IsNullOrEmpty(name) ? "<no name at this index>" : name);

        }
        
    }

}