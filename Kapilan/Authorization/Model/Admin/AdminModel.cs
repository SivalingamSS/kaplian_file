using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Admin
{
    public class AdminModel
    {
        [Key]
        public int admin_id { get; set; }
        public string admin_name { get; set; }
        public string admin_address { get; set; }
        public string? password { get; set; }
        public string roll { get; set; }
    }
}
