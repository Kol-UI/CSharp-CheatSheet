using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp_CheatSheet
{
    public class RemoveDiacritics
    {
        public static void DiacriticsMain()
        {
            Console.WriteLine("Example :");
            string text = "Я ем crème brûlée, а не mashed potatoes !";
            // for strings
            var newText = text.RemoveDiacritics();
            // for chars
            "Ã"[0].RemoveDiacritics(); // A
            var charsToRemove = new string[] { "@", ",", "?", "§", ".", ";", "!", "&", "'", "#", "(", ")", "{", "}", "[", "]", "-", "_", "$", "*", "=", "+", "/", ":" };
            foreach (var c in charsToRemove)
            {
                newText = newText.Replace(c, string.Empty);
            }
            Console.WriteLine(text);
            Console.WriteLine(newText + "\n");


            // User Input
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter text:");
            Console.ResetColor();
            string textInput = Console.ReadLine();
            var newTextInput = textInput.RemoveDiacritics();
            var removeChars = new string[] { "@", ",", "?", "§", ".", ";", "!", "&", "'", "#", "(", ")", "{", "}", "[", "]", "-", "_", "$", "*", "=", "+", "/", ":" };
            int value = 0;
            foreach (var c in removeChars)
            {
                newTextInput = newTextInput.Replace(c, string.Empty);
            }
            foreach(char c in newTextInput)
            {
                switch(c)
                {
                    case '1':
                        Console.WriteLine(c + " +" + c);
                        value += 1;
                        break;
                    case '2':
                        Console.WriteLine(c + " +" + c);
                        value += 2;
                        break;
                    case '3':
                        Console.WriteLine(c + " +" + c);
                        value += 3;
                        break;
                    case '4':
                        Console.WriteLine(c + " +" + c);
                        value += 4;
                        break;
                    case '5':
                        Console.WriteLine(c + " +" + c);
                        value += 5;
                        break;
                    case '6':
                        Console.WriteLine(c + " +" + c);
                        value += 6;
                        break;
                    case '7':
                        Console.WriteLine(c + " +" + c);
                        value += 7;
                        break;
                    case '8':
                        Console.WriteLine(c + " +" + c);
                        value += 8;
                        break;
                    case '9':
                        Console.WriteLine(c + " +" + c);
                        value += 9;
                        break;
                    case '0':
                        Console.WriteLine(c + " +10");
                        value += 10;
                        break;
                    case '"':
                        break;
                    default:
                        int index = (int)c % 32;
                        Console.WriteLine(c + " +" + index);
                        value += index;
                        break;
                }       
                
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Result:");
            Console.ResetColor();
            Console.WriteLine("'{0}'", newTextInput);
            Console.WriteLine(value);

        }

    }
}