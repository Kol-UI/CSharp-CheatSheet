using System;
namespace CSharp_CheatSheet.Menus.MethodsMenus
{
    public class ArrayMethodsMenu
    {
        public static void MenuArrayMethods()
        {
            Program.Space();
            Console.WriteLine("Which Array Method ?\n1) AsReadOnly  2) BinarySearch  3) Clear  4) Clone  5) ConstrainedCopy  6) ConvertAll  7) Copy" +
                "\n8) CopyTo  9) CreateInstance  10) Empty  11) Exist  12) Fill  13) Find  14) FindAll  15) FindIndex " +
                "\n16) FindLast  17) ForEach  18) GetEnumerator  19) GetLength  20) GetLongLength  21) GetLowerBound  22) GetUpperBound  23) GetValue");
            var MathInput = Console.ReadLine();
            int valueMathInput = int.Parse(MathInput);
            switch (valueMathInput)
            {
                case 1:
                    Methods.ArrayMethods.AsReadOnly.AsReadOnlyFunction();
                    break;
                case 2:
                    Methods.ArrayMethods.BinarySearch.BinarySearchMethod();
                    break;
                case 3:
                    Methods.ArrayMethods.Clear.ClearMethod();
                    break;
                case 4:
                    Methods.ArrayMethods.Clone.CloneMain();
                    break;
                case 5:
                    Methods.ArrayMethods.ConstrainedCopy.ConstrainedCopyMain();
                    break;
                case 6:
                    Methods.ArrayMethods.ConvertAll.ConvertAllMain();
                    break;
                case 7:
                    Methods.ArrayMethods.Copy.CopyMain();
                    break;
                case 8:
                    Methods.ArrayMethods.CopyTo.CopyToMain();
                    break;
                case 9:
                    Methods.ArrayMethods.CreateInstance.CreateInstanceMain();
                    break;
                case 10:
                    Methods.ArrayMethods.Empty.EmptyMain();
                    break;
                case 11:
                    Methods.ArrayMethods.Exist.ExistMain();
                    break;
                case 12:
                    Methods.ArrayMethods.Fill.FillMain();
                    break;
                case 13:
                    Methods.ArrayMethods.Find.FindMain();
                    break;
                case 14:
                    Methods.ArrayMethods.FindAll.FindAllMain();
                    break;
                case 15:
                    Methods.ArrayMethods.FindIndex.FindIndexMain();
                    break;
                case 16:
                    Methods.ArrayMethods.FindLast.FindLastMain();
                    break;
                case 17:
                    Methods.ArrayMethods.ForEach.ForEachMain();
                    break;
                case 18:
                    Methods.ArrayMethods.GetEnumerator.GetEnumeratorMain();
                    break;
                case 19:
                    Methods.ArrayMethods.GetLength.GetLengthMain();
                    break;
                case 20:
                    Methods.ArrayMethods.GetLongLength.GetLongLengthMain();
                    break;
                case 21:
                    Methods.ArrayMethods.GetLowerBound.GetLowerBoundMain();
                    break;
                case 22:
                    Methods.ArrayMethods.GetUpperBound.GetUpperBoundMain();
                    break;
                case 23:
                    Methods.ArrayMethods.GetValue.GetValueMain();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
