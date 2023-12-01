using System.ComponentModel.DataAnnotations;

namespace Overlap_Interval.Modal
{
    public class TableModal
    {
        [Key]
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class Modalclass
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}

