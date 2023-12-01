using MODEL.VIEW_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.IData
{
    internal interface IData
    {
        public Task<object> GET();
        public Task<object> POST(view details);
        public Task<object> PUT(view details);
        public Task<object> DELETE(int id);
    }
}
