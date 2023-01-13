## CSharp-CheatSheet

Program:
## Main Menu

    1. C# Basics
    2. DateTime
    3. Math
    4. Methods
    5. Regular Expressions
    6. Exceptions
    7. Linq Functions
    8. Data Structures

## 1. C# Basics

    1. User Input
        1. Original Input
        2. Add Input To String
        3. Swap Variables
        4. Word Modif
            1. Remove Letter
            2. Change First And Last
        5. Display Triangle
        6. Login Algo
        7. Check Vowel Digit & Symbol
    2. Basic Maths
        1. Sum
        2. Divide
        3. More Maths
        4. Input Multiplication
        5. More Input Maths
        6. Multiplication Table
        7. Check Positive/Negative
        8. Conditional Sum
        9. Simple Calculator
        10. Perimeter and Area of Circle
        11. Calculate Speed
        12. Sphere Area
        13. Sphere Volume
        14. Decimal to Binary
    3. Conditional Statements
        1. Temperature Statement
        2. Check Triangle Validity and Type
        3. Vowel or Consonant
        4. Profit & Loss
    4. Remove Diacritics
    5. For Loop
        1. Multiplication Table
        2. Many Multiplication Tables
        3. Patterns
            1. Asterisk Triangle Patterns
            2. Numbers Triangle Patterns
            3. Repeated Number Triangle Patterns
            4. Increasing Number Triangle Patterns
            5. Increasing Number Pyramid Patterns
            6. Asterisk Rows Pyramid Patterns
            7. Repeated Number Pyramid Patterns
            8. Diamond Patterns
            9. Alphabet Patterns
                1. Specific Letters
                2. All Letters
                3. Letters from Word
        4. Factorial
    6. Array
        1. Frenquency in Array
        2. Create an Array
        3. Reverse an Array
        4. Fast Reverse
        5. Sum of elements in Array
        6. Sum of elements in Array with .Sum
        7. Copy from one Array to another
        8. Count Number of Dublicate
        9. Print Unique Elements
        10. Merge Two Arrays in Order
        11. Get Min & Max of an Array
        12. Sorting an Array
        13. Insert New Value in Array
        14. Array to Matrix
            1. 2D Array to Matrix
            2. Addition of two Matrices
        15. Array Overview
            1. Single-Dimensional Array
            2. Declare & Set Array Element Values
            3. Alternative Syntax
            4. Declare Two-Dimensional Array
            5. Print Two-Dimensional Array
            6. Set Multi Dimensional Array Element Values
            7. Declare Jagged Array
            8. Set Values of the First Array in the Jagged Array Structure
            9. Get Number of Dimension of an Array
            10. Single Dimensional String Array
            11. Retrieving Data From Array
            12. Multi Array Dimensions Specified
            13. Multi String Array Dimensions Specified
            14. Three Dimensional Array
            15. Three Dimensional Array Dimension Specified
            16. Array Without Specifying the Rank
            17. Declare Int Jagged Array
            18. Initialize Int Jagged Array
            19. Access Individual Jagged Array Elements
            20. Shorthand Jagged Array Form
            21. Number of Arrays Contained in Jagged Array
            22. Single Dimensional Array Foreach Statement
            23. Multi Dimensional Array Foreach Statement
        16. Passing Arrays as Arguments
            1. Single Dimension Array as Arguments
            2. Multiple Dimension Array as Arguments
    7. Search & Sort
        1. Shell Sort
        2. Bogo Sort
        3. Bubble Sort
        4. Counting Sort
        5. Heap Sort
        6. Insertion Sort
        7. Merge Sort
        8. Permutation Sort
        9. Quick Sort
        10. Radix Sort
        11. Selection Sort
    8. Random
        1. Create Random
        2. Static Random
        3. Random.Next
        4. Random Modulo
        5. Randomize String
        6. Random Bytes
        7. Random Shuffle
            1. Shuffling String Array
            2. Fisher-Yates Shuffle
    9. Recursion
        1. Print Natural Numbers
        2. Print Reversed Natural Numbers
        3. Sum of First Natural Numbers
        4. Individual Digits
        5. Get Number of Digits
        6. Even and Odd
        7. Check if Prime Number
        8. Fibonacci Numbers
            1. No Recursive High Performance
            2. Recursive Bad Performance
            3. Find Fibonacci Numbers
        9. Boolean Compositions
        10. Palindrome Recursion
        11. Find Factorial
            1. Int Factorial
            2. String Factorial
        12. Permutations in Array
        13. Recursion of Two Numbers
            1. Greatest Common Divisor
            2. Least Common Multiple
        14. Convert Decimal Number to Binary
        15. Reverse a String
        16. Calcul Power Of Number
    10. Naming Conventions
        1. Terminology
            1. Camel Case
            2. Pascal Case
            3. Underscore Prefix
        2. Summary Table
            1. _lowerCamelCase Rule
                1. Private Field
            2. UpperCamelCase Rule
                1. Protected Field
                2. Internal Field
                3. Constant
                4. Property
                5. Method
                6. Class
            3. IUpperCamelCase Rule
                1. Interface
            4. lowerCamelCase Rule
                1. Local Varible
                2. Parameter

