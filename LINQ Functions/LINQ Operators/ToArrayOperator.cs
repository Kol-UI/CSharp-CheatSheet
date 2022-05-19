using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ToArrayOperator
    {
        public static void LINQToArrayMethod(){
            Console.WriteLine("ToArray: Converts a collection to an array");
            Program.Space();
            var packages = Package.GetAllPackage();
            string[] companies = packages.Select(pkg => pkg.Company).ToArray();

            foreach (string company in companies)
            {
                Console.WriteLine(company);
            }

            Program.Space();
            IList<string> strList = new List<string>() { 
                "One", 
                "Two", 
                "Three", 
                "Four", 
                "Three" 
            };

            Console.WriteLine("strList type: {0}", strList.GetType().Name);
            string[] strArray = strList.ToArray<string>(); // converts List to Array
            Console.WriteLine("strArray type: {0}", strArray.GetType().Name);
            
        }
        
    }

}