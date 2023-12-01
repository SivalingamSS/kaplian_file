using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertModelToString
{
    class Object1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
    class Object2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
  class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
    }
    class Department
    {
        public List<Object2> EEE;
    }
    class Emp
    {
        public List<Employee> Civil;
    }
    class Object23
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
    public class MainClass
    {
        public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public string City { get; set; }
    public string School { get; set; }
    public string Location { get; set; }
}
}

