using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class StudentModel
    {
        [Key]
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string student_address { get; set; }
        public string password { get; set; }
        public string roll { get; set; }

    }

}
