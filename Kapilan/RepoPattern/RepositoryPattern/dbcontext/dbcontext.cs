using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace RepositoryPattern.dbcontext
{        
    public class dbcontext:DbContext
    {
        public dbcontext (DbContextOptions options) :base(options) { }   
        public DbSet<employeeModel> Employeess { get; set; }
    }
}
