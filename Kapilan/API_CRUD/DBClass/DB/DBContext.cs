using DBClass.Modal;
using Microsoft.EntityFrameworkCore;

namespace DBClass.DB
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        public DbSet<ModalClass> API_DB { get; set; }
        public DbSet<MappingClass> API_DB_FK { get; set; }
    }
}
