using BusinessLibrary.Interface;
using DataLibrary.Interafce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Class
{
    public class BusinessClass : IBusiness
    {
        private readonly IData _data;
        public BusinessClass(IData data)
        {
            _data = data;
        }
        public Task <object> GetData(int id)
        {
            var data = _data.GetData(id);
            return data;
        }
    }
}
