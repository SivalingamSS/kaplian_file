using BusiinessLibrary.Interface;
using DatatLibrary.Interface;
using DBClass.ViewModal;

namespace BusiinessLibrary.Class
{
    public class BusinessClass : BusinessInterface
    {
        private readonly DataInterface _dataInterface;
        public BusinessClass(DataInterface dataInterface)
        {
            _dataInterface = dataInterface;
        }
        public async Task<object> GET_SP()
        {
            var get = await _dataInterface.GET_SP();
            return get;
        }
        public async Task<object> POST_SP(ViewClass view)
        {
            var post = await _dataInterface.POST_SP(view);
            return post;
        }
        public async Task<object> PUT_SP(ViewClass view)
        {
            var put = await _dataInterface.PUT_SP(view);
            return put;
        }
        public async Task<object> DELETE_SP(int id)
        {
            var delete = await _dataInterface.DELETE_SP(id);
            return delete;
        }

    }
}
