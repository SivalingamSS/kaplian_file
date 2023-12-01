using BLL.Sample.Interface;
using DAL.Sample.Interface;

namespace BLL.Sample.Service
{
    public class SampleBusiness:ISampleBusiness
    {
        private readonly ISampleData _sampleData;
        public SampleBusiness(ISampleData sampleData)
        {
            _sampleData= sampleData;
        }

        public string getString()
        {
            return _sampleData.Get();
        }
    }
}
