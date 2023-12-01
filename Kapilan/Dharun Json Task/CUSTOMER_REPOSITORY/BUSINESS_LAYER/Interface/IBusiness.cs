using CUSTOMER_MODAL.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS_LAYER.Interface
{
    public interface IBusiness
    {
        public object GetValue();
        public object PostValue(ModalClass id);
        public object PutValue(int id,ViewModal Data);
        public object DeleteValue(int id);
    }
}
