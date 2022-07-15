using System;
using System.Collections.Generic;
using System.Linq;
namespace CSharp_CheatSheet.CBasics
{
    public class RandomShuffles
    {
        static Random _random = new Random();

        public static void ShufflingStringArray()
        {
            string[] arr = new string[]
            {
                "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray", "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow",
                "Gray", "Green", "Magenta", "Red", "White", "Yellow"
            };

            string[] shuffle = RandomizeStrings(arr);
            DisplayWithColors(shuffle);
        }


        public static void FisherYatesShuffle()
        {
            string[] arrayFisherYates = { "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray", "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow",
                "Gray", "Green", "Magenta", "Red", "White", "Yellow" };

            ShuffleForFisherYates(arrayFisherYates);
            Console.WriteLine("SHUFFLE: {0}", string.Join(",", arrayFisherYates));
            Console.WriteLine("Results :");
            DisplayWithColors(arrayFisherYates);
        }


        private static string[] RandomizeStrings(string[] arr)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            }

            var sorted = from item in list
                         orderby item.Key
                         select item;
            string[] result = new string[arr.Length];

            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            return result;
        }

        private static void DisplayWithColors(string[] shuffle)
        {
            foreach (string value in shuffle)
            {
                switch (value)
                {
                    case "Black":
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "DarkBlue":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "DarkCyan":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "DarkGray":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case "DarkGreen":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case "DarkMagenta":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "DarkRed":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "DarkYellow":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "Gray":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "Magenta":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "White":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        Console.ResetColor();
                        break;
                }
                Console.Write(value);
                Console.ResetColor();
                Console.Write(' ');
            }
            Program.Space();
        }


        static void ShuffleForFisherYates<T>(T[] arrayFisherYates)
        {
            int n = arrayFisherYates.Length;
            for (int i = 0; i < (n - 1); i++)
            {
                int r = i + _random.Next(n - i);
                T t = arrayFisherYates[r];
                arrayFisherYates[r] = arrayFisherYates[i];
                arrayFisherYates[i] = t;
            }
        }

        

    }
}
