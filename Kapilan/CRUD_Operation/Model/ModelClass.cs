using CreateApi.Controllers;
using System.ComponentModel.DataAnnotations;

namespace CreateApi.Model
{
    public class ModelClass
    {
       [Key]
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
    }
    public class ModelClass1
    {
      
        public int CustomerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
    }
}