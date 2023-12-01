using Microsoft.EntityFrameworkCore;
using Model.Admin;
using Model.Model;
using Model.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Database
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        public DbSet<StudentModel> tbl_student { get; set; }
        public DbSet<TeacherModel> tbl_teacher { get; set; }
        public DbSet<AdminModel> tbl_admin { get; set; }
    }
}
