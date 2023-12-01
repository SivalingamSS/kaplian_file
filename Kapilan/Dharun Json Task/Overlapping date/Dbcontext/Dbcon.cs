using Microsoft.EntityFrameworkCore;
using Overlapping_date.Model;

namespace Overlapping_date.Dbcontext
{
    public class Dbcon
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions options) : base(options) { }

            public DbSet<DateRange> DateRanges { get; set; }
        }
    }
}
