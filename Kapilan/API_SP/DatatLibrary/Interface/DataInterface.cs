using DBClass.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatLibrary.Interface
{
    public interface DataInterface
    {
        public Task<object> GET_SP();
        public Task<object> POST_SP(ViewClass view);
        public Task<object> PUT_SP(ViewClass view);
        public Task<object> DELETE_SP(int id);
    }
}
