using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class GroupJoinOperator
    {
        public static void GroupJoinOperatorFunction(IList<Student> studentList)
        {
            
            
            IList<Standard> standardList = new List<Standard>() { 
                    new Standard(){ StandardID = 1, StandardName="Standard 1"},
                    new Standard(){ StandardID = 2, StandardName="Standard 2"},
                    new Standard(){ StandardID = 3, StandardName="Standard 3"}
                };
            
            var innerJoinResult = from s in studentList // outer sequence
                                join st in standardList //inner sequence 
                                on s.StandardID equals st.StandardID // key selector 
                                select new { // result selector 
                                                StudentName = s.StudentName, 
                                                StandardName = st.StandardName 
                                            };

            foreach (var obj in innerJoinResult)
            {
                
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
            
        }
            
    }

    public class Standard{

        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}