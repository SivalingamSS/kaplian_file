﻿using System.ComponentModel.DataAnnotations;

namespace DBClass.Modal
{
    public class ModalClass
    {
        [Key]
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public int staff_age { get; set; }
        public string staff_city { get; set; }
        public int staff_mob_number { get; set; }

    }
    public class MappingClass
    {
        [Key]
        public int work_id { get; set; }
        public string email_id { get; set; }
        public string address { get; set; }
        public int staff_id { get; set; }
    }
}
