using System;
namespace CSharp_CheatSheet.DataClasses
{
    public class AdvancedEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
        public int Age { get; set; }
    }
}