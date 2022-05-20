using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class MobileNumberValidity
    {
        public static void MobileNumberMethod(){
            Console.WriteLine("--- Mobile Number Validity Using Regex ---");
            // Input strings to Match valid mobile number
            string[] str = {"9925612824", "8238783138", "02812451830"};
            
            foreach(string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s, isValidMobileNumber(s) ? "is" : "is not");
            }
            Console.WriteLine("What is your phone number ?");
            string UserInputNumber = Console.ReadLine();
            Console.WriteLine("{0} {1} a valid mobile number.", UserInputNumber, isValidMobileNumber(UserInputNumber) ? "is" : "is not");
        }

        public static bool isValidMobileNumber(string inputMobileNumber){
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
            
            // Class Regex Represents an immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx           ^[0 - 9]{ 10}$
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
            Regex re = new Regex(strRegex);
            
            // The IsMatch method is used to validate a string or to ensure that a string conforms to a particular pattern.
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
        
    }

}