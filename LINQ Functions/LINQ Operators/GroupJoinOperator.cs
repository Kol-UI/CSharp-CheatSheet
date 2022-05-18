using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class GroupJoinOperator
    {
        public static void GroupJoinOperatorMethod(IList<Student> studentList)
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

        public static void GroupJoinQuerySyntaxeMethod(IList<Student> studentList){
            
            IList<Standard> standardList = new List<Standard>() { 
                    new Standard(){ StandardID = 1, StandardName="-- Standard 1 --"},
                    new Standard(){ StandardID = 2, StandardName="-- Standard 2 --"},
                    new Standard(){ StandardID = 3, StandardName="-- Standard 3 --"}
                };
                
            var groupJoin = from std in standardList 
                            join s in studentList 
                            on std.StandardID equals s.StandardID
                            into studentGroup
                            select new { 
                                Students = studentGroup , 
                                StandardName = std.StandardName 
                            };

            foreach (var item in groupJoin)
            { 
                Console.WriteLine(item.StandardName );
                
                foreach(var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
        }
            
        public static void GroupJoinMoreComplexeMethod(){
            var GroupJoinMS = Department.GetAllDepartments().
                GroupJoin(
                    Employee.GetAllEmployees(),
                    dept => dept.ID,
                    emp => emp.DepartmentId,
                    (dept, emp) => new {dept, emp}
                );
            // Printing the Result set
            // Outer Foreach is for all department
            foreach(var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                // Inner Foreach loop for each employee of a department
                foreach(var employee in item.emp)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
            Console.ReadLine();
        }

        public static void GroupJoinMoreComplexeMethodQuery(){
            var GroupJoinQS = from dept in Department.GetAllDepartments()
                            join emp in Employee.GetAllEmployees()
                            on dept.ID equals emp.DepartmentId
                            into EmployeeGroups
                            select new { dept, EmployeeGroups };
            
            // Outer Foreach is for all department
            foreach(var item in GroupJoinQS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                // Inner Foreach loop for each employee of a department
                foreach(var employee in item.EmployeeGroups)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
            Console.ReadLine();
        }

        public static void GroupJoinMoreComplexeMethodUserDefined(){
            // Using Method Syntax
            var GroupJoinMS = Department.GetAllDepartments().
                GroupJoin(
                    Employee.GetAllEmployees(),
                    dept => dept.ID,
                    emp => emp.DepartmentId,
                    // User Defined names in Result Selector
                    (dept, emp) => new{
                        Departments = dept,
                        Employees = emp
                    }
                );
            // Using Query Syntax
            var GroupJoinQS = from dept in Department.GetAllDepartments()
                            join emp in Employee.GetAllEmployees()
                            on dept.ID equals emp.DepartmentId
                            into EmployeeGroups
                            // User Defined names in Result Selector
                            select new {
                                Departments = dept,
                                Employees = EmployeeGroups
                            };
            
            foreach(var item in GroupJoinQS)
            {
                Console.WriteLine("Department :" + item.Departments.Name);
                foreach(var employee in item.Employees)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
            Console.ReadLine();
        }

    }

    public class Standard{

        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}