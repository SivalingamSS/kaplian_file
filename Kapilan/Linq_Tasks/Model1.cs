using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tasks
{
    public class Student
    {
        public int Id { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    } 
    public class StudentDt
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }  
    public class Employee1
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
    }
    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

}
