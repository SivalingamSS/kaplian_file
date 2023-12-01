using DBClass.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Interface
{
    public interface IBusiness
    {
        public Task <object> GetValue();
        public Task <object> PostValue(ViewModal id);
        public Task <object> PutValue(int staffid , ViewModal modal);
        public Task <object> DeleteValue(int id);
    }
}
