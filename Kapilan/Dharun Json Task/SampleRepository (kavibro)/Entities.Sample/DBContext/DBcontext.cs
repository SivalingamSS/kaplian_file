using Microsoft.EntityFrameworkCore;

namespace Entities.Sample.DBContext
{
    public class DBcontext:DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options):base (options) 
        { 

        }
    }
}
