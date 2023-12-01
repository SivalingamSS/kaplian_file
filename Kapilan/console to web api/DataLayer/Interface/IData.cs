using Common.Modal;


namespace DataLayer.Interface
{
    public interface IData
    {
        public Task<object> Register(ViewModal use);
    }
}
