using Microsoft.EntityFrameworkCore;
using Model.model;

namespace Model
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> customer_db { get; set; }
        public DbSet<Seller> SELLER_db { get; set; }
    }
}