using System;
namespace CSharp_CheatSheet.Menus.ExceptionsMenus
{
    public class MainExceptionsMenu
    {
        public static void ExceptionsMenu()
        {
            Program.Space();
            Console.WriteLine("Which Exception ?\n1) ArgumentNull  2) IndexOutOfRange  3) Rank  4) ArrayTypeMismatch  5) ArgumentOutOfRange");
            var MathInput = Console.ReadLine();
            int valueMathInput = int.Parse(MathInput);
            switch (valueMathInput)
            {
                case 1:
                    Exceptions.ArgumentNull.ArgumentNullExceptionMain();
                    break;
                case 2:
                    Exceptions.IndexOutOfRange.IndexOutOfRangeExceptionMain();
                    break;
                case 3:
                    Exceptions.Rank.RankExceptionMain();
                    break;
                case 4:
                    Exceptions.ArrayTypeMismatch.ArrayTypeMismatchMain();
                    break;
                case 5:
                    Exceptions.ArgumentOutOfRange.ArgumentOutOfRangeMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
