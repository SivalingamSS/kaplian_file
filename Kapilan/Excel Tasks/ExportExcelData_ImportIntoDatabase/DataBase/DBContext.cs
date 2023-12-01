using ExportExcelData_ImportIntoDatabase.Modal;
using Microsoft.EntityFrameworkCore;

namespace ExportExcelData_ImportIntoDatabase.DataBase
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        public DbSet<Excel> Excel_Data { get; set; }
    }
}
