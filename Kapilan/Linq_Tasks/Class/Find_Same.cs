using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks.Class
{
    class StudentComparer : IEqualityComparer<StudentDt>
    {
        public bool Equals(StudentDt x, StudentDt y)
        {
            if (x.Id == y.Id && x.StudentName == y.StudentName)
                return true;
            return false;
        }

        public int GetHashCode(StudentDt obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
