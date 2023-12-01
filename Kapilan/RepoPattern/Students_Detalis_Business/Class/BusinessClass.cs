using Microsoft.VisualBasic;
using Students_Detalis_Business.Interface;
using Students_Detalis_Data.Interface;
using Students_Detalis_dbcontext.Students_Detalis_ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detalis_Business.Class
{
    public  class BusinessClass: IBusiness
    {
        private readonly IData _IData;
        public BusinessClass(IData iData)
        {
            _IData = iData;
        }
        public object Getvalues()
        {
            var get = _IData.Getvalues();
            return get;
        }
        public object Postvalue(Students_model  id)
        {
            var res = _IData.Postvalue(id);
            return res;

        }
        public object Putvalue(int id, view VAF)
        {
            var update = _IData.Putvalue(id,VAF);
            return update;
        }
        public object Deletevalue(int id)
        {
            var delete = _IData.Deletevalue(id);
            return delete;

        }


    }
}
