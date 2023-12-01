using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Modal
{
    public class User_Mobile
    {
        [Key]
        public int Id { get; set; }
        public string MobileNumber { get; set; }
    }
}
