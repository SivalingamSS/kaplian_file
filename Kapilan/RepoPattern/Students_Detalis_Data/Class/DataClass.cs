using Microsoft.EntityFrameworkCore;
using Students_Detalis_Data.Interface;
using Students_Detalis_dbcontext;
using Students_Detalis_dbcontext.Students_Detalis_ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detalis_Data.Class
{
    public class DataClass:IData
    {
        private readonly Students_dbcontext _Students_dbcontext;
        public DataClass(Students_dbcontext students_dbcontext)
        {
            _Students_dbcontext = students_dbcontext;
        }
        public object Getvalues()
        {
                var result = _Students_dbcontext.TBL_Students_Details.ToList();
                return result;
        }
        public object Postvalue(Students_model  id)
        {
            var Name = new Students_model()
            {
                Students_ID = id.Students_ID,
                Students_Name = id.Students_Name,
                Students_Age = id.Students_Age,
                Students_Address = id.Students_Address,
            };
            _Students_dbcontext.TBL_Students_Details.Add(Name);
            _Students_dbcontext.SaveChanges();
            return Name;
        }
        public object Putvalue(int id, view VAF)
            
        {
            var contact = _Students_dbcontext.TBL_Students_Details.Find(id);
            if (contact != null)
            {
                contact.Students_Name = VAF.Students_Name;
                contact.Students_Age = VAF.Students_Age;
                contact.Students_Address = VAF.Students_Address;
                _Students_dbcontext.SaveChanges();
                return contact;
            }
            return contact;

        }
        public object Deletevalue(int id)
        {
            var contact = _Students_dbcontext.TBL_Students_Details.Find(id);
            if (contact != null)
            {
                _Students_dbcontext.Remove(contact);
                _Students_dbcontext.SaveChanges();
                return contact;
            }
            return contact;
        }
    }
}
