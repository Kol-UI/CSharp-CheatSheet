using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ExceptOperator
    {
        public static void LINQExceptFunction(){
            string[] delhiResidents = { "Ramesh", "Kapil", "Vikas", "Amit" };
            string[] kolkataResidents = { "Kapil", "Manmohan", "Deepak", "Amit" };
            
            var onlyDelhiResidents = delhiResidents.Except(kolkataResidents);
            
            Console.WriteLine("Only Delhi Residents:");
            foreach (var item in onlyDelhiResidents)
            {
                Console.WriteLine(item);
            }

        }
        
    }

}