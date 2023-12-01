using System.ComponentModel.DataAnnotations;

namespace DOT
{
    public class View
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