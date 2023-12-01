using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Modal
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Email_ID { get; set; }
        public int Mobile_ID { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public int Address_ID { get; set; }
        public int PostalCode { get; set; }
        public int Role_ID { get; set; }
        public int Location_ID{ get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
