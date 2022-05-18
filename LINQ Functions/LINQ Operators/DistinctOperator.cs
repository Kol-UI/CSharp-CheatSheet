using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class DistinctOperator
    {
        public static void LINQDistinctMethod(){
            IList<string> strList = new List<string>(){ "One", "Two", "Three", "Two", "Three" };
            IList<int> intList = new List<int>(){ 1, 2, 3, 2, 4, 4, 3, 5 };

            var distinctList1 = strList.Distinct();
            foreach(var str in distinctList1)
                Console.Write(str + ", ");
            
            Program.Space();
            
            var distinctList2 = intList.Distinct();
            foreach(var i in distinctList2)
                Console.Write(i + ", ");
            
            Program.Space();

            DistinctProducts();
        }

        public static void DistinctProducts(){
            var allProducts = Product.GetAllProducts();
            Console.WriteLine("-- All Products List --");
            foreach (var item in allProducts)
                Console.WriteLine(item.Name + " Code: " + item.Code);
            IEnumerable<Product> noduplicates = allProducts.Distinct();
            Console.WriteLine("-- Excluding all duplicates with Distinct--");
            foreach (var product in noduplicates)
                Console.WriteLine(product.Name + " Code: " + product.Code);
        }
        
    }

}