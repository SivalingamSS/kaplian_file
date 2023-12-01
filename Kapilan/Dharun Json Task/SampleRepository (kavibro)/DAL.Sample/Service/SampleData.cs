using DAL.Sample.Interface;
using Entities.Sample.DBContext;

namespace DAL.Sample.Service
{
    public class SampleData:ISampleData
    {
        private readonly DBcontext _con;
        public SampleData(DBcontext con)
        {
            _con = con;
        }

        public string Get()
        {
            return "Ping";
        }
    }
}
