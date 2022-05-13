using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class SumOperator
    {
        public static void LINQSumFunction(){
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            var StudentClasse = Student.GetAllStudents();
            var sumOfAge = StudentClasse.Sum(s => s.Age);

            var total = intList.Sum();
            
            Console.WriteLine("Sum: {0}", total);
            var sumOfEvenElements = intList.Sum(i => {
                if(i%2 == 0)
                    return i;
                return 0;
            });
            Console.WriteLine("Sum of Even Element: {0}", sumOfEvenElements );
            Console.WriteLine("Sum of all student's age: {0}", sumOfAge);

            var totalAdults = StudentClasse.Sum(s => {
                if(s.Age >= 18)
                    return 1;
                else
                    return 0;
            });
            var totalKidsTeens = StudentClasse.Sum(s => {
                if(s.Age < 18)
                    return 1;
                else
                    return 0;
            });
            Console.WriteLine("Total Adult Students: {0}\nTotal Kids/Teens Students: {1}", totalAdults, totalKidsTeens);

            
        }
        
    }

}