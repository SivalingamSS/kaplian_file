using Azure_ServiceBus.Modal;

namespace Azure_ServiceBus.Interface
{
    public interface IServiceBus
    {
        public Task SendMessageAsync(CarDetails carDetails);
    }
}
