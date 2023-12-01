using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOMER_MODAL.Modal
{
    public class ModalClass
    {
        [Key]
        public int CUSTOMER_ID { get; set; }
        public string? CUSTOMER_NAME { get; set; }
        public int CUSTOMER_AGE { get; set;}
        public string? CUSTOMER_ADDRESS { get; set; }
    }
}
