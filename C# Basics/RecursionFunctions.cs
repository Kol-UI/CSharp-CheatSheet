using System;
using System.Text;
using CSharp_CheatSheet.DataClasses;

namespace CSharp_CheatSheet.CBasics
{
    public class RecursionFunctions
    {
        public static void RecursionMain()
        {
            Program.Space();
            Console.WriteLine("Which Recursion ? \n1) Print Natural Numbers  2) Print Reversed Natural Numbers  3) Sum of First Natural Numbers " +
                " 4) Individual Digits  5) Get Number of Digits  6) Even and Odd\n 7) Check if Prime Number  8) Fibonacci Numbers " +
                " 9) Booleans Compositions  10) Palindrome Recursion  11) Find Factorial  12) Permutations in Array\n" +
                "13) Recursion of Two Numbers  14) Convert Decimal Number to Binary  15) Reverse a String  16) Calcul Power Of Number");
            var RecursionInput = Console.ReadLine();
            int valueRecursionInput = int.Parse(RecursionInput);
            switch (valueRecursionInput)
            {
                case 1:
                    PrintNaturalNumbers();
                    break;
                case 2:
                    PrintReversedNaturalNumbers();
                    break;
                case 3:
                    SumOfFirstNaturalNumbers();
                    break;
                case 4:
                    IndividualDigits();
                    break;
                case 5:
                    GetNumberOfDigits();
                    break;
                case 6:
                    GetEvenAndOdd();
                    break;
                case 7:
                    CheckifPrimeNumber();
                    break;
                case 8:
                    FibonacciNumbers();
                    break;
                case 9:
                    Console.WriteLine("--- Booleans Compositions ---");
                    CompositionBooleans(string.Empty, 3);
                    break;
                case 10:
                    MainPalindrome();
                    break;
                case 11:
                    FindFactorial();
                    break;
                case 12:
                    PermutInArray();
                    break;
                case 13:
                    RecursionOfTwoNumbers();
                    break;
                case 14:
                    ConvertDecimalNumberToBinary();
                    break;
                case 15:
                    ReverseAString();
                    break;
                case 16:
                    CalculPowerOfNumber();
                    break;
                default:
                    Console.WriteLine("--- Warning: not acceptable value ! ---\n");
                    break;
            }
            Program.Space();
        }

        private static void PrintNaturalNumbers(){
            Console.WriteLine("--- Print Natural Numbers ---");
            Console.WriteLine("How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());	
            PrintNatural(1, ctr);
            Program.Space();
        }

        private static int PrintNatural(int number, int ctr)
        {
            if (ctr < 1)
            {
                return number;
            }
            ctr--;
            Console.Write(" {0} ", number);
            return PrintNatural(number + 1, ctr);
        }

        private static int ReversedPrintNatural(int ctr, int stval)
        {
            if (ctr < 1)
            {
                return stval;
            }

            Console.Write(" {0} ", ctr);
            ctr--;
            return ReversedPrintNatural(ctr, stval);
        }

        private static void PrintReversedNaturalNumbers()
        {
            Console.WriteLine("--- Print Reversed Natural Numbers ---");
            Console.WriteLine("How many numbers to print : ");
            int ctr = Convert.ToInt32(Console.ReadLine());	
            ReversedPrintNatural(ctr, 1);
            Program.Space();
        }

        private static void SumOfFirstNaturalNumbers()
        {
            Console.WriteLine("--- Sum of first natural numbers ---");
            Console.WriteLine("How many numbers to sum : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The sum of first {0} natural numbers is : {1}\n\n", n, SumOfTen(1, n));
        }

        private static int SumOfTen(int min, int max)
        {
            return CalcuSum(min, max);
        }

        private static int CalcuSum(int min, int val)
        {
            if (val == min)
                return val;
            return val + CalcuSum(min, val - 1);
        }

        private static void IndividualDigits()
        {
            Console.WriteLine("--- Display the individual digits of a given number ---");
            Console.WriteLine("Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The digits in the number {0} are : ", num);
            SeparateDigits(num);
            Program.Space();
        }

        private static void SeparateDigits(int n)
        {
            if (n < 10)
            {
                Console.Write("{0} ", n);
                return;
            }
            SeparateDigits(n / 10);
            Console.Write(" {0} ", n % 10);
        }

        private static void GetNumberOfDigits()
        {
            Console.WriteLine("--- Get the number of digits in a number ---");
            Console.WriteLine("Input any number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number {0} contains {1} digits.", num, GetDigits(num, 0));
            Program.Space();
        }

        private static int GetDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            return GetDigits(n1 / 10, ++nodigits);
        }

