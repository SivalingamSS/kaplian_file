using Business_Layer.Interface_BL;
using DOT;
using DataAccess_Layer.Interface_DAL;

namespace Business_Layer
{
    public class Business : IBusiness
    {
        private readonly IData _IData;
        public Business(IData Idatalayer)
        {
            _IData = Idatalayer;
        }

        public Task<object> GET()
        {
            var Get_Values = _IData.GET();
            return Get_Values;


        }

        public Task<object> POST(View details)
        {
            var Post_Values = _IData.POST(details);
            return Post_Values;
        }
        public Task<object> PUT(View details)
        {
            var Put_Values = _IData.PUT(details);
            return Put_Values;
        }
       public Task<object> DELETE(int id)
        {
            var Delete_Values = _IData.DELETE(id);
            return Delete_Values;
        }
    }
}
        