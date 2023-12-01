using CUSTOMER_MODAL.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOMER_MODAL.dbcontext
{
    public class dbcontact : DbContext
    {
        public dbcontact(DbContextOptions options) : base(options) { }
        public DbSet<ModalClass> TBL_CUSTOMER_DETAIL { get; set; }
    }
}
