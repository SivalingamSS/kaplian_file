using System.ComponentModel.DataAnnotations;

namespace Encrypt_Data.RegisterModel
{
    public class Register
    {
        [Key]
        [Required()]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(10)]
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Phone_Number { get; set; }
    }
}

