using System;
namespace CSharp_CheatSheet.Methods.ArrayMethods
{
    public class Clone
    {
        public static void CloneMain()
        {
            Program.Title("Clone");
            string[] source = new[] { "Steff", "Donkey", "Jammy" };
            string[] target = (string[])source.Clone();
            foreach (var element in target)
            {
                Console.WriteLine(element);
            }
        }
    }
}
