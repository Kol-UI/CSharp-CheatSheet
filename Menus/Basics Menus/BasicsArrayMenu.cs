﻿using System;

namespace CSharp_CheatSheet
{
    public class BasicsArrayMenu
    {
       public static void MenuInputArray()
       {
            Program.Space();
            Console.WriteLine("Which Array ?\n1) Frequency in Array  2) Create an Array  3) Reverse an Array  4) Fast Reverse  5) Sum of Elements in Array  6) Sum Of Elements In Array (.Sum)");
            Console.WriteLine("7) Copy from one Array to another  8) Count Number of Dublicate  9) Print Unique Element  10) Merge Arrays In Order");
            Console.WriteLine("11) Get Min & Max of an Array  12) Sorting an Array  13) Insert New Value in Array  14) Array to Matrix  15) Array Overview  16) Passing Arrays as Arguments");
            var ArrayInput = Console.ReadLine();
            int valueArrayInput = int.Parse(ArrayInput);
            switch (valueArrayInput)
            {
                case 1:
                    ArrayFunctions.FrequencyInArray();
                    break;
                case 2:
                    ArrayFunctions.CreateAnArray();
                    break;
                case 3:
                    ArrayFunctions.ReverseAnArray();
                    break;
                case 4:
                    ArrayFunctions.FastReverse();
                    break;
                case 5:
                    ArrayFunctions.SumOfElementsInArray();
                    break;
                case 6:
                    ArrayFunctions.SumOfElementsInArrayMethod();
                    break;
                case 7:
                    ArrayFunctions.CopyArrays();
                    break;
                case 8:
                    ArrayFunctions.CountTotalNumberOfDublicateElements();
                    break;
                case 9:
                    ArrayFunctions.PrintUniqueElement();
                    break;
                case 10:
                    ArrayFunctions.MergeArraysInOrder();
                    break;
                case 11:
                    ArrayFunctions.GetMinMaxArray();
                    break;
                case 12:
                    ArrayFunctions.SortingArray();
                    break;
                case 13:
                    ArrayFunctions.InsertNewValueInArray();
                    break;
                case 14:
                    ArrayFunctions.ArrayToMatrix();
                    break;
                case 15:
                    ArrayFunctions.ArrayOverview();
                    break;
                case 16:
                    ArrayFunctions.PassingArrayAsArgument();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
        }
    }
}