## 2. DateTime

    1. Initialization Examples
        1. Invoke Constructor
        2. Invoke Implicit DateTime
        3. Assigning a Computed Value
        4. Parsing a String DateTime
    2. Formatting DateTime as Strings
        1. Default Format Date
        2. Specific Culture Date
        3. Get All Specific Culture
        4. DateTime Custom Format String
        5. Specify Format String & Specific Culture
        6. Format DateTime Using ISO8601 Standard Web Services
    3. Parsing String as DateTime
        1. Parse Converting String to Date & Time
        2. TryParse Converting String to Date & Time
        3. ParseExact Converting String to Unknown Format
        4. TryParseExact Converting String to Unknown Format
        5. Convert ISO8601 to Date & Time
    4. DateTime Resolution
    5. Culture & Calendars
        1. CultureInfo
            1. Set Culture
            2. Various Cultures
            3. CultureInfo Sorting
            4. CultureInfo Decimal Separators
            5. CultureInfo Thousands Separators
            6. CultureInfo Currency
            7. First Day of Week
            8. First Week
            9. Day Names
            10. Month Names
            11. Abbreviated Month Names
            12. CultureInfo DateTime Formats
        2. List Cultures
        3. Calendars per Language
        4. Represent Dates
            1. Julian Calendar
            2. Chinese Lunisolar Calendar
            3. Hebrew Calendar
            4. Hijri Calendar
            5. Japanese Lunisolar Calendar
            6. Korean Calendar
            7. Korean Lunisolar Calendar
            8. Persian Calendar
            9. Thai Buddhist Calendar
            10. UmAlQura Calendar
            11. Japanese Calendar
    6. DateTime TimeZone
        1. DateTimeKind Local
        2. DateTimeKind UTC
        3. DateTimeKind Unspecified
        4. ToLocalTime
        5. ToUniversalTime
        6. ConvertToUTC
        7. TimeZone List
    7. DateTime Properties
        1. DateTime.Date
        2. DateTime.DayOfYear
        3. DateTime.TimeOfDay
        4. DateTime.Hour
        5. DateTime.Minute
        6. DateTime.Second
        7. DateTime.Millisecond
        8. DateTime.DayOfWeek
        9. DateTime.Kind
        10. Add DateTime
        11. Subtract DateTime
    8. Unix Time
    9. Time Interval
        1. TimeSpan
        2. Elapsed Time
    10. Format Time
        1. Specifier "d" for Short Date Pattern
        2. Specifier "D" for Long Date Pattern
        3. Specifier "F" for Full Date and Time Pattern
        4. Specifier "M" for Month and Day Pattern
        5. Specifier "o" for Round-Trip Date and Time Pattern
        6. Specifier "R" for RFC1123 Date and Time Pattern
        7. Specifier "t" for Short Time Pattern
        8. Specifier "T" for Long Time Pattern
        9. Specifier "Y" for Year and Month Pattern
        10. Customized Date and Time Format Patterns
    11. Leap Year

