using Common.Modal;


namespace BusinessLayer.Interface
{
    public interface IBusiness
    {
        public Task<object> Register(ViewModal use);
    }
}
