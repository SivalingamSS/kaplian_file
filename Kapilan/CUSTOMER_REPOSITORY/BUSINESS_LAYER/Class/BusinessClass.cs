using BUSINESS_LAYER.Interface;
using CUSTOMER_MODAL.Modal;
using DATA_LAYER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS_LAYER.Class
{
    public class BusinessClass : IBusiness
    {
        private readonly IData _IData;
        public BusinessClass(IData idata)
        {
            _IData = idata;
        }
        public object GetValue()
        {
            var get = _IData.GetValue();
            return get;
        }
        public object PostValue(ModalClass id)
        {
            var post = _IData.PostValue(id);
            return post;
        }
        public object PutValue(int id, ViewModal Data)
        {
            var put = _IData.PutValue(id,Data);
            return put;
        }
        public object DeleteValue(int id)
        {
            var delete = _IData.DeleteValue(id);
            return delete;
        }
    }
}
