using AutoMapper.Configuration;
using DataLayer.DInterface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.Database;
using Model.Model;
using Model.ViewModal;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Model.Encrypt_Extension;
using System.Data;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Model.Teacher;
using System.Diagnostics;

namespace DataLayer.DClass
{
    public class DataClass : IData
    {
        private readonly DBContext _dbcontact;
        private readonly IConfiguration _configuration;
        public DataClass(DBContext DBcontact, IConfiguration configuration)
        {
            _dbcontact = DBcontact;
            _configuration = configuration;
        }
        public async Task<string> GenerateToken(string password)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Role,password)
            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<StudentModel> Register(StudentModel stud)
        {
            StudentModel model = new StudentModel()
            {
                student_id = stud.student_id,
                student_name = stud.student_name,
                student_address = stud.student_address,
                password = Encrypt_Class.encrypt(stud.password),
                roll = stud.roll,

            };
            _dbcontact.tbl_student.Add(model);
            _dbcontact.SaveChanges();
            return model;
        }
        public async Task<string> Authorize(string name, string password)
        {
            List<string> std = new List<string>();
            List<string> tch = new List<string>();
            List<string> adm = new List<string>();
            var student = _dbcontact.tbl_student.Where(x => x.student_name == name && x.password == Encrypt_Class.encrypt(password)).FirstOrDefault();
            var teacher = _dbcontact.tbl_teacher.Where(x => x.teacher_name == name && x.password == Encrypt_Class.encrypt(password)).FirstOrDefault();
            var admin = _dbcontact.tbl_admin.Where(x => x.admin_name == name && x.password == Encrypt_Class.encrypt(password)).FirstOrDefault();
            if (student != null)
            {
                std.Add(student.student_name);
                std.Add(student.roll);
            }
            else if (teacher != null)
            {
                tch.Add(teacher.teacher_name);
                tch.Add(teacher.roll);
            }
            else if (admin != null)
            {
                adm.Add(admin.admin_name);
                adm.Add(admin.roll);
            }
            return null;
        }

        //Authorization
        public Task<string> Login(string name, string password)
        {
            var user = Authorize(name, password);
            if (user != null)
            {
                var token = GenerateToken(user.ToString());
                return token;
            }
            return null;
        }
        public Task<StudentModel> GetStudent(int id)
        {
            List<object> list = new List<object>();
            var getdb = _dbcontact.tbl_student.Where(x => x.student_id == id).FirstOrDefault();
            if (getdb != null)
            {
                var deldata = _dbcontact.tbl_student.Find(id);
                list.Add(getdb);
            }
            return null;
        }
        public async Task<StudentModel> PutStudent(int id,UserModel put)
        {
            StudentModel program = new StudentModel()
            {
                student_name = put.Username,
                password = put.Password,
                roll = put.Role
            };

            // Assuming _dbcontact is your DbContext for Entity Framework
            _dbcontact.tbl_student.Add(program);
            await _dbcontact.SaveChangesAsync();

            return program;
        }

        public async Task<TeacherModel> Reg(TeacherModel teach)
        {
            TeacherModel modal = new TeacherModel()
            {
                 teacher_id= teach.teacher_id,
                teacher_name = teach.teacher_name,
                teacher_address = teach.teacher_address,
                password = Encrypt_Class.encrypt(teach.password),
                roll = teach.roll

            };
            _dbcontact.tbl_teacher.Add(modal);
            _dbcontact.SaveChanges();
            return modal;
        }
        public Task<TeacherModel> GetTeacher(int id)
        {
            List<object> list = new List<object>();
            var db = _dbcontact.tbl_teacher.Where(x => x.teacher_id == id).FirstOrDefault();
            if (db != null)
            {
                var del = _dbcontact.tbl_teacher.Find(id);
                list.Add(db);
            }
            return null;
        }
    }
}