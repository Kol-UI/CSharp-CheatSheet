using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class LINQOperatorsMenu
    {
        public static void LINQOperators(){
            Program.Space();
            Console.WriteLine("Which LINQ Operator ? \n1) Filtering Operator\t\t2) Sorting Operator\t\t3) Grouping Operators\t\t4) Joining Operators\n5) Projection Operators\t\t6) Quantifier Operators\t\t7) Aggregation Operators\t8) Element Operators\n9) Equality Operators\t\t10) Concatenation Operators\t11) Generation Operators\t12) Set Operators\n13) Partitioning Operators\t14) Conversion Operators");
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
                            WhereOperator.LINQWhereMethod();
                            break;
                        case 2:
                            OfTypeOperator.LINQOfTypeFunction();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
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
                            OrderByOperator.LINQOrderByFunction();
                            break;
                        case 2:
                            // OrderByDescending
                            OrderByOperator.LINQOrderByDescendingFunction();
                            break;
                        case 3:
                            // ThenBy
                            ThenByOperator.LINQThenByMethod();
                            break;
                        case 4:
                            // ThenByDescending
                            ThenByOperator.LINQThenByDescendingMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 3: // Grouping Operators (GroupBy ToLookup)
                    Program.Space();
                    Console.WriteLine("Which LINQ Grouping Operator ? \n1) GroupBy (Query Syntax)\n2) GroupBy (Method Syntax)\n3) ToLookUp (Method Syntax Only)");
                    var InputGroupingOperator = Console.ReadLine();
                    int valueInputGroupingOperator = int.Parse(InputGroupingOperator);
                    switch (valueInputGroupingOperator)
                    {
                        case 1:
                            // GroupBy Query
                            GroupByOperator.LINQGroupByMethodQuery();
                            break;
                        case 2:
                            // GroupBy Method
                            GroupByOperator.LINQGroupByMethodMethod();
                            break;
                        case 3:
                            // ToLookUp
                            ToLookUpOperator.LINQToLookUpMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 4: // Joining Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Joining Operator ? \n1) Join\n2) Group Join (Method)\n3) Group Join (Query)\n4) Group Join Complexe (Method)\n5) Group Join Complexe (Query)\n6) Group Join User Defined");
                    var InputJoiningOperator = Console.ReadLine();
                    int valueInputJoiningOperator = int.Parse(InputJoiningOperator);
                    switch (valueInputJoiningOperator)
                    {
                        case 1: // Join
                            JoinOperator.JoinOperatorFunction();
                            JoinOperator.JoinMoreComplexe();
                            break;
                        case 2: // Group Join
                            GroupJoinOperator.GroupJoinOperatorMethod();
                            break;
                        case 3:
                            GroupJoinOperator.GroupJoinQuerySyntaxeMethod();
                            break;
                        case 4:
                            GroupJoinOperator.GroupJoinMoreComplexeMethod();
                            break;
                        case 5:
                            GroupJoinOperator.GroupJoinMoreComplexeMethodQuery();
                            break;
                        case 6:
                            GroupJoinOperator.GroupJoinMoreComplexeMethodUserDefined();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 5: // Projection Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Projection Operator ? \n1) Select Operator\n2) Select Operator (Query Syntaxe)\n3) Select Operator (Method Syntaxe)\n4) Select Many Operator\n5) Select vs Select Many\n6) Zip Operator");
                    var InputProjectionOperator = Console.ReadLine();
                    int valueInputProjectionOperator = int.Parse(InputProjectionOperator);
                    switch (valueInputProjectionOperator)
                    {
                        case 1: // Select
                            SelectOperator.SelectFunction();
                            break;
                        case 2:
                            SelectOperator.SelectQuerySyntaxe();
                            break;
                        case 3:
                            SelectOperator.SelectMethodSyntaxe();
                            break;
                        case 4:
                            SelectManyOperator.SelectManyFunction();
                            break;
                        case 5:
                            SelectManyOperator.SelectVsSelectMany();
                            break;
                        case 6:
                            ZipOperator.LINQZipMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;

                
                case 6: // Quantifier Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Quantifier Operator ? \n1) All\n2) Any\n3) Contains");
                    var InputQuantifierOperator = Console.ReadLine();
                    int valueInputQuantifierOperator = int.Parse(InputQuantifierOperator);
                    switch (valueInputQuantifierOperator)
                    {
                        case 1: // All
                            Console.WriteLine("----- All Operator -----\nChecks if all the elements in a sequence satisfies the specified condition");
                            AllOperator.LINQAllMethod();
                            break;
                        case 2: // Any
                            AnyOperator.LINQAnyMethod();
                            break;
                        case 3: // Contains
                            ContainsOperator.LINQContainsMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 7: // Aggregation Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Quantifier Operator ? \n1) Aggregate\n2) LongCount\n3) Average\n4) Count\n5) Max\n6) Min\n7) Sum");
                    var InputAggregationOperator = Console.ReadLine();
                    int valueInputAggregationOperator = int.Parse(InputAggregationOperator);
                    switch (valueInputAggregationOperator)
                    {
                        case 1: // Aggregate
                            Console.WriteLine("Aggregate: Performs a custom aggregation operation on the values in the collection.");
                            AggregateOperator.LINQAggregateMethod();
                            break;
                        case 2: // LongCount
                            LongCountOperator.LINQLongCountOperator();
                            LongCountOperator.LINQLongCountOperatorStudents();
                            LongCountOperator.LINQLongCountOperator2();
                            break;
                        case 3: // Average
                            AverageOperator.LINQAverageMethod();
                            break;
                        case 4: // Count
                            CountOperator.LINQCountMethod();
                            break;
                        case 5: // Max
                            MaxOperator.LINQMaxFunction();
                            break;
                        case 6: // Min
                            MinOperator.LINQMinFunction();
                            break;
                        case 7: // Sum
                            SumOperator.LINQSumMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 8:// Element Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Element Operator ? \n1) ElementAt\n2) ElementAtOrDefault\n3) First\n4) FirstOrDefault\n5) Last\n6) LastOrDefault\n7) Single\n8) SingleOrDefault");
                    var InputElementOperator = Console.ReadLine();
                    int valueInputElementOperator = int.Parse(InputElementOperator);
                    switch (valueInputElementOperator)
                    {
                        case 1: // ElementAt
                            Console.WriteLine("ElementAt: Returns the element at a specified index in a collection.");
                            ElementAtOperator.LINQElementAtMethod();
                            break;
                        case 2: // ElementAtOrDefault
                            Console.WriteLine("ElementAtOrDefault: Returns the element at a specified index in a collection or a default value if the index is out of range.");
                            ElementAtOrDefaultOperator.LINQElementAtOrDefaultMethod();
                            break;
                        case 3: // First
                            Console.WriteLine("First: Returns the first element of a collection, or the first element that satisfies a condition.");
                            FirstOperator.LINQFirstMethod();
                            break;
                        case 4: // FirstOrDefault
                            Console.WriteLine("FirstOrDefault: Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if index is out of range.");
                            FirstOrDefaultOperator.LINQFirstOrDefaultMethod();
                            break;
                        case 5: // Last
                            LastOperator.LINQLastOperatorFunction();
                            break;
                        case 6: // LastOrDefault
                            LastOrDefaultOperator.LINQLastOrDefaultFunction();
                            break;
                        case 7: // Single
                            SingleOperator.LINQSingleMethod();
                            break;
                        case 8: // SingleOrDefault
                            SingleOrDefaultOperator.LINQSingleOrDefaultMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 9: // Equality Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Equality Operator ? \n1) SequenceEqual");
                    var InputEqualityOperator = Console.ReadLine();
                    int valueInputEqualityOperator = int.Parse(InputEqualityOperator);
                    switch (valueInputEqualityOperator)
                    {
                        case 1: // SequenceEqual
                            SequenceEqualOperator.LINQSequenceEqualFunction();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;
                
                
                case 10: // Concatenation Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Concatenation Operator ? \n1) Concat");
                    var InputConcatenationOperator = Console.ReadLine();
                    int valueInputConcatenationOperator = int.Parse(InputConcatenationOperator);
                    switch (valueInputConcatenationOperator)
                    {
                        case 1: // Concat
                            ConcatOperator.LINQConcatMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 11: // Generation Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Generation Operator ? \n1) DefaultIfEmpty\n2) Empty\n3) Range\n4) Repeat");
                    var InputGenerationOperator = Console.ReadLine();
                    int valueInputGenerationOperator = int.Parse(InputGenerationOperator);
                    switch (valueInputGenerationOperator)
                    {
                        case 1: // DefaultIfEmpty
                            DefaultIfEmptyOperator.LINQDefaultIfEmptyMethod();
                            break;
                        case 2: // Empty
                            EmptyOperator.LINQEmptyMethod();
                            break;
                        case 3: // Range
                            RangeOperator.LINQRangeFunction();
                            break;
                        case 4: // Repeat
                            RepeatOperator.LINQRepeatFunction();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 12: // Set Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Set Operator ? \n1) Distinct\n2) Except\n3) Intersect\n4) Union");
                    var InputSetOperator = Console.ReadLine();
                    int valueInputSetOperator = int.Parse(InputSetOperator);
                    switch (valueInputSetOperator)
                    {
                        case 1: // Distinct
                            Console.WriteLine("-- Distinct: Returns distinct values from a collection --");
                            DistinctOperator.LINQDistinctMethod();
                            break;
                        case 2: // Except
                            Console.WriteLine("-- Except: Returns the difference between two sequences, which means the elements of one collection that do not appear in the second collection --");
                            ExceptOperator.LINQExceptMethod();
                            break;
                        case 3: // Intersect
                            Console.WriteLine("-- Intersect: Returns the intersection of two sequences, which means elements that appear in both the collections --");
                            IntersectOperator.LINQIntersectFunction();
                            break;
                        case 4: // Union
                            Console.WriteLine("-- Union: Returns unique elements from two sequences, which means unique elements that appear in either of the two sequences --");
                            UnionOperator.LINQUnionMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;


                case 13: // Partitioning Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Partitioning Operator ? \n1) Skip\n2) SkipWhile\n3) Take\n4) TakeWhile");
                    var InputPartitioningOperator = Console.ReadLine();
                    int valueInputPartitioningOperator = int.Parse(InputPartitioningOperator);
                    switch (valueInputPartitioningOperator)
                    {
                        case 1: // Skip
                            Console.WriteLine("-- Skip: Skips elements up to a specified position starting from the first element in a sequence --");
                            SkipOperator.LINQSkipMethod();
                            break;
                        case 2: // SkipWhile
                            Console.WriteLine("-- SkipWhile: Skips elements based on a condition until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition, it then skips 0 elements and returns all the elements in the sequence --");
                            SkipWhileOperator.LINQSkipWhileMethod();
                            break;
                        case 3: // Take
                            Console.WriteLine("-- Take: Takes elements up to a specified position starting from the first element in a sequence --");
                            TakeOperator.LINQTakeMethod();
                            break;
                        case 4: // TakeWhile
                            Console.WriteLine("-- TakeWhile: Returns elements from the first element until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition then returns an empty collection --");
                            TakeWhileOperator.LINQTakeWhileMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;



                case 14: // Conversion Operators
                    Program.Space();
                    Console.WriteLine("Which LINQ Conversion Operator ? \n1) AsEnumerable\n2) AsQueryable\n3) Cast\n4) ToArray\n5) ToDictionary\n6) ToList");
                    var InputConversionOperator = Console.ReadLine();
                    int valueInputConversionOperator = int.Parse(InputConversionOperator);
                    switch (valueInputConversionOperator)
                    {
                        case 1: // AsEnumerable
                            AsEnumerableOperator.LINQAsEnumerableMethod();
                            break;
                        case 2: // AsQueryable
                            AsQueryableOperator.LINQAsQueryableMethod();
                            break;
                        case 3: // Cast
                            CastOperator.LINQCastMethod();
                            break;
                        case 4: // ToArray
                            ToArrayOperator.LINQToArrayMethod();
                            break;
                        case 5: // ToDictionary
                            ToDictionaryOperator.LINQToDictionaryMethod();
                            break;
                        case 6: // ToList
                            ToListOperator.LINQToListMethod();
                            break;
                        default:
                            Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                            LINQOperators();
                            break;
                    }
                    break;
                
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    LINQOperators();
                    break;
            }
        }
    }

}