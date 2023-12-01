using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Operation1.Model;

namespace Operation1.DBContact
{
   
        public class ContactsAPIDbContext : DbContext
        {
            public ContactsAPIDbContext(DbContextOptions options) : base(options) { }
           // public DbSet<EmployeeModel> Employee { get;set;}
            public DbSet<Excel> Persons { get;set;}
    }

}
