using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.VIEW_MODEL
{
    public class view
    {
        [Key]
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public int CUSTOMER_AGE { get; set; }
        public string CUSTOMER_ADDRESS { get; set; }
        public int SELLER_ID { get; set; }
        public string EMAIL_ID { get; set; }
        public string GENDER { get; set; }
    }
}
        