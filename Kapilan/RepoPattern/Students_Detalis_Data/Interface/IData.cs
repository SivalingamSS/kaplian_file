using Students_Detalis_dbcontext.Students_Detalis_ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detalis_Data.Interface
{
    public interface IData
    {
        public object Getvalues();
        public object Postvalue( Students_model id);
        public object Putvalue(int id, view VAF);
        public object Deletevalue(int id);
    }
}