## 3. Math

    1. Fields
        1. E
        2. PI
        3. Tau
    2. Methods
        1. Basic Math Methods
            1. Abs
                1. Abs Decimal
                2. Abs Double
                3. Abs Int16
                4. Abs Int32
                5. Abs Int64
                6. Abs SByte
            2. BigMul
            3. BitDecrement
            4. BitIncrement
            5. Ceiling
            6. Clamp
            7. CopySign
            8. DivRem
            9. Floor
            10. Fused Multiply-Add
            11. IEEERemainder
            12. Max
                1. Byte
                2. Short
                3. Int
                4. Long
                5. Float
                6. Double
                7. Decimal
                8. SByte
                9. UShort
                10. UInt
                11. ULong
            13. MaxMagnitude
            14. Min
                1. Byte
                2. Short
                3. Int
                4. Long
                5. Float
                6. Double
                7. Decimal
                8. SByte
                9. UShort
                10. UInt
                11. ULong
            15. MinMagnitude
            16. Round
                1. Decimal
                2. Double
                2. Midpoint Rounding
                    1. AwayFromZero
                    2. ToEven
                    3. ToNegativeInfinity
                    4. ToPositiveInfinity
                    5. ToZero
            17. ScaleB
            18. Sign
                1. Byte
                2. Int16
                3. Int32
                4. Int64
                5. Single
                6. Double
                7. Decimal
                8. SByte
            19. Truncate
                1. Double
                2. Decimal
        2. Log & Logarithmic Methods
            1. Exp
            2. Log
                1. Return Log
                2. Log Specified Base
                3. Log10
                4. Log2
                5. IlogB
            3. Sqrt
                1. Square Root of Given Number
                2. Square Root of Area
            4. Cbrt
            5. Pow
        3. Trigonometric Methods
            1. Sin
            2. Cos
            3. Tan
            4. Asin
            5. Acos
            6. Atan
            7. Atan2
            8. Trigonometric Examples
                1. Trapezoid Example
        4. Hyperbolic Methods
            1. Sinh
            2. Cosh
            3. SinhCosh
            4. Tanh
            5. Asinh
            6. Acosh
            7. Atanh
            

## 4. Methods

    1. Array Methods
        1. AsReadOnly
        2. BinarySearch
            1. BinarySearch Next
        3. Clear
            1. One Dimension Clear
            2. Two Dimensions Clear
            3. Three Dimensions Clear
        4. Clone
        5. ConstrainedCopy
        6. ConvertAll
            1. ConvertAll String to Int
            2. ConvertAll Int to String
        7. Copy
        8. CopyTo
        9. CreateInstance
            1. CreateInstance Simple Array
            2. CreateInstance Multi Dimension
            3. CreateInstance Two Dimension Array of String
            4. Bound of Multi Dimensional Array
            5. CreateInstance Multi Dimension Array of Object
        10. Empty
        11. Exist
            1. Planets Example
            2. Names Example
                1. Using StatsWith
                2. Using Lambda
        12. Fill
        13. Find
            1. Names Example
                1. Find Using Var Comparison
                2. Find Using StartsWith
                3. Find Using Lenght
            2. Points Example
        14. FindAll
            1. Names Example
                1. FindAll Using Var Comparison
                2. FindAll Using StartsWith
                3. FindAll Using Lenght
            2. Random List Example
            3. Dino Example
        15. FindIndex
        16. FindLast
        17. ForEach
        18. GetEnumerator
            1. Int Example
            2. String Example
        19. GetLength
        20. GetLongLength
        21. GetLowerBound
            1. Int Example
            2. Multi Dimension Example
            3. Lower & Upper Bound
        22. GetUpperBound
            1. Int Example
            2. Multi Dimension Example
        23. GetValue
            1. Int32 Example
            2. Int64 Example
            3. Multi Dimension Example
        24. IndexOf
            1. IndexOf Int Array
            2. LastIndexOf Int Array
    2. -

