using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class ZipOperator
    {
        public static void LINQZipMethod(){
            IEnumerable<int> numbers = new[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            IEnumerable<char> letters = new[]{'A', 'B', 'C', 'D', 'E', 'F'};


            foreach ((int number, char letter) in numbers.Zip(letters))
                Console.WriteLine($"Number: {number} zipped with letter: '{letter}'");

            foreach (string result in numbers.Zip(letters, (number, letter) => $"{number} = {letter} ({(int)letter})"))
                Console.WriteLine(result);
        }

    }

}