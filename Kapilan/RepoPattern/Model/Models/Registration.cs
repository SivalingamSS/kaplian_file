using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Registration
    {

        public int UserId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPhoneNumber { get; set; }
        public string userPassword { get; set; }
        public int userRoll { get; set; }
    }
}
