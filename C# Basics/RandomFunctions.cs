using System;
using System.Linq;

namespace CSharp_CheatSheet.CBasics
{
    public class RandomFunctions
    {
        public static void RandomFunctionsMain()
        {
            int random0 = 0;
            int random1 = CreateRandom(random0);
            int random2 = CreateRandom(random0);
            int random3 = CreateRandom(random0);

            Console.WriteLine("--- Create Random ---");
            Console.WriteLine("{0} {1} {2}", random1, random2, random3);
            Program.Space();

            Console.WriteLine("--- Static Random ---");
            UseStatic();
            UseStatic();
            UseStatic();
            Program.Space();

            Console.WriteLine("--- Random .Next ---");
            int random4 = FNext(random0);
            int random5 = FNext(random0);
            int random6 = FNext(random0);
            Console.WriteLine("{0} {1} {2}", random4, random5, random6);
            Program.Space();

            Console.WriteLine("--- Random Modulo ---");
            int[] array = new int[3];
            RandomModulo(array);
            ShowArrayModulo(array);
            Program.Space();

            Console.WriteLine("--- Randomize String ---");
            const string original = "random";
            RandomizeString(original);
            Program.Space();

            Console.WriteLine("--- Random Bytes ---");
            byte[] byteArray = new byte[10];
            Random random = new Random();
            random.NextBytes(byteArray);
            DisplayBytes(byteArray);
            random.NextBytes(byteArray);
            DisplayBytes(byteArray);
            Program.Space();

            Console.WriteLine("--- Random Shuffles ---");
            Program.Space();
            Console.WriteLine("--- Shuffling String Array ---");
            RandomShuffles.ShufflingStringArray();
            RandomShuffles.ShufflingStringArray();
            Program.Space();
        }

        private static int CreateRandom(int random)
        {
            Random rnd = new Random();
            random = rnd.Next(5, 10);
            return random;
        }

        private static Random _random = new Random();

        private static void UseStatic()
        {
            int result = _random.Next();
            Console.WriteLine("STATIC RANDOM: " + result);
        }

        private static int FNext(int random)
        {
            Random rnd = new Random();
            random = rnd.Next(5);
            return random;
        }

        private static int[] RandomModulo(int[] array)
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int result = random.Next(0, 100);
                int modulo = result % array.Length;
                array[modulo]++;
            }
            return array;
        }

        private static void ShowArrayModulo(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("ARRAY {0} = {1}", i, array[i]);
            }
        }

        private static void RandomizeString(string randomChar)
        {
            Random num = new Random();
            string rand = new string(randomChar.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
            Console.WriteLine("original: {0}\r\nrand: {1}", randomChar, rand);
        }

        private static void DisplayBytes(byte[] byteArray)
        {
            foreach (byte value in byteArray)
            {
                if (value >= 200)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    if (value >= 150 & value < 200)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        if (value >= 100 & value < 150)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                }
                Console.Write(value);
                Console.ResetColor();
                Console.Write(' ');
            }
            Program.Space();
        }
    }
}
