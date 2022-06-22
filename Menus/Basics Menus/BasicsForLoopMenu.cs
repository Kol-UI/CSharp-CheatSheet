using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class BasicsForLoopMenu
    {
        public static void MenuForInput(){
            Program.Space();
            Console.WriteLine("Which For Loop ?\n1) Multiplication Table    2) Many Mutiplication Tables    3) Patterns   4) Factoral");
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
                    Program.Space();
                    Console.WriteLine("Which Pattern Loop ?\n1) Asterisk Triangle Pattern\t2) Numbers Triangle Pattern\t3) Repeated Number Triangle Patterns\n4) Increasing Number Triangle Patterns\t5) Increasing Number Pyramid Patterns\t6) Asterisk Rows Pyramid Patterns");
                    Console.WriteLine("7) Repeated Number Pyramid Patterns\t8) Diamond Partterns\t9) Alphabet Patterns");
                    var BasicsForPatternInput = Console.ReadLine();
                    int valueBasicsForPatternInput = int.Parse(BasicsForPatternInput);
                    switch (valueBasicsForPatternInput)
                        {
                            case 1:
                                ForLoopFunctions.AsteriskPatternLoop();
                                break;
                            case 2:
                                ForLoopFunctions.NumbersTrianglePattern();
                                break;
                            case 3:
                                ForLoopFunctions.RepeatedNumberTrianglePatterns();
                                break;
                            case 4:
                                ForLoopFunctions.IncreasingNumberTrianglePatterns();
                                break;
                            case 5:
                                ForLoopFunctions.IncreasingNumberPyramidPatterns();
                                break;
                            case 6:
                                ForLoopFunctions.AsteriskRowsPyramidPatterns();
                                break;
                            case 7:
                                ForLoopFunctions.RepeatedNumberPyramidPatterns();
                                break;
                            case 8:
                                ForLoopFunctions.DiamonPatterns();
                                break;
                            case 9:
                                PatternsAlphabetFunctions.AlphabetPatternsSelect();
                                break;
                            default:
                                Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                                break;
                        }
                    break;

                case 4:
                    ForLoopFunctions.CalculateFactorial();
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