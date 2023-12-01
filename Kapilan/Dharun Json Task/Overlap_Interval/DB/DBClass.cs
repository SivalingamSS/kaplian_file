using Microsoft.EntityFrameworkCore;
using Overlap_Interval.Modal;

namespace Overlap_Interval.DB
{
    public class DBClass : DbContext
    {
        public DBClass(DbContextOptions options) : base(options) { }
        public DbSet<TableModal> Overlapinterval { get; set; }
    }
}

