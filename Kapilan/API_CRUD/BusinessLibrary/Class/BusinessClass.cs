using BusinessLibrary.Interface;
using DataLibrary.Interface;
using DBClass.Modal;

namespace BusinessLibrary.Class
{
    public class BusinessClass : IBusiness
    {
        private readonly IData _IData;
        public BusinessClass(IData idata)
        {
            _IData = idata;
        }
        public Task<object> GetValue()
        {
            var get = _IData.GetValue();
            return get;
        }
        public Task<object> PostValue(ViewModal id)
        {
            var post = _IData.PostValue(id);
            return post;
        }
        public Task<object> PutValue(int staffid, ViewModal modal)
        {
            var put = _IData.PutValue(staffid, modal);
            return put;
        }
        public Task <object> DeleteValue(int id)
        {
            var delete = _IData.DeleteValue(id);
            return delete;
        }
    }
}
