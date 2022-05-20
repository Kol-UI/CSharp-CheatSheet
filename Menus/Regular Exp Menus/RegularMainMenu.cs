using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class RegularMainMenu
    {
        public static void RegularMainMethod(){
            Program.Space();
            Console.WriteLine("Which Regular Exp Chapter ?\n1) Mobile Number Validity\n2) Email Verification\n3) Regex Syntax\n4) Patern\n5) Groups\n6) Replacing");
            var regInput = Console.ReadLine();
            int valueInput = int.Parse(regInput);
            switch (valueInput)
            {
                case 1: // Mobile Number Validity
                    MobileNumberValidity.MobileNumberMethod();
                    break;
                case 2: // Email Verification
                    EmailVerification.EmailVerificationMethod();
                    break;
                case 3: // Regex Syntax
                    RegexSyntax.RegexSyntaxMethod();
                    break;
                case 4: // Patern
                    RegexPatern.RegexPaternMethod();
                    break;
                case 5: // Groups
                    RegexGroups.RegexGroupsMethod();
                    break;
                case 6: // Replacing
                    RegexReplacing.RegexReplacingMethod();
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
                    break;
            }
        }
        
    }

}