using Model.Model;
using Model.Teacher;
using Model.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness_Layer.BInterface
{
    public interface IBusiness
    {
        public Task<string> GenerateToken(string password);
        public Task<StudentModel> Register(StudentModel stud);
        public Task<string> Authorize(string name, string password);
        public Task<string> Login(string name , string password);
        public Task<StudentModel> GetStudent(int id);
        public Task<StudentModel> PutStudent(int id,UserModel put);
        public Task<TeacherModel> Reg(TeacherModel teach);
        public Task<TeacherModel> GetTeacher(int id);

    }
}
