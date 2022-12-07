using System;
namespace CSharp_CheatSheet.CBasics
{
	public class NamingConventions
	{
		public static void NamingConventionsMain()
		{
			Program.Title("Naming Conventions");
            TerminologyFunc();
            SummaryTable();
        }

        private static void TerminologyFunc()
        {
            Program.Title("Terminology");
            CamelCaseFunc();
            PascalCaseFunc();
            UnderscorePrefixFunc();
        }

        private static void CamelCaseFunc()
		{
            Program.Title("Camel Case");
            Console.WriteLine("In this standard, the first letter of the word always in small letter and after that each word starts with a capital letter.");
			Console.WriteLine("Example : 'camelCase'.");
        }

        private static void PascalCaseFunc()
        {
            Program.Title("Pascal Case");
            Console.WriteLine("In this the first letter of every word is in capital letter.");
            Console.WriteLine("Example : 'PascalCase'.");
        }

        private static void UnderscorePrefixFunc()
        {
            Program.Title("Underscore Prefix");
            Console.WriteLine("For underscore ( __ ), the word after _ use camelCase terminology.");
            Console.WriteLine("Example : '_underScore'.");
        }

        private static void SummaryTable()
        {
            Program.Title("Summary Table");
            String[] Terms = { "Private Field", "Protected Field", "Internal Field", "Constant", "Property", "Method", "Class", "Interface", "Local Variable", "Parameter" };

            String[] UnderscoreLowerCamelCase = { Terms[0] }; 
            String[] UpperCamelCase = { Terms[1], Terms[2], Terms[3], Terms[4], Terms[5], Terms[6] };
            String[] IUpperCamelCase = { Terms[7] };
            String[] ArrayLowerCamelCase = { Terms[8], Terms[9] };

            UnderscoreLowerCamelCaseTermsFunc(UnderscoreLowerCamelCase);
            UnderscoreUpperCamelCaseTermsFunc(UpperCamelCase);
            IUpperCamelCaseTermsFunc(IUpperCamelCase);
            LowerCamelCaseTermsFunc(ArrayLowerCamelCase);
        }

        private static void UnderscoreLowerCamelCaseTermsFunc(String[] Terms)
        {
            Console.WriteLine("These terms are associated with the '_lowerCamelCase' rule :");
            Program.PrintArrayOneLine(Terms);
            Program.Space();
        }

        private static void UnderscoreUpperCamelCaseTermsFunc(String[] Terms)
        {
            Console.WriteLine("These terms are associated with the 'UpperCamelCase' rule :");
            Program.PrintArrayOneLine(Terms);
            Program.Space();
        }

        private static void IUpperCamelCaseTermsFunc(String[] Terms)
        {
            Console.WriteLine("These terms are associated with the 'IUpperCamelCase' rule :");
            Program.PrintArrayOneLine(Terms);
            Program.Space();
        }

        private static void LowerCamelCaseTermsFunc(String[] Terms)
        {
            Console.WriteLine("These terms are associated with the 'lowerCamelCase' rule :");
            Program.PrintArrayOneLine(Terms);
            Program.Space();
        }
    }
}

