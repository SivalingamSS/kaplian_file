using Microsoft.EntityFrameworkCore;
using MODEL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Db_context
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions options) : base(options) { }
        public DbSet<Customer> customer_db { get; set; }
        public DbSet<Seller> SELLER_db { get; set; }
    }
}

