using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class BasicsInputMenu
    {
        public static void MenuInput(){
            Program.Space();
            Console.WriteLine("Which Input ?\n1) Original Input   2) AddInputToString    3) Swap Variable     4) Word Modif   5) Display a Triangle     6) Login Algo");
            Console.WriteLine("7) Check Vowel Digit & Symbol");
            var BasicsInput = Console.ReadLine();
            int valueBasicsInput = int.Parse(BasicsInput);
            switch (valueBasicsInput)
            {
                case 1:
                    InputFunctions.InputExercise();
                    break;
                case 2:
                    InputFunctions.AddInputToString();
                    break;
                case 3:
                    InputFunctions.SwapVariable();
                    break;
                case 4:
                    InputFunctions.WordModif();
                    break;
                case 5:
                    InputFunctions.DisplayTriangle();
                    break;
                case 6:
                    InputFunctions.LoginAlgo();
                    break;
                case 7:
                    InputFunctions.CheckVowelDigitSymbol();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
        
    }

}