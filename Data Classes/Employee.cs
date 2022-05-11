using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", DepartmentId = 10},
                new Employee { ID = 2, Name = "Priyanka", DepartmentId =20},
                new Employee { ID = 3, Name = "Anurag", DepartmentId = 30},
                new Employee { ID = 4, Name = "Pranaya", DepartmentId = 30},
                new Employee { ID = 5, Name = "Hina", DepartmentId = 20},
                new Employee { ID = 6, Name = "Sambit", DepartmentId = 10},
                new Employee { ID = 7, Name = "Happy", DepartmentId = 10},
                new Employee { ID = 8, Name = "Tarun", DepartmentId = 0},
                new Employee { ID = 9, Name = "Santosh", DepartmentId = 10},
                new Employee { ID = 10, Name = "Raja", DepartmentId = 20},
                new Employee { ID = 11, Name = "Ramesh", DepartmentId = 30}
            };
        }
        
    }

}