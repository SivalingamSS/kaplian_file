using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Interface
{
    public interface IBusiness
    {
        public Task<object> GetData(int id);
    }
}
