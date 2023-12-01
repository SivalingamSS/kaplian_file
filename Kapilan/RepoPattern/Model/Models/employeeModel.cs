using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class UserResponse<T>
    {
        public T Message { get; set; }
        public bool IsSuccess { get; set; }
        public string Errors { get; set; }
    }
}
