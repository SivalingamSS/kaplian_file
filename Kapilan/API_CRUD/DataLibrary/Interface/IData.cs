using DBClass.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Interface
{
    public interface IData
    {
        public Task <object> GetValue();
        public Task <object> PostValue(ViewModal id);
        public Task<object> PutValue(int staffid, ViewModal modal);
        public Task<object> DeleteValue(int id);
    }
}
