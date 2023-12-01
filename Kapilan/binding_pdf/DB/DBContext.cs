using binding_pdf.Modal;
using Microsoft.EntityFrameworkCore;

namespace binding_pdf.DB
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        public DbSet<ViewModal> Excel_Export { get; set; }
    }
}
