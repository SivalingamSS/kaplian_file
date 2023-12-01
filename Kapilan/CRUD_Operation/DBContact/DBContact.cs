using CreateApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CreateApi.DBcontact
{
    public class DBContacts : DbContext
    {
        public DBContacts(DbContextOptions options) : base(options){ }
        public DbSet<ModelClass> Persons { get; set; }
    }
}
 