using DataLibrary.Interface;
using DBClass.DB;
using DBClass.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Class
{
    public class DataClass : IData
    {
        private readonly DBContext _dbclass;
        public DataClass(DBContext dbclass)
        {
            _dbclass = dbclass;
        }
        public async Task <object> GetValue()
        {
            var get = (from table1 in _dbclass.API_DB
                       join table2 in _dbclass.API_DB_FK on
                       table1.staff_id equals table2.work_id
                       select new ViewModal
                       {
                           staff_id = table1.staff_id,
                           staff_name = table1.staff_name,
                           staff_age = table1.staff_age,
                           staff_city = table1.staff_city,
                           staff_mob_number = table1.staff_mob_number,
                           work_id=table2.work_id,
                           email_id = table2.email_id,
                           address = table2.address,
                       }).ToList();
            return get;
        }
        public async Task<object> PostValue(ViewModal id)
        {
            var post = new ModalClass()
            {
                staff_id = id.staff_id,
                staff_name = id.staff_name,
                staff_age = id.staff_age,
                staff_city = id.staff_city,
                staff_mob_number = id.staff_mob_number,
            };
            _dbclass.API_DB.Add(post);
            _dbclass.SaveChanges();

            var post2 = new MappingClass()
            {
                email_id = id.email_id,
                address = id.address,
                staff_id = post.staff_id
            };
            _dbclass.API_DB_FK.Add(post2);
            _dbclass.SaveChanges();

            return id;
        }
        public async Task<object> PutValue(int staffid, ViewModal modal)
        {
            var put = _dbclass.API_DB.Find(modal.staff_id);
            if (put != null)
            {
                put.staff_name = modal.staff_name;
                put.staff_age = modal.staff_age;
                put.staff_city = modal.staff_city;
                put.staff_mob_number = modal.staff_mob_number;
            };
            _dbclass.SaveChanges();
            var put1 = _dbclass.API_DB_FK.Find(modal.staff_id);
            if (put1 != null)
            {
                put1.email_id = modal.email_id;
                put1.address = modal.address;
            };
            _dbclass.SaveChanges();

            return modal;
        }
        public async Task<object> DeleteValue(int id)
        {
            var delete2 = _dbclass.API_DB_FK.Find(id);
            if (delete2 != null)
            {
                _dbclass.Remove(delete2);
                _dbclass.SaveChanges();
            }
            var delete1 = _dbclass.API_DB.Find(id);
            if(delete1 != null)
            {
                _dbclass.Remove(delete1);
                _dbclass.SaveChanges();
            }
            return id;
        }
    }
}
