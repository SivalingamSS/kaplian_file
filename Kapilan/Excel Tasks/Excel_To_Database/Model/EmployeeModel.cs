using System.ComponentModel.DataAnnotations;

namespace Operation1.Model
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? AddressLine { get; set; }
        public string? City { get; set; }
        public int? PhoneNo { get; set; }
        public int? Salary { get; set; }
    }
    public class Excel
    {
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
    }
    public class ExcelDb
    {
        public int ContractDetailid { get; set;}
        public int ServiceAccount { get; set;}
        public int IsSwitchSupport { get; set;}
        public int CreatedBy { get; set;}
    }
}

