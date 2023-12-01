using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Interafce
{
    public interface IData
    {
        public Task<object> GetData(int id);
    }
}