        private static void GetEvenAndOdd()
        {
            int n;
            Console.WriteLine("--- Print even or odd numbers in a given range ---");

            Console.WriteLine("Input the range to print starting from 1 : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All even numbers from 1 to {0} are : ", n);
            EvenAndOdd(2, n);
            Program.Space();

            Console.WriteLine("All odd numbers from 1 to {0} are : ", n);
            EvenAndOdd(1, n);
            Program.Space();

            return;
        }

        private static void EvenAndOdd(int stVal, int n)
        {
            if (stVal > n)
                return;
            Console.Write("{0}  ", stVal);
            EvenAndOdd(stVal + 2, n);
        }

        private static int CheckifPrimeNumber()
        {
            int n1, primeNo;

            Console.WriteLine("--- Check if number is a prime number or not ---");

            Console.WriteLine("Input any positive number :");
            n1 = Convert.ToInt32(Console.ReadLine());

            primeNo = CheckForPrime(n1, n1 / 2);

            if (primeNo == 1)
                Console.Write(" The number {0} is a prime number. \n\n", n1);
            else
                Console.WriteLine(" The number {0} is not a prime number. \n\n", n1);
            return 0;
        }

        private static int CheckForPrime(int n1, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n1 % i == 0)
                    return 0;
                else
                    return CheckForPrime(n1, i - 1);
            }
        }

        private static void FibonacciNumbers()
        {
            int n;
            Console.WriteLine("--- Fibonacci Numbers ---");

            Console.WriteLine("Input any positive number :");
            n = Convert.ToInt32(Console.ReadLine());
            Program.Space();
            
            Console.WriteLine("--- No Recursive High Performance ---");
            Fib1(n);
            Console.WriteLine("Result: {0}", n);

            Program.Space();
            Console.WriteLine("--- Recursive Bad Performance ---");
            Fib2(n);
            Console.WriteLine("Result: {0}", n);

            Program.Space();
            Console.WriteLine("--- Find Fibonacci ---");
            Fib3();
            Program.Space();
        }

        private static long Fib1(int n)
        {
            if (n < 2)
                return n;
            long[] f = new long[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }
            return f[n];
        }

        private static long Fib2(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return Fib2(n - 2) + Fib2(n - 1);
        }

        private static int FindFibonacci(int n)
        {
            int p = 0;
            int q = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = p;
                p = q;
                q = temp + q;
            }
            return p;
        }

        private static void Fib3()
        {
            Console.WriteLine("Input number of terms for the Fibonacci series : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonacci series of {0} terms is : ", n1);
            for (int i = 0; i < n1; i++)
            {
                Console.Write("{0} ", FindFibonacci(i));
            }
        }

        public static void CompositionBooleans(string result, int counter)
        {
            if (counter == 0)
                return;

            bool[] booleans = new bool[2] { true, false };

            for (int j = 0; j < 2; j++)
            {
                StringBuilder stringBuilder = new StringBuilder(result);
                stringBuilder.Append(string.Format("{0} ", booleans[j].ToString())).ToString();

                if (counter == 1)
                    Console.WriteLine(stringBuilder.ToString());

                CompositionBooleans(stringBuilder.ToString(), counter - 1);
            }
        }

        private static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (text[0] != text[text.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(text.Substring(1, text.Length - 2));
                }
            }
        }

        private static void MainPalindrome()
        {
            Console.WriteLine("--- Palindrome Recursion ---");
            string str1;
            bool tf;

            Console.WriteLine("Input a string : ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine("The string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome.");
            }
            Program.Space();
        }

        private static void FindFactorial()
        {
            Console.WriteLine("--- Find the factorial of a given number ---");

            Console.WriteLine("Input any positive number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            long fact = FactorialCalculInt(n1);
            Console.WriteLine("The factorial of {0} is : {1} ", n1, fact);
            Program.Space();

            Console.WriteLine("--- Find the factorial of a given string ---");
            string input = Console.ReadLine();
            int valueString = 0;
            foreach (char c in input)
            {
                valueString += 1;
            }
            long result = FactorialCalculString(valueString);
            Console.WriteLine("The factorial of {0} is : {1} ", input, result);
        }

        private static long FactorialCalculInt(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactorialCalculInt(n1 - 1);
        }

        private static long FactorialCalculString(int ValueString)
        {
            if (ValueString == 0)
            {
                return 1;
            }
            return ValueString * FactorialCalculString(ValueString - 1);
        }

        private static void PermutInArray()
        {
            int n, i;
            ClassPermut test = new ClassPermut();
            int[] arr1 = new int[5];

            Console.WriteLine("--- Generate all possible permutations of an array ---");

            Console.WriteLine("Input the number of elements to store in the array [maximum 5 digits] :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Permutations with a combination of {0} digits are :", n);
            test.PrnPermut(arr1, 0, n - 1);
            Program.Space();
        }

        private static void RecursionOfTwoNumbers()
        {
            long num1, num2, hcf, lcm;
            Console.WriteLine("--- Recursion of Two Numbers ---");

            Console.WriteLine("- Input the first number : ");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("- Input the second number : ");
            num2 = Convert.ToInt64(Console.ReadLine());

            hcf = Gcd(num1, num2);
            lcm = (num1 * num2) / hcf;

            Console.WriteLine("--- Greatest Common Divisor of Two Numbers ---");
            Console.WriteLine("The GCD of {0} and {1} = {2} ", num1, num2, hcf);
            Console.WriteLine("--- Least Common Multiple of Two Numbers ---");
            Console.WriteLine("The LCM of {0} and {1} = {2}\n", num1, num2, lcm);
        }

        private static long Gcd(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return Gcd(n2, n1 % n2);
            }
        }

        private static void ConvertDecimalNumberToBinary()
        {
            int num;
            DecimalToBinaryClass ToConvert = new DecimalToBinaryClass();
            Console.WriteLine("--- Convert a decimal number to binary ---");
            Console.WriteLine("Input a decimal number : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary equivalent of {0} is : ", num);
            ToConvert.DecimalToBinary(num);
            Program.Space();
        }

        private static void ReverseAString()
        {
            string str;
            Console.WriteLine("--- Get the reverse of a string ---");
            Console.WriteLine("Input the string : ");
            str = Console.ReadLine();
            str = StringReverse(str);
            Console.WriteLine("The reverse of the string is : ");
            Console.WriteLine(str);
            Program.Space();
        }

        private static string StringReverse(string str)
        {
            if (str.Length > 0)
            {
                return str[^1] + StringReverse(str.Substring(0, str.Length - 1));
            }
            else
            {
                return str;
            }
        }

        private static void CalculPowerOfNumber()
        {
            int bNum, pwr;
            int result;
            Console.WriteLine("--- Calculate power of any number (recursion) ---");

            Console.WriteLine("Input the base value : ");
            bNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the exponent : ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalculPower(bNum, pwr);

            Console.WriteLine("The value of {0} to the power of {1} is : {2}", bNum, pwr, result);
            Program.Space();
        }

        private static int CalculPower(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * CalculPower(x, y - 1);
            }
        }
    }
}
