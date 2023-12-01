using Buisness_Layer.BInterface;
using DataLayer.DInterface;
using Model.Model;
using Model.Teacher;
using Model.ViewModal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buisness_Layer.BClass
{
    public class BusinessClass : IBusiness
    {
        private readonly IData _IData;
        public BusinessClass(IData idata)
        {
            _IData = idata;
        }
        public Task<string> GenerateToken(string password)
        {
            var get = _IData.GenerateToken(password);
            return get;
        }
        public Task<StudentModel> Register(StudentModel stud)
        {
            var reg = _IData.Register(stud);
            return reg;
        }
        public Task<string> Authorize(string name, string password)
        {
            var log = _IData.Authorize(name, password);
            return log;
        }
        public Task<string> Login(string name, string password)
        {
            var login = _IData.Login(name, password);
            return login;
        }
        public Task<StudentModel> GetStudent(int id)
        {
            var student = _IData.GetStudent(id);
            return student;
        }
        public Task<StudentModel> PutStudent(int id,UserModel put)
        {
            var date = _IData.PutStudent(id,put);
            return date;
        }
        public Task<TeacherModel> Reg(TeacherModel teach)
        {
            var pot = _IData.Reg(teach);
            return pot;
        }
        public Task<TeacherModel> GetTeacher(int id)
        {
            var std = _IData.GetTeacher(id);
            return std;
        }
    }
}

