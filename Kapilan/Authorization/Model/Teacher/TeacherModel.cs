using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Teacher
{
    public class TeacherModel
    {
        [Key]
        public int? teacher_id { get; set; }
        public string? teacher_name { get; set; }
        public string? teacher_address { get; set; }
        public string? password { get; set; }
        public string roll { get; set; }
    }
}
