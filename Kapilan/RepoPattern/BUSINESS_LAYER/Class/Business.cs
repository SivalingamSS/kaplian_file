using BUSINESS_LAYER.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS_LAYER.Class
{
    public class Business: IBusiness
    {

        private readonly IBusiness _IBusiness;
        public Business (IBusiness Ibusiness)
        {
            _IBusiness = Ibusiness;
        }
        public Task<bool> DeleteDetails(int Id)
        {
            var delete = _IBusiness.DeleteDetails(Id);
            return delete;
        }

        public Task<object> GetDetails()
        {
            var get = _IBusiness.GetDetails();
            return get;
        }

        public UserResponse<string> PostDetail(Registration student)
        {
            var res = _IBusiness.PostDetail(student);
            return res;
        }

        public UserResponse<string> UpdateDetails(StudentViewModel Update)
        {
            var update = _IBusiness.UpdateDetails(Update);
            return update;
        }
    }
}


