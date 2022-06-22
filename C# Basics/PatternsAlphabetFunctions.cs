using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class PatternsAlphabetFunctions
    {
        public static void AlphabetPatternsSelect(){
            Console.WriteLine("Specific Letter, All the Letters or Letters from Word ?\n1) Specific Letter\t2) All Letters\t\t3) Letters from Word");
            var AlphabetOrLetterInput = Console.ReadLine();
            int valueAlphabetOrLetterInput = int.Parse(AlphabetOrLetterInput);
            switch (valueAlphabetOrLetterInput)
            {
                case 1:
                    SpecificLetter();
                    break;
                case 2:
                    AllLetters();
                    break;
                case 3:
                    LettersFromWord();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }

        private static void SpecificLetter(){
            Console.WriteLine("Enter a Letter:");
            char LetterInput = Console.ReadKey().KeyChar;
            var output = "";
            var aLetter = "a"; var bLetter = "b"; var cLetter = "c";  var dLetter = "d";  var eLetter = "e";
            var fLetter = "f"; var gLetter = "g"; var hLetter = "h";  var iLetter = "i";  var jLetter = "j";
            var kLetter = "k"; var lLetter = "l"; var mLetter = "m";  var nLetter = "n";  var oLetter = "o";
            var pLetter = "p"; var qLetter = "q"; var rLetter = "r";  var sLetter = "s";  var tLetter = "t";
            var uLetter = "u"; var vLetter = "v"; var wLetter = "w";  var xLetter = "x";  var yLetter = "y";
            var zLetter = "z";
            Program.Space();
            output = LetterInput.ToString().ToLower(); 
            if (output == aLetter)
            {
                LetterA();
            }
            else if (output == bLetter)
            {
                LetterB();
            }
            else if (output == cLetter)
            {
                LetterC();
            }
            else if (output == dLetter)
            {
                LetterD();
            }
            else if (output == eLetter)
            {
                LetterE();
            }
            else if (output == fLetter)
            {
                LetterF();
            }
            else if (output == gLetter)
            {
                LetterG();
            }
            else if (output == hLetter)
            {
                LetterH();
            }
            else if (output == iLetter)
            {
                LetterI();
            }
            else if (output == jLetter)
            {
                LetterJ();
            }
            else if (output == kLetter)
            {
                LetterK();
            }
            else if (output == lLetter)
            {
                LetterL();
            }
            else if (output == mLetter)
            {
                LetterM();
            }
            else if (output == nLetter)
            {
                LetterN();
            }
            else if (output == oLetter)
            {
                LetterO();
            }
            else if (output == pLetter)
            {
                LetterP();
            }
            else if (output == qLetter)
            {
                LetterQ();
            }
            else if (output == rLetter)
            {
                LetterR();
            }
            else if (output == sLetter)
            {
                LetterS();
            }
            else if (output == tLetter)
            {
                LetterT();
            }
            else if (output == uLetter)
            {
                LetterU();
            }
            else if (output == vLetter)
            {
                LetterV();
            }
            else if (output == wLetter)
            {
                LetterW();
            }
            else if (output == xLetter)
            {
                LetterX();
            }
            else if (output == yLetter)
            {
                LetterY();
            }
            else if (output == zLetter)
            {
                LetterZ();
            }
            else
            {
                Console.WriteLine("--- Warning: not acceptable value ! ---\n");
            }
        }


        private static void AllLetters()
        {
            LetterA();
            LetterB();
            LetterC();
            LetterD();
            LetterE();
            LetterF();
            LetterG();
            LetterH();
            LetterI();
            LetterJ();
            LetterK();
            LetterL();
            LetterM();
            LetterN();
            LetterO();
            LetterP();
            LetterQ();
            LetterR();
            LetterS();
            LetterT();
            LetterU();
            LetterV();
            LetterW();
            LetterX();
            LetterY();
            LetterZ();
        }

        private static void LettersFromWord(){
            Console.WriteLine("Enter a Word:");
            string WordInput = Console.ReadLine();
            var output = "";
            var aLetter = "a"; var bLetter = "b"; var cLetter = "c";  var dLetter = "d";  var eLetter = "e";
            var fLetter = "f"; var gLetter = "g"; var hLetter = "h";  var iLetter = "i";  var jLetter = "j";
            var kLetter = "k"; var lLetter = "l"; var mLetter = "m";  var nLetter = "n";  var oLetter = "o";
            var pLetter = "p"; var qLetter = "q"; var rLetter = "r";  var sLetter = "s";  var tLetter = "t";
            var uLetter = "u"; var vLetter = "v"; var wLetter = "w";  var xLetter = "x";  var yLetter = "y";
            var zLetter = "z";
            Program.Space();
            foreach(char c in WordInput)
            {
                output = c.ToString().ToLower(); 
                if (output == aLetter)
                {
                    LetterA();
                }
                else if (output == bLetter)
                {
                    LetterB();
                }
                else if (output == cLetter)
                {
                    LetterC();
                }
                else if (output == dLetter)
                {
                    LetterD();
                }
                else if (output == eLetter)
                {
                    LetterE();
                }
                else if (output == fLetter)
                {
                    LetterF();
                }
                else if (output == gLetter)
                {
                    LetterG();
                }
                else if (output == hLetter)
                {
                    LetterH();
                }
                else if (output == iLetter)
                {
                    LetterI();
                }
                else if (output == jLetter)
                {
                    LetterJ();
                }
                else if (output == kLetter)
                {
                    LetterK();
                }
                else if (output == lLetter)
                {
                    LetterL();
                }
                else if (output == mLetter)
                {
                    LetterM();
                }
                else if (output == nLetter)
                {
                    LetterN();
                }
                else if (output == oLetter)
                {
                    LetterO();
                }
                else if (output == pLetter)
                {
                    LetterP();
                }
                else if (output == qLetter)
                {
                    LetterQ();
                }
                else if (output == rLetter)
                {
                    LetterR();
                }
                else if (output == sLetter)
                {
                    LetterS();
                }
                else if (output == tLetter)
                {
                    LetterT();
                }
                else if (output == uLetter)
                {
                    LetterU();
                }
                else if (output == vLetter)
                {
                    LetterV();
                }
                else if (output == wLetter)
                {
                    LetterW();
                }
                else if (output == xLetter)
                {
                    LetterX();
                }
                else if (output == yLetter)
                {
                    LetterY();
                }
                else if (output == zLetter)
                {
                    LetterZ();
                }
            }   
        }

        private static void LetterA(){
            int row, column;
            for (row = 0; row <= 7; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) || ((row == 0 || row == 3) && (column > 1 && column < 5)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterB(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterC(){
            int row, column;
            for(row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1 && (row != 0 && row != 6)) || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && (row == 1 || row == 5)))
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterD(){
            int row, column;
            for (row = 0; row <= 6; row++)
                {
                for (column = 0; column <= 6; column++)
                    {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                }
            Console.WriteLine();
        }

        private static void LetterE(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterF(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterG(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                if ((column == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5) || (row == 3 && column > 2 && column < 6) || (column == 5 && row != 0 && row != 2 && row != 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterH(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterI(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterJ(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterK(){
            int row, column, j = 5, i = 0;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                if (column == 1 || ((row == column + 1) && column != 0)) Console.Write("*");
                else if (row == i && column == j)
                {
                    Console.Write("*");
                    i++;
                    j--;
                }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        private static void LetterL(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || (row == 6 && column != 0 && column < 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            Console.WriteLine();;
            }
            Console.WriteLine();
        }

        private static void LetterM(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterN(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterO(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterP(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterQ(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterR(){
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterS()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterT()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterU()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterV()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterW()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    } 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterX()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterY()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void LetterZ()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}