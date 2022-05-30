using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class BasicsConditionalMenu
    {
        public static void MenuInputConditional(){
            Program.Space();
            Console.WriteLine("Which Input ?\n1) Temperature Statement\n2) Triangle Validity & Type\n3) Vowel or Consonant\n4) Profit & Loss");
            var CondInput = Console.ReadLine();
            int valueCondInput = int.Parse(CondInput);
            switch (valueCondInput)
            {
                case 1: // Temperature Statement
                    ConditionalFunctions.TemperatureStatement();
                    break;
                case 2: // Triangle Validity & Type
                    ConditionalFunctions.TriangleType();
                    break;
                case 3: // Vowel or Consonant
                    ConditionalFunctions.CheckVowelOrConsonant();
                    break;
                case 4: // Profit & Loss
                    ConditionalFunctions.ProfitAndLoss();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8: 
                    break;
                case 9: 
                    break;    
                case 10: 
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
        
    }

}