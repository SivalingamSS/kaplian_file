using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detalis_dbcontext.Students_Detalis_ViewModel
{
    public class Students_model
    {
        [Key]
        public int Students_ID { get; set; }
        public string? Students_Name { get; set; }
        public int Students_Age { get; set; }
        public string? Students_Address { get; set; }
    }
}