## 5. Regular Expressions

    1. Mobile Number Validity
    2. Email Verification
    3. Regex Syntax
        1. Quantifiers
        2. Anchor
        3. Special Characters
        4. Character Classes
        5. Group Expressions
    4. Pattern
    5. Groups
    6. Replacing
        1. International Phone Number
        2. Replacing Spacing
        3. Replacing for Visualization
        4. Replacing Words
        5. Replacing Duplicates
    7. Capture
    8. Parsing
        1. Parse
        2. TryParse
        3. TryParse no if
        4. New Out Syntax
        5. Converting
        6. TryParse a DateTime
        7. Benchmarks Invalid Strings
        8. Benchmarks IntParse Fast
    9. Matching
        1. Default Regex Matching
        2. Simple Use
        3. Greedy Matching
        4. Static Regex Margin
        5. Match Method
            1. Words Containing Specific Letter
            2. Match Starting
        6. Match Numbers
        7. IsMatch Method
    10. Regex Options
        1. Ignore Case
        2. Ignore WhiteSpace
        3. Multiple Matches Ignore Case Option
        4. Multi Line Option
        5. Singleline
        6. Implicit Captures
        7. Explicit Captures
        8. Compiled
        9. RightToLeft
        10. ECMAScript

## 6. Exceptions

    1. ArgumentNull Exception
    2. IndexOutOfRange Exception
    3. Rank Exception
    4. ArrayTypeMismatch Exception
    5. ArgumentOutOfRange Exception


## 7. Linq Functions

    1. Basic Linq
    2. Find Positive
    3. Find Number after specifics calculations
    4. Frequency
    5. Linq Syntax
        1. String Collection
        2. Sequence Collection
        3. Anonymous Method
        4. Lambda Expressions
    6. Operators List
        1. Filtering Operator
            1. Where
            1. OfType
        2. Sorting Operator
            1. OrderBy
            2. OrderByDescending
            3. ThenBy
            4. ThenByDescending
        3. Grouping Operators
            1. GroupBy (Query Syntax)
            2. GroupBy (Method Syntax)
            3. ToLookUp (Method Syntax Only)
        4. Joining Operators
            1. Join
            2. GroupJoin (Method)
            3. GroupJoin (Query)
            4. GroupJoin Complexe (Method)
            5. GroupJoin Complexe (Query)
            6. GroupJoin User Defined
        5. Projection Operators
            1. Select Operator
            2. Select Operator (Query Syntaxe)
            3. Select Operator (Method Syntaxe)
            4. Select Many Operator
            5. Select vs Select Many
            6. Zip Operator
        6. Quantifier Operators
            1. All
            2. Any
            3. Contains
        7. Aggregation Operators
            1. Aggregate
            2. LongCount
            3. Average
            4. Count
            5. Max
            6. Min
            7. Sum
        8. Element Operators
            1. ElementAt
            2. ElementAtOrDefault
            3. First
            4. FirstOrDefault
            5. Last
            6. LastOrDefault
            7. Single
            8. SingleOrDefault
        9. Equality Operators
            1. SequenceEqual
        10. Concatenation Operators
            1. Concat
        11. Generation Operators
            1. DefaultIfEmpty
            2. Empty
            3. Range
            4. Repeat
        12. Set Operators
            1. Distinct
            2. Except
            3. Intersect
            4. Union
        13. Partitioning Operators
            1. Skip
            2. SkipWhile
        14. Conversion Operators
            1. AsEnumerable
            2. AsQueryable
            3. Cast
            4. ToArray
            5. ToDictionary
            6. ToList
    7. Subjects Examples
        1. Faro Shuffle


## 8. Data Structures

    1. Dictionary
        1. Create A Dictionary
        2. Print A Dictionary Using Loop
        3. Add In Dictionary
        4. Access Element In Dictionary
            1. If Input Element Exist
            2. If Input Element Does Not Exist
        5. Update An Element In Dictionary
        6. Remove An Element In Dictionary
        7. Clear Dictionary