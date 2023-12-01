using Authorization.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Collections.Generic;

namespace Authorization.DataBase
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions options) : base(options) { }

    }
}
