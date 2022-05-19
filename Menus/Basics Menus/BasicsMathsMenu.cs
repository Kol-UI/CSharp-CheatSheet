using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class BasicsMathsMenu
    {
        // Maths Functions
        public static void BasicsMaths()
        {
            Program.Space();
            Console.WriteLine("Which Maths Function ?");
            Console.WriteLine("1) Sum   2) Divide   3) MoreMaths   4) InputMultiplication  5) MoreInputMaths   6) MultiplicationTable");
            Console.WriteLine("7) Check Positive/Negative   8) Conditional Sum   9) Simple Calculator   10) Perimeter & Area   11) Calculate Speed");
            Console.WriteLine("12) Sphere Area   13) Sphere Volume   14) Decimal to Binary");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1: // Sum
                    MathsFunctions.Sum();
                    break;
                case 2: // Divide
                    MathsFunctions.Divide();
                    break;
                case 3: // MoreMaths
                    MathsFunctions.MoreMaths();
                    break;
                case 4: // InputMultiplication
                    MathsFunctions.InputMultiplication();
                    break;
                case 5: // MoreInputMaths
                    MathsFunctions.MoreInputMaths();
                    break;
                case 6: // MultiplicationTable
                    MathsFunctions.MultiplicationTable();
                    break;
                case 7: // Check Positive/Negative
                    MathsFunctions.CheckPosNeg();
                    break;
                case 8: // Conditional Sum
                    MathsFunctions.ConditionalSum();
                    break;
                case 9: // Simple Calculator
                    MathsFunctions.SimpleCalculator();
                    break;
                case 10: // Perimeter & Area
                    MathsFunctions.PerimeterAndAreaCircle();
                    break;
                case 11: // Calculate Speed
                    MathsFunctions.CalculateSpeed();
                    break;
                case 12: // Sphere Area
                    MathsFunctions.SphereArea();
                    break;
                case 13: // Sphere Volume
                    MathsFunctions.SphereVolume();
                    break;
                case 14: // Decimal to Binary
                    MathsFunctions.DecimalToBinary();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }

}