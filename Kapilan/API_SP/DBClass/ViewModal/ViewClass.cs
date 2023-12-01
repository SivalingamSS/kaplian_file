using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClass.ViewModal
{
    public class ViewClass
    {
        [Key]
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public int staff_age { get; set; }
        public string staff_city { get; set; }
        public int staff_mob_number { get; set; }
        public int work_id { get; set; }
        public string email_id { get; set; }
        public string address { get; set; }
    }
}
