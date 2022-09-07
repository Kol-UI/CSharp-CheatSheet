﻿using System;
namespace CSharp_CheatSheet.Menus.MethodsMenus
{
    public class ArrayMethodsMenu
    {
        public static void MenuArrayMethods()
        {
            Program.Space();
            Console.WriteLine("Which Array Method ?\n1) AsReadOnly  2) BinarySearch  3) Clear  4) Clone  5) ConstrainedCopy");
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
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
