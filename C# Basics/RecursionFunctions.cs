using System;
namespace CSharp_CheatSheet.CBasics
{
    public class RecursionFunctions
    {
        public static void RecursionMain()
        {
            Program.Space();
            Console.WriteLine("Which Recursion ? \n1) Print Natural Numbers  2) Print Reversed Natural Numbers  3) Sum of First Natural Numbers " +
                " 4) Individual Digits  5) Get Number of Digits  6) Even and Odd\n 7) Check if Prime Number");
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
    }
}
