using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQMainMenu
    {
        // LINQ Functions
        public static void LinqFunctions()
        {
            Program.Space();
            Console.WriteLine("Which LINQ Function ? \n1) Basic LINQ\n2) Find Positive\n3) Find Number after specifics calculations\n4) Frequency\n5) Linq Syntaxe\n6) Operators List\n7) Subjects Examples\n8) Advanced LINQ");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1:
                    LINQBasics.BasicLINQ();
                    LINQBasics.BasicLINQOneLine();
                    LINQBasics.BasicLINQOneLineTwo();
                    break;
                case 2:
                    LINQBasics.FindPositive();
                    break;
                case 3:
                    LINQBasics.LINQCalculations();
                    break;
                case 4:
                    LINQBasics.FrequencyFunction();
                    break;
                case 5:
                    LINQQuerySyntaxeMenu.QuerySyntaxeQuestions();
                    break;
                case 6:
                    LINQOperatorsMenu.LINQOperators();
                    break;
                case 7: // Subjects Examples
                    CardsFaroShuffle.CardsFaroShuffleMain();
                    break;
                case 8: // Advanced LINQ
                    LINQAdvancedMenu.LinqAvancedMenuFunctions();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    LinqFunctions();
                    break;
            }
            Program.Space();
        }
    }

}