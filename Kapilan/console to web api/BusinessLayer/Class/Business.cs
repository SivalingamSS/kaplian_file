using BusinessLayer.Interface;
using Common.Modal;
using DataLayer.Interface;


namespace BusinessLayer.Class
{
    public class Business : IBusiness
    {
        private readonly IData _idata;
        public Business(IData data)
        {
            _idata = data;
        }
        public async Task<object> Register(ViewModal use)
        {
            var get = _idata.Register(use);
            return get;
        }
    }
}
