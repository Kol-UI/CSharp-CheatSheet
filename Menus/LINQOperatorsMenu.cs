using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQOperatorsMenu
    {
        public static void LINQOperators(IList<Student> studentList){
            Program.Space();
            Console.WriteLine("Which LINQ Operator ? \n1) Filtering Operator \n2) Sorting Operator\n3) Grouping Operators");
            var InputOperator = Console.ReadLine();
            int valueInputOperator = int.Parse(InputOperator);
            switch (valueInputOperator)
            {
                case 1: // Filtering Operators (Where OfType)
                    Program.Space();
                    Console.WriteLine("Which LINQ Filtering Operator ? \n1) Where\n2) OfType");
                    var InputFilteringOperator = Console.ReadLine();
                    int valueInputFilteringOperator = int.Parse(InputFilteringOperator);
                    switch (valueInputFilteringOperator)
                    {
                        case 1:
                            WhereOperator.LINQWhereFunction(studentList);
                            break;
                        case 2:
                            OfTypeOperator.LINQOfTypeFunction();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators(studentList);
                            break;
                    }
                    break;
                case 2: // Sorting Operators (OrderBy ThenBy)
                    Program.Space();
                    Console.WriteLine("Which LINQ Sorting Operator ? \n1) OrderBy\n2) OrderByDescending\n3) ThenBy\n4) ThenByDescending");
                    var InputSortingOperator = Console.ReadLine();
                    int valueInputSortingOperator = int.Parse(InputSortingOperator);
                    switch (valueInputSortingOperator)
                    {
                        case 1:
                            // OrderBy
                            OrderByOperator.LINQOrderByFunction(studentList);
                            break;
                        case 2:
                            // OrderByDescending
                            OrderByOperator.LINQOrderByDescendingFunction(studentList);
                            break;
                        case 3:
                            // ThenBy
                            ThenByOperator.LINQThenByFunction(studentList);
                            break;
                        case 4:
                            // ThenByDescending
                            ThenByOperator.LINQThenByDescendingFunction(studentList);
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators(studentList);
                            break;
                    }
                    break;
                case 3: // Grouping Operators (GroupBy ToLookup)
                    Program.Space();
                    Console.WriteLine("Which LINQ Grouping Operator ? \n1) GroupBy (Query Syntax)\n2) GroupBy (Method Syntax)");
                    var InputGroupingOperator = Console.ReadLine();
                    int valueInputGroupingOperator = int.Parse(InputGroupingOperator);
                    switch (valueInputGroupingOperator)
                    {
                        case 1:
                            // GroupBy Query
                            GroupByOperator.LINQGroupByFunctionQuery(studentList);
                            break;
                        case 2:
                            // GroupBy Method
                            GroupByOperator.LINQGroupByFunctionMethod(studentList);
                            break;
                        case 3:
                            // ToLookUp
                            Program.LINQToLookUpFunction(studentList);
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators(studentList);
                            break;
                    }
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    LINQOperators(studentList);
                    break;
            }
        }
    }

}