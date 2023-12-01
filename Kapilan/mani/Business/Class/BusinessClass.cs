using Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class BusinessClass: IBusiness
    {
        private readonly IBusiness _IBusiness;
        public BusinessClass(IBusiness iBusiness)
        {
            _IBusiness = iBusiness;
        }
        public void Empmethods()
        {

        }
    }
}
