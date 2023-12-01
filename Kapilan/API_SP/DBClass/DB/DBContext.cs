using DBClass.TableModal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClass.DB
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base (options){ }
        public DbSet <TableClass> API_DB { get; set; }
        public DbSet<MappingClass> API_DB_FK { get; set; }
    }
}
