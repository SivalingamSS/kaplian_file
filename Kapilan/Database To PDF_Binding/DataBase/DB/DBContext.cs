using DataBase.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DB
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        public DbSet<ViewModel> Excel_Export { get; set; }
    }
}
