using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class InputFunctions
    {
        public static void InputExercise()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            Program.Space();
        }

        public static void AddInputToString(){
            string str; 
            int l = 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(l,1);
                Console.WriteLine(s + str + s);
            }
        }

        public static void SwapVariable()
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " +number1);
            Console.Write("\nSecond Number : " +number2);
            // Console.Read();
            Program.Space();
            SecondSwap();
        }

        public static void SecondSwap()
        {
            Program.Space();
            Console.WriteLine("----- Second Swap -----");
            Console.WriteLine("First Number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int B = Convert.ToInt32(Console.ReadLine());
            int SWAP1 = A;
            int SWAP2 = B;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("THE FIRST NUMBER IS " + A);
            Console.WriteLine("THE SECOND NUMBER IS " + B);
            Console.WriteLine("---------------------------\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AFTER SWAPPING: \n");
            Console.WriteLine("FIRST NUMBER IS " + SWAP2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SECOND NUMBER IS " + SWAP1);
            Console.ResetColor();
            Program.Space();
        }

        public static void WordModif()
        {
            Program.Space();
            Console.WriteLine("Which Function ? \n1) Remove a letter\n2) Change first and last letter");
            var WordModifInput = Console.ReadLine();
            int valueWordModifInput = int.Parse(WordModifInput);
            switch (valueWordModifInput)
            {
                case 1:
                    RemoveLetter();
                    break;
                case 2:
                    ChangeFirstAndLast();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    WordModif();
                    break;
            }
            Program.Space();
        }

        public static void RemoveLetter()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the letter of the word you want removed");
            string letter = Console.ReadLine();
            int charPos = word.IndexOf($"{letter}");
            Console.WriteLine("Result: " + word.Remove(charPos, 1));
        }

        public static void ChangeFirstAndLast()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Result:" + $"{word[word.Length-1]}" + $"{word.Substring(1,word.Length-2)}" + $"{word[0]}");
        }

        public static void DisplayTriangle(){
            Console.Write("Input a number: ");
            int num = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32( Console.ReadLine() );
            
            int height = width;   
            for (int row=0; row < height; row++)
            {
                for (int column=0; column < width; column++)
                {
                    Console.Write( num );
                }
            
                Console.WriteLine();
                width--;
            }
        }

        public static void LoginAlgo()
        {
            string username, password;
            string goodUsername = "username";
            string goodPassword = "password";
            int ctr = 0, dd=0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("Default username and password are : {0} and {0}\n", goodUsername, goodPassword);
            Console.Write("---------------------------------\n"); 
            do{
                    Console.Write("Input a username: ");
                username = Console.ReadLine();
                
                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if( username == goodUsername && password == goodPassword )
                {
                    dd=1;
                    ctr=3;
                }

                else
                {
                    dd=0;
                    ctr++;
                }
            }
            while (( username != goodUsername || password != goodPassword )&& (ctr != 3));
                if (dd == 0)
                {
                    Console.Write("\nLogin attemp more than three times. Try later!\n\n");
                }
                else  
                if(dd==1)
                {
                    Console.Write("\nPassword entered successfull!\n\n");
                }         
        }

        public static void CheckVowelDigitSymbol()
        {
            char symbol;
            
            Console.Write("Input a symbol: ");
            symbol=Convert.ToChar(Console.ReadLine());
            
            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's not a symbol.\nIt's not a digit.");
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's not a lowercase vowel.\nIt's not a symbol.");
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.WriteLine("It's not a lowercase vowel.\nIt's not a digit.");
                Console.Write("It's another symbol."); 
            }
                
        }

        
    }

}