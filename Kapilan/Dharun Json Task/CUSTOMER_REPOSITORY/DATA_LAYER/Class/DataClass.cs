using CUSTOMER_MODAL.dbcontext;
using CUSTOMER_MODAL.Modal;
using DATA_LAYER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DATA_LAYER.Class
{
    public class DataClass : IData
    {
        private readonly dbcontact _dbcontact;
        public DataClass(dbcontact DBcontact)
        {
            _dbcontact = DBcontact;
        }
        public object GetValue()
        {
            var getdata = _dbcontact.TBL_CUSTOMER_DETAIL.ToList();
            return getdata;
        }
        public object PostValue(ModalClass id)
        {
            var postdata = new ModalClass()
            { 
                CUSTOMER_ID=id.CUSTOMER_ID,
                CUSTOMER_NAME = id.CUSTOMER_NAME,
                CUSTOMER_AGE = id.CUSTOMER_AGE,
                CUSTOMER_ADDRESS = id.CUSTOMER_ADDRESS,
            };
            _dbcontact.TBL_CUSTOMER_DETAIL.Add(postdata);
            _dbcontact.SaveChanges();
            return postdata;
        }
        public object PutValue(int id, ViewModal Data)
        {
            var putdata = _dbcontact.TBL_CUSTOMER_DETAIL.Find(id);
                if (putdata != null)
                {
                    putdata.CUSTOMER_NAME = Data.CUSTOMER_NAME;
                    putdata.CUSTOMER_AGE = Data.CUSTOMER_AGE;
                    putdata.CUSTOMER_ADDRESS = Data.CUSTOMER_ADDRESS;
                    _dbcontact.SaveChanges();
                    return putdata;
                }
            return putdata;
        }
        public object DeleteValue(int id)
        {
            var deldata = _dbcontact.TBL_CUSTOMER_DETAIL.Find(id);
            if(deldata != null)
            {
                _dbcontact.Remove(deldata);
                _dbcontact.SaveChanges();
                return deldata;
            }
            return deldata;
        }

    }
}
