using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQStringCollection
    {
        public static void LINQSyntaxeStringCollection(){
            // string collection
            IList<string> stringList = new List<string>() { "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials" , "Java" };
            // LINQ Query Syntax
            var result = from s in stringList where s.Contains("Tutorials") select s;
            foreach (var str in result)
			    Console.WriteLine(str);
        }
    }
}