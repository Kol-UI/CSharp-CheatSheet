using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_CheatSheet
{
    public class StudentComparer: IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;
            
            return false;
        }
        
        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
        
    }

}