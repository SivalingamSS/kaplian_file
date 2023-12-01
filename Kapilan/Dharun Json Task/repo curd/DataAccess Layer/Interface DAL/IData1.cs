using DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Interface_DAL
{
    public interface IData
    {
        public Task<object> GET();
        public Task<object> POST(View details);
        public Task<object> PUT(View details);
        public Task<object> DELETE(int id);

    }
}
