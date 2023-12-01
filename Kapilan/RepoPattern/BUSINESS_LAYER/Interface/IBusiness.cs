using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS_LAYER.Interface
{
    public interface IBusiness
    {
        UserResponse <string> PostDetail(Registration student);
        Task<object> GetDetails();
        UserResponse<string> UpdateDetails(StudentViewModel Update);
        Task<bool> DeleteDetails(int Id);
    }
}
