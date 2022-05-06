using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQQuerySyntaxeMenu
    {
    public static void QuerySyntaxeQuestions(){
            Program.Space();
            Console.WriteLine("Which LINQ Syntaxe ? \n1) String Collection\n2) Sequence Collection\n3) Anonymous Method\n4) Lambda Expressions");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1:
                    LINQStringCollection.LINQSyntaxeStringCollection();
                    break;
                case 2:
                    LINQQuerySyntaxeSequence.LINQSyntaxeSequenceCollection();
                    break;
                case 3:
                    LINQAnonymousMethod.LINQAnonymousMethodFunction();
                    break;
                case 4:
                    LambdaLinq.LINQLambdaExpressions();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    QuerySyntaxeQuestions();
                    break;
            }
            Program.Space();
        }
    }

}

