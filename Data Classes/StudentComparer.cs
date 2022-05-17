using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class StudentComparer: IEqualityComparer<Student>
    {
        
        public bool Equals(Student x, Student y)
        {
            return x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower();
        }
        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode() ^ obj.StudentName.GetHashCode();
        }
        
    }

}