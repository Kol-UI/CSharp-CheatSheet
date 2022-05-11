using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SelectManyOperator
    {
        public static void SelectManyFunction(){
            List<string> phrases = new() { "an apple a day", "the quick brown fox" };

            var query = from phrase in phrases
                        from word in phrase.Split(' ')
                        select word;
            
            Program.Space();
            foreach (string s in query)
                Console.WriteLine(s);
        }

        public static void SelectVsSelectMany(){
            List<Bouquet> bouquets = new()
            {
                new Bouquet { Flowers = new List<string> { "sunflower", "daisy", "daffodil", "larkspur" }},
                new Bouquet { Flowers = new List<string> { "tulip", "rose", "orchid" }},
                new Bouquet { Flowers = new List<string> { "gladiolis", "lily", "snapdragon", "aster", "protea" }},
                new Bouquet { Flowers = new List<string> { "larkspur", "lilac", "iris", "dahlia" }}
            };

            IEnumerable<List<string>> query1 = bouquets.Select(bq => bq.Flowers);

            IEnumerable<string> query2 = bouquets.SelectMany(bq => bq.Flowers);

            Console.WriteLine("Results by using Select():");
            // Extra foreach loop (Because Select)
            foreach (IEnumerable<String> collection in query1)
                foreach (string item in collection)
                    Console.WriteLine(item);
            
            Program.Space();
            Console.WriteLine("\nResults by using SelectMany():");
            foreach (string item in query2)
                Console.WriteLine(item);

        }

        class Bouquet
        {
            public List<string> Flowers { get; set; }
        }

    }

}