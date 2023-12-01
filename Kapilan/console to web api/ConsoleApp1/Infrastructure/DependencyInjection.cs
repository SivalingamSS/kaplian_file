using BusinessLayer.Class;
using BusinessLayer.Interface;
using DataLayer.Class;
using DataLayer.Interface;

namespace ConsoleApp1.Infrastructure
{
    public class DependencyInjection
    {
        public static void DependencyRegistrartion(IServiceCollection Services)
        {
            Services.AddScoped<IBusiness, Business>();
            Services.AddScoped<IData, Data>();
        }
    }
}
