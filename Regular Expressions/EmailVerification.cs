using System;
using System.Text.RegularExpressions;

namespace CSharp_CheatSheet
{
    public class EmailVerification
    {
        public static void EmailVerificationMethod(){
            Console.WriteLine("--- Email Verification Using Regex ---");
            // Input strings for Match valid E-mail address
            string[] str = {"test@gmail.com", "test.test@test.com", "@gmail.com", "testgmail.com"};
            
            foreach(string s in str)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s, isValidEmail(s) ? "is" : "is not");
            }
            Console.WriteLine("What is your email adress ?");
            string UserInputEmail = Console.ReadLine();
            Console.WriteLine("{0} {1} a valid email adress.", UserInputEmail, isValidEmail(UserInputEmail) ? "is" : "is not");
        }

        public static bool isValidEmail(string inputEmail){
            // This Pattern is use to verify the email
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                            
            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        
    }

}