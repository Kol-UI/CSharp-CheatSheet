using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class BasicsForLoopMenu
    {
        public static void MenuForInput(){
            Program.Space();
            Console.WriteLine("Which For Loop ?\n1) Multiplication Table    2) Many Mutiplication Tables");
            var BasicsForInput = Console.ReadLine();
            int valueBasicsForInput = int.Parse(BasicsForInput);
            switch (valueBasicsForInput)
            {
                case 1:
                    ForLoopFunctions.MultiplicationTable();
                    break;
                case 2:
                    ForLoopFunctions.ManyMutiplicationTable();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
        
    }

}