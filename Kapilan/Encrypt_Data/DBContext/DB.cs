using Encrypt_Data.RegisterModel;
using Encrypt_Data.TableReg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Encrypt_Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions options) : base(options) { }
        public DbSet<Register> user_login { get; set; }
    }
}
