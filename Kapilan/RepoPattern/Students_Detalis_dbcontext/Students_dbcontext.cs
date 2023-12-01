using Microsoft.EntityFrameworkCore;
using Students_Detalis_dbcontext.Students_Detalis_ViewModel;

namespace Students_Detalis_dbcontext
{
    public class Students_dbcontext:DbContext
    {
        public Students_dbcontext(DbContextOptions options) : base(options) { }
        public DbSet<Students_model> TBL_Students_Details { get; set; }
    }
}