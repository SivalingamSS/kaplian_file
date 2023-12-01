using BUSINESSLAYER.IBusiness;
using MODEL.VIEW_MODEL;
using DATALAYER.IData;
using System.Xml.Linq;

namespace BUSINESSLAYER
{
    public class Class1: Interface1
    {
          private readonly IData _IData;
            public Interface1(IData Idatalayer)
            {
                _IData = Idatalayer;
            }

            public Task<object> GET()
            {
                var Get_Values = _IData.GET();
                return Get_Values;
            }

            public Task<object> POST(view details)
            {
                var Post_Values = _IData.POST(details);
                return Post_Values;
            }
            public Task<object> PUT(view details)
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

}
}